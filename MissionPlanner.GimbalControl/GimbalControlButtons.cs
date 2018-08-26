using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using MissionPlanner;
using GMap.NET.Core;

using SharpDX.DirectInput;

namespace MissionPlanner.Plugins.GimbalControl
{
    public partial class GimbalControlButtons : Form
    {
        private Utilities.Settings config;
        private bool isSettingLoaded = false;
        private String lastSelectedGimbal = "";
        private double pitchOffset = 0;
        private double yawOffset = 0;

        private GimbalControlPlugin plugin;

        private double[] position = new double[3]; //All axes values;

        Timer joystickPoll;
        SharpDX.DirectInput.Joystick joystick;
        DirectInput directInput = new DirectInput();
        Guid joystickGuid = Guid.Empty;

        public GimbalControlButtons(GimbalControlPlugin pl)
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;

            this.plugin = pl;

            plugin.Host.DeviceChanged += Host_DeviceChanged;

            Find_Joystick();            
            
            joystickPoll = new Timer();
            joystickPoll.Interval = 100;
            joystickPoll.Tick += new EventHandler(Joystick_Poll);
            joystickPoll.Enabled = true;
        }

        private void Host_DeviceChanged(MainV2.WM_DEVICECHANGE_enum cause)
        {
            Find_Joystick();
        }

        void Find_Joystick()
        {
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                joystickEnable.Enabled = false;
                joystickEnable.Checked = false;
            }
            else
            {
                // Instantiate the joystick
                joystick = new SharpDX.DirectInput.Joystick(directInput, joystickGuid);

                Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

                joystick.Properties.BufferSize = 128;
                // Acquire the joystick
                joystick.Acquire();
                joystickEnable.Enabled = true;

            }
        }

        void Joystick_Poll(object Sender, EventArgs e)
        {
            if (joystickGuid != Guid.Empty)
            {
                if (!directInput.IsDeviceAttached(joystickGuid))
                {
                    joystick.Dispose();
                    joystick = null;
                    joystickGuid = Guid.Empty;
                    joystickEnable.Enabled = false;
                    joystickEnable.Checked = false;
                }
            }

            JoystickState state = null;

            if (joystick != null)
            {
                joystick.Poll();
                state = joystick.GetCurrentState();
            }
            if (state != null)
            {
                if((bool)state.Buttons.GetValue(7))
                {
                   // if(Gimbal_FixCurrentLocation())
                    //    joystickEnable.Checked = false;
                    
                }
                if (joystickEnable.Checked)
                {
                    if (Math.Abs(state.Y - 32768) > 10)
                        position[0] = ((state.Y - 32768.0f) / 65536.0f * -2.0f) * 90.0f;
                    else
                        position[0] = 0.0f;
                    if (Math.Abs(state.X - 32768) > 10)
                        position[2] = ((state.X - 32768.0f) / 65536.0f * 2.0f) * 90.0f;
                    else
                        position[2] = 0.0f;
                    updateGimbaleAngles(position[0], position[1], position[2]);
                }
            }
        }

        bool Gimbal_FixCurrentLocation()
        {
            Utilities.PointLatLngAlt position = plugin.Host.cs.GimbalPoint;
            if (position != null)
            {
                if (position != Utilities.PointLatLngAlt.Zero)
                {
                    plugin.Host.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_ROI, 0, 0, 0, 0, (float)position.Lat, (float)position.Lng, (float)position.Alt, false);
                    return true;
                }
            }
            return false;
        }

        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            //Servo number, PWM, Cycle count, cycle time (seconds)
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_REPEAT_SERVO, 9.0f, 1000.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f, false);
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_REPEAT_SERVO, 9.0f, 2000.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f, false);
        }

        private void btnReatract_Click(object sender, EventArgs e)
        {
            joystickEnable.Checked = false;
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
            joystickEnable.Checked = false;
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

        private void updateGimbaleAngles(double pitch, double roll, double yaw)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONFIGURE, (float)MAVLink.MAV_MOUNT_MODE.MAVLINK_TARGETING, 
                1.0f, 1.0f, 1.0f, 1.0f, 0.0f, 0.0f, false);
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONTROL, (float)pitch*100, 0.0f,
                    (float)yaw*100, 0.0f, 0.0f, 0.0f, (float)MAVLink.MAV_MOUNT_MODE.MAVLINK_TARGETING, false);

        }

        private void joystickEnable_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
