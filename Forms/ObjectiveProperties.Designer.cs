
namespace SavegameEditor
{
    partial class ObjectiveProperties
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
            this.txtObjective = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbxHashCode = new System.Windows.Forms.ComboBox();
            this.nudObjectiveValue = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectiveValue)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObjective
            // 
            this.txtObjective.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObjective.Location = new System.Drawing.Point(12, 12);
            this.txtObjective.Name = "txtObjective";
            this.txtObjective.Size = new System.Drawing.Size(387, 20);
            this.txtObjective.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.cbxHashCode);
            this.groupBox1.Controls.Add(this.nudObjectiveValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "HashCode:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Value:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cbxHashCode
            // 
            this.cbxHashCode.DisplayMember = "Value";
            this.cbxHashCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHashCode.FormattingEnabled = true;
            this.cbxHashCode.Location = new System.Drawing.Point(90, 45);
            this.cbxHashCode.Name = "cbxHashCode";
            this.cbxHashCode.Size = new System.Drawing.Size(217, 21);
            this.cbxHashCode.TabIndex = 0;
            this.cbxHashCode.ValueMember = "Key";
            this.cbxHashCode.SelectedIndexChanged += new System.EventHandler(this.CbxHashCode_SelectedIndexChanged);
            // 
            // nudObjectiveValue
            // 
            this.nudObjectiveValue.Location = new System.Drawing.Point(90, 19);
            this.nudObjectiveValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudObjectiveValue.Name = "nudObjectiveValue";
            this.nudObjectiveValue.Size = new System.Drawing.Size(120, 20);
            this.nudObjectiveValue.TabIndex = 0;
            this.nudObjectiveValue.ValueChanged += new System.EventHandler(this.NudObjectiveValue_ValueChanged);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(324, 126);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 9;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Ok
            // 
            this.Button_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Ok.Location = new System.Drawing.Point(243, 126);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 8;
            this.Button_Ok.Text = "OK";
            this.Button_Ok.UseVisualStyleBackColor = true;
            // 
            // ObjectiveProperties
            // 
            this.AcceptButton = this.Button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(411, 161);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtObjective);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectiveProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Objective Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectiveProperties_FormClosing);
            this.Load += new System.EventHandler(this.ObjectiveProperties_Load);
            this.Shown += new System.EventHandler(this.ObjectiveProperties_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectiveValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObjective;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxHashCode;
        private System.Windows.Forms.NumericUpDown nudObjectiveValue;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}