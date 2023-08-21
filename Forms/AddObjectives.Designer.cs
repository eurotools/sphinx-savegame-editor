
namespace SavegameEditor
{
    partial class AddObjectives
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
            this.grbx_AvailableObjectives = new System.Windows.Forms.GroupBox();
            this.lstbxAvailableObjectives = new System.Windows.Forms.ListBox();
            this.grbxObjectivesToAdd = new System.Windows.Forms.GroupBox();
            this.lstbxObjectivesToAdd = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddObjective = new System.Windows.Forms.Button();
            this.btnRemoveObjective = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudObjectiveValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_AvailableObjectives.SuspendLayout();
            this.grbxObjectivesToAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectiveValue)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_AvailableObjectives
            // 
            this.grbx_AvailableObjectives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbx_AvailableObjectives.Controls.Add(this.lstbxAvailableObjectives);
            this.grbx_AvailableObjectives.Location = new System.Drawing.Point(12, 41);
            this.grbx_AvailableObjectives.Name = "grbx_AvailableObjectives";
            this.grbx_AvailableObjectives.Size = new System.Drawing.Size(296, 495);
            this.grbx_AvailableObjectives.TabIndex = 0;
            this.grbx_AvailableObjectives.TabStop = false;
            this.grbx_AvailableObjectives.Text = "Available Objectives";
            // 
            // lstbxAvailableObjectives
            // 
            this.lstbxAvailableObjectives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxAvailableObjectives.FormattingEnabled = true;
            this.lstbxAvailableObjectives.Location = new System.Drawing.Point(3, 16);
            this.lstbxAvailableObjectives.Name = "lstbxAvailableObjectives";
            this.lstbxAvailableObjectives.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxAvailableObjectives.Size = new System.Drawing.Size(290, 476);
            this.lstbxAvailableObjectives.Sorted = true;
            this.lstbxAvailableObjectives.TabIndex = 0;
            // 
            // grbxObjectivesToAdd
            // 
            this.grbxObjectivesToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxObjectivesToAdd.Controls.Add(this.lstbxObjectivesToAdd);
            this.grbxObjectivesToAdd.Location = new System.Drawing.Point(314, 41);
            this.grbxObjectivesToAdd.Name = "grbxObjectivesToAdd";
            this.grbxObjectivesToAdd.Size = new System.Drawing.Size(309, 409);
            this.grbxObjectivesToAdd.TabIndex = 1;
            this.grbxObjectivesToAdd.TabStop = false;
            this.grbxObjectivesToAdd.Text = "Objectives To Add";
            // 
            // lstbxObjectivesToAdd
            // 
            this.lstbxObjectivesToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxObjectivesToAdd.FormattingEnabled = true;
            this.lstbxObjectivesToAdd.Location = new System.Drawing.Point(3, 16);
            this.lstbxObjectivesToAdd.Name = "lstbxObjectivesToAdd";
            this.lstbxObjectivesToAdd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxObjectivesToAdd.Size = new System.Drawing.Size(303, 390);
            this.lstbxObjectivesToAdd.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(467, 513);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(548, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddObjective
            // 
            this.btnAddObjective.Location = new System.Drawing.Point(12, 12);
            this.btnAddObjective.Name = "btnAddObjective";
            this.btnAddObjective.Size = new System.Drawing.Size(296, 23);
            this.btnAddObjective.TabIndex = 0;
            this.btnAddObjective.Text = "Add Objectives >>>";
            this.btnAddObjective.UseVisualStyleBackColor = true;
            this.btnAddObjective.Click += new System.EventHandler(this.BtnAddObjective_Click);
            // 
            // btnRemoveObjective
            // 
            this.btnRemoveObjective.Location = new System.Drawing.Point(314, 12);
            this.btnRemoveObjective.Name = "btnRemoveObjective";
            this.btnRemoveObjective.Size = new System.Drawing.Size(309, 23);
            this.btnRemoveObjective.TabIndex = 0;
            this.btnRemoveObjective.Text = "<<< Remove Objectives";
            this.btnRemoveObjective.UseVisualStyleBackColor = true;
            this.btnRemoveObjective.Click += new System.EventHandler(this.BtnRemoveObjective_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudObjectiveValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(314, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // nudObjectiveValue
            // 
            this.nudObjectiveValue.Location = new System.Drawing.Point(49, 19);
            this.nudObjectiveValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudObjectiveValue.Name = "nudObjectiveValue";
            this.nudObjectiveValue.Size = new System.Drawing.Size(120, 20);
            this.nudObjectiveValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value:";
            // 
            // AddObjectives
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(635, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveObjective);
            this.Controls.Add(this.btnAddObjective);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grbxObjectivesToAdd);
            this.Controls.Add(this.grbx_AvailableObjectives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddObjectives";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Objectives";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddObjectives_FormClosing);
            this.Load += new System.EventHandler(this.AddObjectives_Load);
            this.grbx_AvailableObjectives.ResumeLayout(false);
            this.grbxObjectivesToAdd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectiveValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_AvailableObjectives;
        private System.Windows.Forms.GroupBox grbxObjectivesToAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstbxAvailableObjectives;
        private System.Windows.Forms.ListBox lstbxObjectivesToAdd;
        private System.Windows.Forms.Button btnAddObjective;
        private System.Windows.Forms.Button btnRemoveObjective;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudObjectiveValue;
        private System.Windows.Forms.Label label1;
    }
}