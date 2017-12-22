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

namespace MissionPlanner.Plugins.GimbalTest
{
    public partial class GimbalTestForm : Form
    {
        float pitch;
        float yaw;
        public GimbalTestForm(float pitch, float yaw)
        {
            InitializeComponent();

        }

        private void btnSendAngles_Click(object sender, EventArgs e)
        {
            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_MOUNT_CONTROL, (float)pitchNumeric.Value*100, 0.0f,
                (float)yawNumeric.Value*100, 0.0f, 0.0f, 0.0f, (float)MAVLink.MAV_MOUNT_MODE.MAVLINK_TARGETING);
        }
    }
}
