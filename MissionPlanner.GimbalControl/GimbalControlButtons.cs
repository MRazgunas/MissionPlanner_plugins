using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MissionPlanner;

namespace MissionPlanner.Plugins.GimbalControl
{
    public partial class GimbalControlButtons : Form
    {
        private Utilities.Settings config;
        private bool isSettingLoaded = false;
        private String lastSelectedGimbal = "";
        private double pitchOffset = 0;
        private double yawOffset = 0;

        private double[] position = new double[3]; //All axes values;

        public GimbalControlButtons(Utilities.Settings conf)
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Key_KeyDown);
            config = conf;
        }


        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        void Key_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(manualControl.Checked)
            {
                double step_size = (double)manStepSize.Value;
                if (e.KeyCode == Keys.Up) position[0] += step_size;
                if (e.KeyCode == Keys.Down) position[0] -= step_size;
                if (e.KeyCode == Keys.Left) position[2] -= step_size;
                if (e.KeyCode == Keys.Right) position[2] += step_size;

                updateGimbaleAngles(position[0], position[1], position[2]);
            }
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            //Servo number, PWM, Cycle count, cycle time (seconds)
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_REPEAT_SERVO, 11.0f, 1000.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f, false);
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_REPEAT_SERVO, 11.0f, 2000.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f, false);
        }

        private void trimUp_Click(object sender, EventArgs e)
        {
            if (isSettingLoaded)
            {
                pitchOffset += (float)trimStep.Value;
                if (pitchOffset > 180.0) pitchOffset = -180.0;
                else if (pitchOffset <= -180.0) pitchOffset = 180.0;
                updateGimbalPitchOffset(pitchOffset);
                updateConfig();
            }
        }

        private void trimDown_Click(object sender, EventArgs e)
        {
            if (isSettingLoaded)
            {
                pitchOffset -= (float)trimStep.Value;
                if (pitchOffset > 180.0) pitchOffset = -180.0;
                else if (pitchOffset <= -180.0) pitchOffset = 180.0;
                updateGimbalPitchOffset(pitchOffset);
                updateConfig();
            }
        }

        private void trimLeft_Click(object sender, EventArgs e)
        {
            if (isSettingLoaded)
            {
                yawOffset -= (float)trimStep.Value;
                if (yawOffset > 180.0) yawOffset = -180.0;
                else if (yawOffset <= -180.0) yawOffset = 180.0;
                updateGimbalYawOffset(yawOffset);
                updateConfig();
            }
        }

        private void trimRight_Click(object sender, EventArgs e)
        {
            if(isSettingLoaded)
            {
                yawOffset += (float)trimStep.Value;
                if (yawOffset > 180.0) yawOffset = -180.0;
                else if (yawOffset <= -180.0) yawOffset = 180.0;
                updateGimbalYawOffset(yawOffset);
                updateConfig();
            }
        }

        private void btnReatract_Click(object sender, EventArgs e)
        {
            if (MainV2.comPort.MAV.param.ContainsKey("MNT_MODE"))
            {
                MainV2.comPort.setParam("MNT_MODE", (double)MAVLink.MAV_MOUNT_MODE.RETRACT);
            }
            else
            {
                // copter 3.3 acks with an error, but is ok
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONTROL, 0, 0, 0, 0, 0, 0,
                    (float)MAVLink.MAV_MOUNT_MODE.RETRACT);
            }
        }

        private void btnNeutral_Click(object sender, EventArgs e)
        {
            if (MainV2.comPort.MAV.param.ContainsKey("MNT_MODE"))
            {
                MainV2.comPort.setParam("MNT_MODE", (double)MAVLink.MAV_MOUNT_MODE.NEUTRAL);
            }
            else
            {
                // copter 3.3 acks with an error, but is ok
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONTROL, 0, 0, 0, 0, 0, 0,
                    (float)MAVLink.MAV_MOUNT_MODE.NEUTRAL);
            }

        }

        private void chkLookAhead_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLookAhead.Checked)
            {
                double yawAngle = 0.0f;
                if (MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Z"))
                {
                    yawAngle = MainV2.comPort.MAV.param["MNT_NEUTRAL_Z"].GetValue();
                }
                MainV2.comPort.doCommand(1, 67, MAVLink.MAV_CMD.DO_MOUNT_CONFIGURE, 0.0f, 0.0f, 0.0f, 0.0f,
                    0.0f, 0.0f, 0.0f, false);
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONTROL, (float)numLookAngle.Value * 100, 0.0f,
                    (float)yawAngle * 100, 0.0f, 0.0f, 0.0f, (float)MAVLink.MAV_MOUNT_MODE.MAVLINK_TARGETING);
            }
        }

        private void numLookAngle_ValueChanged(object sender, EventArgs e)
        {
            if(chkLookAhead.Checked)
            {
                double yawAngle = 0.0f;
                if (MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Z"))
                {
                    yawAngle = MainV2.comPort.MAV.param["MNT_NEUTRAL_Z"].GetValue();
                }
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONTROL, (float)numLookAngle.Value * 100, 0.0f,
                    (float)yawAngle * 100, 0.0f, 0.0f, 0.0f, (float)MAVLink.MAV_MOUNT_MODE.MAVLINK_TARGETING);

            }
        }

        private bool updateGimbalPitchOffset(double pitch)
        {
            if (MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Y"))
            {
                MainV2.comPort.setParam("MNT_NEUTRAL_Y", pitch, false);
                return true;
            }
            return false;

        }

        private bool updateGimbalYawOffset(double yaw)
        {
            if (MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Z"))
            {
                MainV2.comPort.setParam("MNT_NEUTRAL_Z", yaw, false);
                return true;
            }
            return false;
        }

        private void updateConfig()
        {
            if(config != null)
            {
                config[lastSelectedGimbal + "_gimbal_settings"] = pitchOffset + ":" + yawOffset;
            }
        }

        private void btnLoadSetting_Click(object sender, EventArgs e)
        {
            if(gimbalSelector.SelectedItem != null)
            {
                if(config.ContainsKey(gimbalSelector.SelectedItem.ToString() + "_gimbal_settings"))
                {
                    var s = config[gimbalSelector.SelectedItem.ToString() + "_gimbal_settings"];
                    if(s.Contains(":"))
                    {
                        var v = s.Split(':');
                        pitchOffset = Convert.ToDouble(v[0]);
                        yawOffset = Convert.ToDouble(v[1]);
                        if (updateGimbalPitchOffset(pitchOffset) && updateGimbalYawOffset(yawOffset))
                        {
                            isSettingLoaded = true;
                            lastSelectedGimbal = gimbalSelector.SelectedItem.ToString();
                            this.Text = "Gimbal " + lastSelectedGimbal;
                        }
                        else gimbalSelector.SelectedItem = null;                        
                    }
                }
                else //We have no memory of this gimbal. Use setting from MAV
                {
                    if (MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Z") && MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Z"))
                    {
                        yawOffset = MainV2.comPort.MAV.param["MNT_NEUTRAL_Z"].Value;
                        pitchOffset = MainV2.comPort.MAV.param["MNT_NEUTRAL_Y"].Value;
                        isSettingLoaded = true;
                        lastSelectedGimbal = gimbalSelector.SelectedItem.ToString();
                        updateConfig(); //Save settings
                        this.Text = "Gimbal " + lastSelectedGimbal;
                    }
                    else gimbalSelector.SelectedItem = null;
                }
             
            }
        }

        private void manualControl_CheckedChanged(object sender, EventArgs e)
        {
            if (manualControl.Checked && MainV2.comPort.MAVlist.Contains(1, 67))
            {
                position[0] = MainV2.comPort.MAV.cs.campointa;
                position[1] = 0.0;//MainV2.comPort.MAVlist[1, 61].cs.roll;
                position[2] = MainV2.comPort.MAV.cs.campointc;
                if (MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Z") && MainV2.comPort.MAV.param.ContainsKey("MNT_NEUTRAL_Y"))
                {
                    //position[2] -= MainV2.comPort.MAV.param["MNT_NEUTRAL_Z"].GetValue();
                    //position[0] -= MainV2.comPort.MAV.param["MNT_NEUTRAL_Y"].GetValue();
                }
                updateGimbaleAngles(position[0], position[1], position[2]);
                MainV2.comPort.doCommand(1, 67, MAVLink.MAV_CMD.DO_MOUNT_CONFIGURE, 0.0f, 0.0f, 0.0f, 1.0f,
                    0.0f, 0.0f, 0.0f, false);
            }
        }

        private void updateGimbaleAngles(double pitch, double roll, double yaw)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONTROL, (float)pitch*100, 0.0f,
                    (float)yaw*100, 0.0f, 0.0f, 0.0f, (float)MAVLink.MAV_MOUNT_MODE.MAVLINK_TARGETING, false);

        }
    }
}
