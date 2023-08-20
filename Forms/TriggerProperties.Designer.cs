
namespace SavegameEditor.Forms
{
    partial class TriggerProperties
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
            this.grbxProperties = new System.Windows.Forms.GroupBox();
            this.nudTrigStateValue = new System.Windows.Forms.NumericUpDown();
            this.lblSavedValue = new System.Windows.Forms.Label();
            this.nudTrigSubtype = new System.Windows.Forms.NumericUpDown();
            this.lblTriggerSubtype = new System.Windows.Forms.Label();
            this.nudTrigType = new System.Windows.Forms.NumericUpDown();
            this.lblTriggerType = new System.Windows.Forms.Label();
            this.lblTrigX = new System.Windows.Forms.Label();
            this.nudTrigX = new System.Windows.Forms.NumericUpDown();
            this.nudTrigY = new System.Windows.Forms.NumericUpDown();
            this.lblTrigY = new System.Windows.Forms.Label();
            this.nudTrigZ = new System.Windows.Forms.NumericUpDown();
            this.lblTrigZ = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbxProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigStateValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigSubtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigZ)).BeginInit();
            this.SuspendLayout();
            // 
            // grbxProperties
            // 
            this.grbxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxProperties.Controls.Add(this.nudTrigStateValue);
            this.grbxProperties.Controls.Add(this.lblSavedValue);
            this.grbxProperties.Controls.Add(this.nudTrigSubtype);
            this.grbxProperties.Controls.Add(this.lblTriggerSubtype);
            this.grbxProperties.Controls.Add(this.nudTrigType);
            this.grbxProperties.Controls.Add(this.lblTriggerType);
            this.grbxProperties.Location = new System.Drawing.Point(12, 12);
            this.grbxProperties.Name = "grbxProperties";
            this.grbxProperties.Size = new System.Drawing.Size(381, 100);
            this.grbxProperties.TabIndex = 0;
            this.grbxProperties.TabStop = false;
            this.grbxProperties.Text = "Properties";
            // 
            // nudTrigStateValue
            // 
            this.nudTrigStateValue.Location = new System.Drawing.Point(111, 71);
            this.nudTrigStateValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudTrigStateValue.Name = "nudTrigStateValue";
            this.nudTrigStateValue.Size = new System.Drawing.Size(120, 20);
            this.nudTrigStateValue.TabIndex = 5;
            this.nudTrigStateValue.ValueChanged += new System.EventHandler(this.NudTrigStateValue_ValueChanged);
            // 
            // lblSavedValue
            // 
            this.lblSavedValue.AutoSize = true;
            this.lblSavedValue.Location = new System.Drawing.Point(6, 73);
            this.lblSavedValue.Name = "lblSavedValue";
            this.lblSavedValue.Size = new System.Drawing.Size(99, 13);
            this.lblSavedValue.TabIndex = 4;
            this.lblSavedValue.Text = "Saved State Value:";
            // 
            // nudTrigSubtype
            // 
            this.nudTrigSubtype.Location = new System.Drawing.Point(111, 45);
            this.nudTrigSubtype.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudTrigSubtype.Name = "nudTrigSubtype";
            this.nudTrigSubtype.Size = new System.Drawing.Size(120, 20);
            this.nudTrigSubtype.TabIndex = 3;
            this.nudTrigSubtype.ValueChanged += new System.EventHandler(this.NudTrigSubtype_ValueChanged);
            // 
            // lblTriggerSubtype
            // 
            this.lblTriggerSubtype.AutoSize = true;
            this.lblTriggerSubtype.Location = new System.Drawing.Point(20, 47);
            this.lblTriggerSubtype.Name = "lblTriggerSubtype";
            this.lblTriggerSubtype.Size = new System.Drawing.Size(85, 13);
            this.lblTriggerSubtype.TabIndex = 2;
            this.lblTriggerSubtype.Text = "Trigger Subtype:";
            // 
            // nudTrigType
            // 
            this.nudTrigType.Location = new System.Drawing.Point(111, 19);
            this.nudTrigType.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudTrigType.Name = "nudTrigType";
            this.nudTrigType.Size = new System.Drawing.Size(120, 20);
            this.nudTrigType.TabIndex = 1;
            this.nudTrigType.ValueChanged += new System.EventHandler(this.NudTrigType_ValueChanged);
            // 
            // lblTriggerType
            // 
            this.lblTriggerType.AutoSize = true;
            this.lblTriggerType.Location = new System.Drawing.Point(35, 21);
            this.lblTriggerType.Name = "lblTriggerType";
            this.lblTriggerType.Size = new System.Drawing.Size(70, 13);
            this.lblTriggerType.TabIndex = 0;
            this.lblTriggerType.Text = "Trigger Type:";
            // 
            // lblTrigX
            // 
            this.lblTrigX.AutoSize = true;
            this.lblTrigX.Location = new System.Drawing.Point(12, 120);
            this.lblTrigX.Name = "lblTrigX";
            this.lblTrigX.Size = new System.Drawing.Size(17, 13);
            this.lblTrigX.TabIndex = 1;
            this.lblTrigX.Text = "X:";
            // 
            // nudTrigX
            // 
            this.nudTrigX.DecimalPlaces = 4;
            this.nudTrigX.Location = new System.Drawing.Point(35, 118);
            this.nudTrigX.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudTrigX.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudTrigX.Name = "nudTrigX";
            this.nudTrigX.Size = new System.Drawing.Size(100, 20);
            this.nudTrigX.TabIndex = 6;
            this.nudTrigX.ValueChanged += new System.EventHandler(this.NudTrigX_ValueChanged);
            // 
            // nudTrigY
            // 
            this.nudTrigY.DecimalPlaces = 4;
            this.nudTrigY.Location = new System.Drawing.Point(164, 118);
            this.nudTrigY.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudTrigY.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudTrigY.Name = "nudTrigY";
            this.nudTrigY.Size = new System.Drawing.Size(100, 20);
            this.nudTrigY.TabIndex = 8;
            this.nudTrigY.ValueChanged += new System.EventHandler(this.NudTrigY_ValueChanged);
            // 
            // lblTrigY
            // 
            this.lblTrigY.AutoSize = true;
            this.lblTrigY.Location = new System.Drawing.Point(141, 120);
            this.lblTrigY.Name = "lblTrigY";
            this.lblTrigY.Size = new System.Drawing.Size(17, 13);
            this.lblTrigY.TabIndex = 7;
            this.lblTrigY.Text = "Y:";
            // 
            // nudTrigZ
            // 
            this.nudTrigZ.DecimalPlaces = 4;
            this.nudTrigZ.Location = new System.Drawing.Point(293, 118);
            this.nudTrigZ.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudTrigZ.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudTrigZ.Name = "nudTrigZ";
            this.nudTrigZ.Size = new System.Drawing.Size(100, 20);
            this.nudTrigZ.TabIndex = 10;
            this.nudTrigZ.ValueChanged += new System.EventHandler(this.NudTrigZ_ValueChanged);
            // 
            // lblTrigZ
            // 
            this.lblTrigZ.AutoSize = true;
            this.lblTrigZ.Location = new System.Drawing.Point(270, 120);
            this.lblTrigZ.Name = "lblTrigZ";
            this.lblTrigZ.Size = new System.Drawing.Size(17, 13);
            this.lblTrigZ.TabIndex = 9;
            this.lblTrigZ.Text = "Z:";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(237, 148);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TriggerProperties
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(405, 183);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudTrigZ);
            this.Controls.Add(this.lblTrigZ);
            this.Controls.Add(this.nudTrigY);
            this.Controls.Add(this.lblTrigY);
            this.Controls.Add(this.nudTrigX);
            this.Controls.Add(this.lblTrigX);
            this.Controls.Add(this.grbxProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriggerProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trigger Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TriggerProperties_FormClosing);
            this.Load += new System.EventHandler(this.TriggerProperties_Load);
            this.grbxProperties.ResumeLayout(false);
            this.grbxProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigStateValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigSubtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrigZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxProperties;
        private System.Windows.Forms.NumericUpDown nudTrigSubtype;
        private System.Windows.Forms.Label lblTriggerSubtype;
        private System.Windows.Forms.NumericUpDown nudTrigType;
        private System.Windows.Forms.Label lblTriggerType;
        private System.Windows.Forms.NumericUpDown nudTrigStateValue;
        private System.Windows.Forms.Label lblSavedValue;
        private System.Windows.Forms.Label lblTrigX;
        private System.Windows.Forms.NumericUpDown nudTrigX;
        private System.Windows.Forms.NumericUpDown nudTrigY;
        private System.Windows.Forms.Label lblTrigY;
        private System.Windows.Forms.NumericUpDown nudTrigZ;
        private System.Windows.Forms.Label lblTrigZ;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}