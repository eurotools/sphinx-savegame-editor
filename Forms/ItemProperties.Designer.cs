
namespace SavegameEditor
{
    partial class ItemProperties
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
            this.txtHashCodeLabel = new System.Windows.Forms.TextBox();
            this.CheckListbox_Flags = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMaxAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCurrentAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHashCodeLabel
            // 
            this.txtHashCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHashCodeLabel.Location = new System.Drawing.Point(12, 12);
            this.txtHashCodeLabel.Name = "txtHashCodeLabel";
            this.txtHashCodeLabel.Size = new System.Drawing.Size(227, 20);
            this.txtHashCodeLabel.TabIndex = 0;
            // 
            // CheckListbox_Flags
            // 
            this.CheckListbox_Flags.CheckOnClick = true;
            this.CheckListbox_Flags.FormattingEnabled = true;
            this.CheckListbox_Flags.Items.AddRange(new object[] {
            "Ability",
            "PassiveAbility",
            "UseInFirstPerson",
            "UseInThirdPerson",
            "QuestItem",
            "PresentItem",
            "BeetleItem",
            "DartItem",
            "KeyItem",
            "UseUnderWater",
            "UseOutOfWater",
            "ProgrammableItem",
            "UniqueItem",
            "MiniGameItem",
            "SpecialItem",
            "ReleaseMonster",
            "Ka Item",
            "Possession Item",
            "RemoveWhenZero",
            "InfiniteAmount",
            "DontShowMaxAmount",
            "DontShowInBOS",
            "Flag # 23 Unused",
            "Flag # 24 Unused",
            "Flag # 25 Unused",
            "CatagoryFlag01  (1)",
            "CatagoryFlag02  (2)",
            "CatagoryFlag03  (4)",
            "CatagoryFlag04  (8)",
            "CatagoryFlag05  (16)",
            "CatagoryFlag06  (32)",
            "CatagoryFlag07  (64)"});
            this.CheckListbox_Flags.Location = new System.Drawing.Point(6, 19);
            this.CheckListbox_Flags.MultiColumn = true;
            this.CheckListbox_Flags.Name = "CheckListbox_Flags";
            this.CheckListbox_Flags.Size = new System.Drawing.Size(257, 244);
            this.CheckListbox_Flags.TabIndex = 2;
            this.CheckListbox_Flags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckListbox_Flags_ItemCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMaxAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudCurrentAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // nudMaxAmount
            // 
            this.nudMaxAmount.Location = new System.Drawing.Point(95, 49);
            this.nudMaxAmount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMaxAmount.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nudMaxAmount.Name = "nudMaxAmount";
            this.nudMaxAmount.Size = new System.Drawing.Size(116, 20);
            this.nudMaxAmount.TabIndex = 3;
            this.nudMaxAmount.ValueChanged += new System.EventHandler(this.NudMaxAmount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Amount:";
            // 
            // nudCurrentAmount
            // 
            this.nudCurrentAmount.Location = new System.Drawing.Point(95, 23);
            this.nudCurrentAmount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudCurrentAmount.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nudCurrentAmount.Name = "nudCurrentAmount";
            this.nudCurrentAmount.Size = new System.Drawing.Size(116, 20);
            this.nudCurrentAmount.TabIndex = 1;
            this.nudCurrentAmount.ValueChanged += new System.EventHandler(this.NudCurrentAmount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Amount:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckListbox_Flags);
            this.groupBox2.Location = new System.Drawing.Point(245, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 273);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flags";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 263);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(93, 263);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ItemProperties
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(529, 298);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHashCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemProperties_FormClosing);
            this.Load += new System.EventHandler(this.ItemProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHashCodeLabel;
        private System.Windows.Forms.CheckedListBox CheckListbox_Flags;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMaxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCurrentAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}