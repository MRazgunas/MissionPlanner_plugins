namespace MissionPlanner.Plugins.Suopis2Control
{
    using System;
    using System.Windows.Forms;

    using MissionPlanner;
    public class Suopis2ControlPlugin : MissionPlanner.Plugin.Plugin
    {
        public override string Name => "Suopis2 Controls";
        public override string Version => "1.0";
        public override string Author => "Matas Razgunas";

        private ToolStripMenuItem configMenuItem;
        private Suopis2ControlForm controlForm;

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            this.configMenuItem = new ToolStripMenuItem("Suopis2 control");
            configMenuItem.Click += ConfigMenuItem_Click;
            this.Host.FDMenuMap.Items.Add(configMenuItem);

            controlForm = new Suopis2ControlForm();
            return true;
        }

        public override bool Exit()
        {
            return true;
        }

        public override bool Loop()
        {
            if (MainV2.comPort.MAV.cs.ch7out > 1700)
                controlForm.setLedStatusDispaly(true);
            else if (MainV2.comPort.MAV.cs.ch7out < 1200)
                controlForm.setLedStatusDispaly(false);

            for (int i = MainV2.comPort.MAV.cs.messages.Count - 1; i >= 0; i--)
            {
                String a = MainV2.comPort.MAV.cs.messages[i];
                if (a.StartsWith("PARA1"))
                {
                    controlForm.setParachuteFSDisplay(true);
                    break;
                }
                else if(a.StartsWith("PARA2"))
                {
                    controlForm.setParachuteFSDisplay(false);
                    break;
                }
                controlForm.setLedStatusDispaly(false);
            }
            return base.Loop();
        }

        private void ConfigMenuItem_Click(object sender, EventArgs e)
        {
            if(!controlForm.Visible)
            {
                controlForm.Show();
            }

        }
    }
}
