namespace MissionPlanner.Plugins.GimbalTest
{
    partial class GimbalTestForm
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
            this.pitchNumeric = new System.Windows.Forms.NumericUpDown();
            this.yawNumeric = new System.Windows.Forms.NumericUpDown();
            this.btnSendAngles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pitchNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // pitchNumeric
            // 
            this.pitchNumeric.DecimalPlaces = 1;
            this.pitchNumeric.Location = new System.Drawing.Point(97, 38);
            this.pitchNumeric.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.pitchNumeric.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.pitchNumeric.Name = "pitchNumeric";
            this.pitchNumeric.Size = new System.Drawing.Size(120, 26);
            this.pitchNumeric.TabIndex = 0;
            // 
            // yawNumeric
            // 
            this.yawNumeric.DecimalPlaces = 1;
            this.yawNumeric.Location = new System.Drawing.Point(97, 70);
            this.yawNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.yawNumeric.Name = "yawNumeric";
            this.yawNumeric.Size = new System.Drawing.Size(120, 26);
            this.yawNumeric.TabIndex = 1;
            // 
            // btnSendAngles
            // 
            this.btnSendAngles.Location = new System.Drawing.Point(97, 102);
            this.btnSendAngles.Name = "btnSendAngles";
            this.btnSendAngles.Size = new System.Drawing.Size(120, 37);
            this.btnSendAngles.TabIndex = 2;
            this.btnSendAngles.Text = "sendAngles";
            this.btnSendAngles.UseVisualStyleBackColor = true;
            this.btnSendAngles.Click += new System.EventHandler(this.btnSendAngles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pitch: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yaw: ";
            // 
            // GimbalTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendAngles);
            this.Controls.Add(this.yawNumeric);
            this.Controls.Add(this.pitchNumeric);
            this.Name = "GimbalTestForm";
            this.Text = "GimbalTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.pitchNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pitchNumeric;
        private System.Windows.Forms.NumericUpDown yawNumeric;
        private System.Windows.Forms.Button btnSendAngles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}