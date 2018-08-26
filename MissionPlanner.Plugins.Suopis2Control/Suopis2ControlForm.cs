using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MissionPlanner.Controls;
using MissionPlanner.Joystick;
using MissionPlanner.Log;
using MissionPlanner.Utilities;
using MissionPlanner.Warnings;

namespace MissionPlanner.Plugins.Suopis2Control
{
    public partial class Suopis2ControlForm : Form
    {
        public Suopis2ControlForm()
        {
            InitializeComponent();

            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, 11, 1900,
                0, 0, 0, 0, 0, false);
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, 11, 1100,
                0, 0, 0, 0, 0, false);
        }

        private void btnVideoOn_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, 12, 1900,
                0, 0, 0, 0, 0, false);
        }

        private void btnVideoOff_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, 12, 1100,
                0, 0, 0, 0, 0, false);
        }

        public void setLedStatusDispaly(bool isOn)
        {
            if (isOn)
            {
                ledStatusLabel.BackColor = Color.Green;
                ledStatusLabel.Text = "On";
            }
            else
            {
                ledStatusLabel.BackColor = Color.Red;
                ledStatusLabel.Text = "Off";
            }
        }

        public void setParachuteFSDisplay(bool isOn)
        {
            if(isOn)
            {
                paraFSstate.BackColor = Color.Green;
                paraFSstate.Text = "On";
            }
            else
            {
                paraFSstate.BackColor = Color.Red;
                paraFSstate.Text = "Off";
            }
        }

        private void paraFSOn_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_PARACHUTE, 3, 0, 0, 0, 0, 0, 0);
        }

        private void paraFSOff_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_PARACHUTE, 4, 0, 0, 0, 0, 0, 0);
        }

        private void openParachute_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Show("Land Now?", "Parachute", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_PARACHUTE, (float)MAVLink.PARACHUTE_ACTION.PARACHUTE_RELEASE,
                    0, 0, 0, 0, 0, 0);
            }
        }

        private void resetPara_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Show("Reset parachute subsytem?", "Parachute", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_PARACHUTE, (float)MAVLink.PARACHUTE_ACTION.PARACHUTE_ENABLE,
                    0, 0, 0, 0, 0, 0);
            }
        }
    }
}
