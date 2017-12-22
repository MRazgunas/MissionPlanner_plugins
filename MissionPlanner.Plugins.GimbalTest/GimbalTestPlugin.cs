using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.Plugins.GimbalTest
{
    using MissionPlanner;
    using System.Windows.Forms;

    public class GimbalTestPlugin : MissionPlanner.Plugin.Plugin
    {
        public override string Name => "Gimbal Test utility";
        public override string Version => "1.0";
        public override string Author => "Matas Razgunas";

        private ToolStripMenuItem configMenuItem;

        private float pitch;
        private float yaw;

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            this.configMenuItem = new ToolStripMenuItem("Gimbal Test");
            configMenuItem.Click += ConfigMenuItem_Click;
            this.Host.FDMenuMap.Items.Add(configMenuItem);
            return true;
        }

        private void ConfigMenuItem_Click(object sender, EventArgs e)
        {
            var window = new GimbalTestForm(pitch, yaw);
            window.Show();
        }

        public override bool Exit()
        {
            return true;
        }

        public override bool Loop()
        {
            if(pitch != 0.0f)
            {

            }
            return base.Loop();
        }
    }
}
