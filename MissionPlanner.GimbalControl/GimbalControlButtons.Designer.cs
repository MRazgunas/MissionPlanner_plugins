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
            this.trimUp = new System.Windows.Forms.Button();
            this.trimLeft = new System.Windows.Forms.Button();
            this.trimRight = new System.Windows.Forms.Button();
            this.trimDown = new System.Windows.Forms.Button();
            this.trimStep = new System.Windows.Forms.NumericUpDown();
            this.btnReatract = new System.Windows.Forms.Button();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.numLookAngle = new System.Windows.Forms.NumericUpDown();
            this.chkLookAhead = new System.Windows.Forms.CheckBox();
            this.gimbalSelector = new System.Windows.Forms.ComboBox();
            this.btnLoadSetting = new System.Windows.Forms.Button();
            this.manualControl = new System.Windows.Forms.CheckBox();
            this.manStepSize = new System.Windows.Forms.NumericUpDown();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.trimStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLookAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manStepSize)).BeginInit();
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
            // trimUp
            // 
            this.trimUp.Location = new System.Drawing.Point(98, 107);
            this.trimUp.Name = "trimUp";
            this.trimUp.Size = new System.Drawing.Size(98, 30);
            this.trimUp.TabIndex = 2;
            this.trimUp.Text = "Trim up";
            this.trimUp.UseVisualStyleBackColor = true;
            this.trimUp.Click += new System.EventHandler(this.trimUp_Click);
            // 
            // trimLeft
            // 
            this.trimLeft.Location = new System.Drawing.Point(12, 141);
            this.trimLeft.Name = "trimLeft";
            this.trimLeft.Size = new System.Drawing.Size(98, 30);
            this.trimLeft.TabIndex = 3;
            this.trimLeft.Text = "Trim left";
            this.trimLeft.UseVisualStyleBackColor = true;
            this.trimLeft.Click += new System.EventHandler(this.trimLeft_Click);
            // 
            // trimRight
            // 
            this.trimRight.Location = new System.Drawing.Point(185, 141);
            this.trimRight.Name = "trimRight";
            this.trimRight.Size = new System.Drawing.Size(98, 30);
            this.trimRight.TabIndex = 4;
            this.trimRight.Text = "Trim right";
            this.trimRight.UseVisualStyleBackColor = true;
            this.trimRight.Click += new System.EventHandler(this.trimRight_Click);
            // 
            // trimDown
            // 
            this.trimDown.Location = new System.Drawing.Point(98, 175);
            this.trimDown.Name = "trimDown";
            this.trimDown.Size = new System.Drawing.Size(98, 30);
            this.trimDown.TabIndex = 5;
            this.trimDown.Text = "Trim down";
            this.trimDown.UseVisualStyleBackColor = true;
            this.trimDown.Click += new System.EventHandler(this.trimDown_Click);
            // 
            // trimStep
            // 
            this.trimStep.DecimalPlaces = 1;
            this.trimStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trimStep.InterceptArrowKeys = false;
            this.trimStep.Location = new System.Drawing.Point(116, 143);
            this.trimStep.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.trimStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trimStep.Name = "trimStep";
            this.trimStep.Size = new System.Drawing.Size(63, 26);
            this.trimStep.TabIndex = 6;
            this.trimStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // numLookAngle
            // 
            this.numLookAngle.DecimalPlaces = 1;
            this.numLookAngle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLookAngle.InterceptArrowKeys = false;
            this.numLookAngle.Location = new System.Drawing.Point(12, 223);
            this.numLookAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numLookAngle.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numLookAngle.Name = "numLookAngle";
            this.numLookAngle.Size = new System.Drawing.Size(79, 26);
            this.numLookAngle.TabIndex = 9;
            this.numLookAngle.ValueChanged += new System.EventHandler(this.numLookAngle_ValueChanged);
            // 
            // chkLookAhead
            // 
            this.chkLookAhead.AutoSize = true;
            this.chkLookAhead.Location = new System.Drawing.Point(97, 224);
            this.chkLookAhead.Name = "chkLookAhead";
            this.chkLookAhead.Size = new System.Drawing.Size(119, 24);
            this.chkLookAhead.TabIndex = 10;
            this.chkLookAhead.Text = "Look ahead";
            this.chkLookAhead.UseVisualStyleBackColor = true;
            this.chkLookAhead.CheckedChanged += new System.EventHandler(this.chkLookAhead_CheckedChanged);
            // 
            // gimbalSelector
            // 
            this.gimbalSelector.FormattingEnabled = true;
            this.gimbalSelector.Items.AddRange(new object[] {
            "RGB",
            "LWIR"});
            this.gimbalSelector.Location = new System.Drawing.Point(12, 299);
            this.gimbalSelector.Name = "gimbalSelector";
            this.gimbalSelector.Size = new System.Drawing.Size(121, 28);
            this.gimbalSelector.TabIndex = 11;
            // 
            // btnLoadSetting
            // 
            this.btnLoadSetting.Location = new System.Drawing.Point(139, 297);
            this.btnLoadSetting.Name = "btnLoadSetting";
            this.btnLoadSetting.Size = new System.Drawing.Size(118, 30);
            this.btnLoadSetting.TabIndex = 12;
            this.btnLoadSetting.Text = "Load settings";
            this.btnLoadSetting.UseVisualStyleBackColor = true;
            this.btnLoadSetting.Click += new System.EventHandler(this.btnLoadSetting_Click);
            // 
            // manualControl
            // 
            this.manualControl.AutoSize = true;
            this.manualControl.Location = new System.Drawing.Point(98, 257);
            this.manualControl.Name = "manualControl";
            this.manualControl.Size = new System.Drawing.Size(139, 24);
            this.manualControl.TabIndex = 13;
            this.manualControl.Text = "Manual control";
            this.manualControl.UseVisualStyleBackColor = true;
            this.manualControl.CheckedChanged += new System.EventHandler(this.manualControl_CheckedChanged);
            // 
            // manStepSize
            // 
            this.manStepSize.DecimalPlaces = 1;
            this.manStepSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.manStepSize.InterceptArrowKeys = false;
            this.manStepSize.Location = new System.Drawing.Point(12, 255);
            this.manStepSize.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.manStepSize.Name = "manStepSize";
            this.manStepSize.Size = new System.Drawing.Size(79, 26);
            this.manStepSize.TabIndex = 14;
            this.manStepSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // GimbalControlButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 348);
            this.Controls.Add(this.manStepSize);
            this.Controls.Add(this.manualControl);
            this.Controls.Add(this.btnLoadSetting);
            this.Controls.Add(this.gimbalSelector);
            this.Controls.Add(this.chkLookAhead);
            this.Controls.Add(this.numLookAngle);
            this.Controls.Add(this.btnNeutral);
            this.Controls.Add(this.btnReatract);
            this.Controls.Add(this.trimStep);
            this.Controls.Add(this.trimDown);
            this.Controls.Add(this.trimRight);
            this.Controls.Add(this.trimLeft);
            this.Controls.Add(this.trimUp);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.zoomIn);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "GimbalControlButtons";
            this.Text = " Gimbal control";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trimStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLookAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manStepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button trimUp;
        private System.Windows.Forms.Button trimLeft;
        private System.Windows.Forms.Button trimRight;
        private System.Windows.Forms.Button trimDown;
        private System.Windows.Forms.NumericUpDown trimStep;
        private System.Windows.Forms.Button btnReatract;
        private System.Windows.Forms.Button btnNeutral;
        private System.Windows.Forms.NumericUpDown numLookAngle;
        private System.Windows.Forms.CheckBox chkLookAhead;
        private System.Windows.Forms.ComboBox gimbalSelector;
        private System.Windows.Forms.Button btnLoadSetting;
        private System.Windows.Forms.CheckBox manualControl;
        private System.Windows.Forms.NumericUpDown manStepSize;
        private System.Diagnostics.EventLog eventLog1;
    }
}