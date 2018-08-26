namespace MissionPlanner.Plugins.GimbalControl
{
    partial class GimbalControlButtons
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
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.btnReatract = new System.Windows.Forms.Button();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.joystickEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(12, 12);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(98, 30);
            this.zoomIn.TabIndex = 0;
            this.zoomIn.Text = "Zoom in";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(13, 46);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(98, 30);
            this.zoomOut.TabIndex = 1;
            this.zoomOut.Text = "Zoom out";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // btnReatract
            // 
            this.btnReatract.Location = new System.Drawing.Point(116, 12);
            this.btnReatract.Name = "btnReatract";
            this.btnReatract.Size = new System.Drawing.Size(98, 30);
            this.btnReatract.TabIndex = 7;
            this.btnReatract.Text = "Reatract";
            this.btnReatract.UseVisualStyleBackColor = true;
            this.btnReatract.Click += new System.EventHandler(this.btnReatract_Click);
            // 
            // btnNeutral
            // 
            this.btnNeutral.Location = new System.Drawing.Point(116, 46);
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(98, 30);
            this.btnNeutral.TabIndex = 8;
            this.btnNeutral.Text = "Neutral";
            this.btnNeutral.UseVisualStyleBackColor = true;
            this.btnNeutral.Click += new System.EventHandler(this.btnNeutral_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // joystickEnable
            // 
            this.joystickEnable.AutoSize = true;
            this.joystickEnable.Enabled = false;
            this.joystickEnable.Location = new System.Drawing.Point(13, 82);
            this.joystickEnable.Name = "joystickEnable";
            this.joystickEnable.Size = new System.Drawing.Size(91, 24);
            this.joystickEnable.TabIndex = 15;
            this.joystickEnable.Text = "Joystick";
            this.joystickEnable.UseVisualStyleBackColor = true;
            this.joystickEnable.CheckedChanged += new System.EventHandler(this.joystickEnable_CheckedChanged);
            // 
            // GimbalControlButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 397);
            this.Controls.Add(this.joystickEnable);
            this.Controls.Add(this.btnNeutral);
            this.Controls.Add(this.btnReatract);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.zoomIn);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "GimbalControlButtons";
            this.Text = " Gimbal control";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button btnReatract;
        private System.Windows.Forms.Button btnNeutral;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.CheckBox joystickEnable;
    }
}