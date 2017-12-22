namespace MissionPlanner.Plugins.Suopis2Control
{
    partial class Suopis2ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLedOn = new System.Windows.Forms.Button();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.btnVideoOn = new System.Windows.Forms.Button();
            this.btnVideoOff = new System.Windows.Forms.Button();
            this.ledStatusLabel = new System.Windows.Forms.Label();
            this.paraFSOn = new System.Windows.Forms.Button();
            this.paraFSOff = new System.Windows.Forms.Button();
            this.paraFSstate = new System.Windows.Forms.Label();
            this.openParachute = new System.Windows.Forms.Button();
            this.resetPara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLedOn
            // 
            this.btnLedOn.Location = new System.Drawing.Point(12, 12);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(120, 30);
            this.btnLedOn.TabIndex = 0;
            this.btnLedOn.Text = "Led On";
            this.btnLedOn.UseVisualStyleBackColor = true;
            this.btnLedOn.Click += new System.EventHandler(this.btnLedOn_Click);
            // 
            // btnLedOff
            // 
            this.btnLedOff.Location = new System.Drawing.Point(138, 12);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(120, 30);
            this.btnLedOff.TabIndex = 1;
            this.btnLedOff.Text = "Led Off";
            this.btnLedOff.UseVisualStyleBackColor = true;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // btnVideoOn
            // 
            this.btnVideoOn.Location = new System.Drawing.Point(12, 48);
            this.btnVideoOn.Name = "btnVideoOn";
            this.btnVideoOn.Size = new System.Drawing.Size(120, 30);
            this.btnVideoOn.TabIndex = 2;
            this.btnVideoOn.Text = "Video On";
            this.btnVideoOn.UseVisualStyleBackColor = true;
            this.btnVideoOn.Click += new System.EventHandler(this.btnVideoOn_Click);
            // 
            // btnVideoOff
            // 
            this.btnVideoOff.Location = new System.Drawing.Point(138, 48);
            this.btnVideoOff.Name = "btnVideoOff";
            this.btnVideoOff.Size = new System.Drawing.Size(120, 30);
            this.btnVideoOff.TabIndex = 3;
            this.btnVideoOff.Text = "Video off";
            this.btnVideoOff.UseVisualStyleBackColor = true;
            this.btnVideoOff.Click += new System.EventHandler(this.btnVideoOff_Click);
            // 
            // ledStatusLabel
            // 
            this.ledStatusLabel.BackColor = System.Drawing.Color.Red;
            this.ledStatusLabel.Location = new System.Drawing.Point(264, 12);
            this.ledStatusLabel.Name = "ledStatusLabel";
            this.ledStatusLabel.Size = new System.Drawing.Size(51, 30);
            this.ledStatusLabel.TabIndex = 4;
            this.ledStatusLabel.Text = "Off";
            this.ledStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paraFSOn
            // 
            this.paraFSOn.Location = new System.Drawing.Point(12, 84);
            this.paraFSOn.Name = "paraFSOn";
            this.paraFSOn.Size = new System.Drawing.Size(120, 30);
            this.paraFSOn.TabIndex = 5;
            this.paraFSOn.Text = "Para FS On";
            this.paraFSOn.UseVisualStyleBackColor = true;
            this.paraFSOn.Click += new System.EventHandler(this.paraFSOn_Click);
            // 
            // paraFSOff
            // 
            this.paraFSOff.Location = new System.Drawing.Point(138, 84);
            this.paraFSOff.Name = "paraFSOff";
            this.paraFSOff.Size = new System.Drawing.Size(120, 30);
            this.paraFSOff.TabIndex = 6;
            this.paraFSOff.Text = "Para FS Off";
            this.paraFSOff.UseVisualStyleBackColor = true;
            this.paraFSOff.Click += new System.EventHandler(this.paraFSOff_Click);
            // 
            // paraFSstate
            // 
            this.paraFSstate.BackColor = System.Drawing.Color.Red;
            this.paraFSstate.Location = new System.Drawing.Point(264, 84);
            this.paraFSstate.Name = "paraFSstate";
            this.paraFSstate.Size = new System.Drawing.Size(51, 30);
            this.paraFSstate.TabIndex = 7;
            this.paraFSstate.Text = "Off";
            this.paraFSstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openParachute
            // 
            this.openParachute.Location = new System.Drawing.Point(12, 120);
            this.openParachute.Name = "openParachute";
            this.openParachute.Size = new System.Drawing.Size(246, 30);
            this.openParachute.TabIndex = 8;
            this.openParachute.Text = "Open Parachute";
            this.openParachute.UseVisualStyleBackColor = true;
            this.openParachute.Click += new System.EventHandler(this.openParachute_Click);
            // 
            // resetPara
            // 
            this.resetPara.Location = new System.Drawing.Point(12, 202);
            this.resetPara.Name = "resetPara";
            this.resetPara.Size = new System.Drawing.Size(246, 30);
            this.resetPara.TabIndex = 9;
            this.resetPara.Text = "Reset parachute";
            this.resetPara.UseVisualStyleBackColor = true;
            this.resetPara.Click += new System.EventHandler(this.resetPara_Click);
            // 
            // Suopis2ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 244);
            this.Controls.Add(this.resetPara);
            this.Controls.Add(this.openParachute);
            this.Controls.Add(this.paraFSstate);
            this.Controls.Add(this.paraFSOff);
            this.Controls.Add(this.paraFSOn);
            this.Controls.Add(this.ledStatusLabel);
            this.Controls.Add(this.btnVideoOff);
            this.Controls.Add(this.btnVideoOn);
            this.Controls.Add(this.btnLedOff);
            this.Controls.Add(this.btnLedOn);
            this.Name = "Suopis2ControlForm";
            this.Text = "Suopis 2 control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLedOn;
        private System.Windows.Forms.Button btnLedOff;
        private System.Windows.Forms.Button btnVideoOn;
        private System.Windows.Forms.Button btnVideoOff;
        private System.Windows.Forms.Label ledStatusLabel;
        private System.Windows.Forms.Button paraFSOn;
        private System.Windows.Forms.Button paraFSOff;
        private System.Windows.Forms.Label paraFSstate;
        private System.Windows.Forms.Button openParachute;
        private System.Windows.Forms.Button resetPara;
    }
}