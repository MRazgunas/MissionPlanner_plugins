namespace MissionPlanner.Plugins.GimbalControl
{
    using System;
    using System.Windows.Forms;

    using MissionPlanner;


    public class GimbalControlPlugin : MissionPlanner.Plugin.Plugin
    {

        public override string Name => "Gimbal Control";
        public override string Version => "1.0";
        public override string Author => "Matas Razgunas";

        private ToolStripMenuItem configMenuItem;
        private GimbalControlButtons gmbControlWindow;

        private Utilities.Settings config;

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            this.configMenuItem = new ToolStripMenuItem("Gimbal Control");
            configMenuItem.Click += ConfigMenuItem_Click;
            this.Host.FDMenuMap.Items.Add(configMenuItem);
            config = this.Host.config;

            gmbControlWindow = new GimbalControlButtons(config);
            return true;
        }

        private void ConfigMenuItem_Click(object sender, EventArgs e)
        {
            if (!gmbControlWindow.Visible)
            {
                gmbControlWindow.Show();
            }
        }

        public override bool Exit()
        {
            return true;
        }

        public override bool Loop()
        {
            return base.Loop();
        }
    }
}
