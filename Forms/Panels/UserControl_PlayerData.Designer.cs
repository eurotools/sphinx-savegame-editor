
namespace SavegameEditor.Forms.Panels
{
    partial class UserControl_PlayerData
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvwTripMummyRot = new SavegameEditor.ListView_ColumnSortingClick();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvwTripMummyPos = new SavegameEditor.ListView_ColumnSortingClick();
            this.ColMumPosX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMumPosY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMumPosZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMumPosW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkMummyCopy2 = new System.Windows.Forms.CheckBox();
            this.chkMummyCopy1 = new System.Windows.Forms.CheckBox();
            this.grbxPlayerIndex = new System.Windows.Forms.GroupBox();
            this.cbxPlayerCharacter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbxPlayerIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(3, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(859, 555);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Triple Mummy Copies";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lvwTripMummyRot);
            this.groupBox6.Location = new System.Drawing.Point(6, 247);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(847, 302);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rotation";
            // 
            // lvwTripMummyRot
            // 
            this.lvwTripMummyRot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwTripMummyRot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTripMummyRot.FullRowSelect = true;
            this.lvwTripMummyRot.HideSelection = false;
            this.lvwTripMummyRot.Location = new System.Drawing.Point(3, 16);
            this.lvwTripMummyRot.Name = "lvwTripMummyRot";
            this.lvwTripMummyRot.Size = new System.Drawing.Size(841, 283);
            this.lvwTripMummyRot.TabIndex = 0;
            this.lvwTripMummyRot.UseCompatibleStateImageBehavior = false;
            this.lvwTripMummyRot.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "X";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Y";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Z";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "W";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lvwTripMummyPos);
            this.groupBox5.Location = new System.Drawing.Point(6, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(847, 173);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Position";
            // 
            // lvwTripMummyPos
            // 
            this.lvwTripMummyPos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColMumPosX,
            this.ColMumPosY,
            this.ColMumPosZ,
            this.ColMumPosW});
            this.lvwTripMummyPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTripMummyPos.FullRowSelect = true;
            this.lvwTripMummyPos.HideSelection = false;
            this.lvwTripMummyPos.Location = new System.Drawing.Point(3, 16);
            this.lvwTripMummyPos.Name = "lvwTripMummyPos";
            this.lvwTripMummyPos.Size = new System.Drawing.Size(841, 154);
            this.lvwTripMummyPos.TabIndex = 0;
            this.lvwTripMummyPos.UseCompatibleStateImageBehavior = false;
            this.lvwTripMummyPos.View = System.Windows.Forms.View.Details;
            // 
            // ColMumPosX
            // 
            this.ColMumPosX.Text = "X";
            // 
            // ColMumPosY
            // 
            this.ColMumPosY.Text = "Y";
            // 
            // ColMumPosZ
            // 
            this.ColMumPosZ.Text = "Z";
            // 
            // ColMumPosW
            // 
            this.ColMumPosW.Text = "W";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkMummyCopy2);
            this.groupBox4.Controls.Add(this.chkMummyCopy1);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 43);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Copies?";
            // 
            // chkMummyCopy2
            // 
            this.chkMummyCopy2.AutoSize = true;
            this.chkMummyCopy2.Location = new System.Drawing.Point(71, 19);
            this.chkMummyCopy2.Name = "chkMummyCopy2";
            this.chkMummyCopy2.Size = new System.Drawing.Size(59, 17);
            this.chkMummyCopy2.TabIndex = 1;
            this.chkMummyCopy2.Text = "Copy 2";
            this.chkMummyCopy2.UseVisualStyleBackColor = true;
            // 
            // chkMummyCopy1
            // 
            this.chkMummyCopy1.AutoSize = true;
            this.chkMummyCopy1.Location = new System.Drawing.Point(6, 19);
            this.chkMummyCopy1.Name = "chkMummyCopy1";
            this.chkMummyCopy1.Size = new System.Drawing.Size(59, 17);
            this.chkMummyCopy1.TabIndex = 0;
            this.chkMummyCopy1.Text = "Copy 1";
            this.chkMummyCopy1.UseVisualStyleBackColor = true;
            // 
            // grbxPlayerIndex
            // 
            this.grbxPlayerIndex.Controls.Add(this.cbxPlayerCharacter);
            this.grbxPlayerIndex.Controls.Add(this.label1);
            this.grbxPlayerIndex.Location = new System.Drawing.Point(3, 3);
            this.grbxPlayerIndex.Name = "grbxPlayerIndex";
            this.grbxPlayerIndex.Size = new System.Drawing.Size(859, 55);
            this.grbxPlayerIndex.TabIndex = 2;
            this.grbxPlayerIndex.TabStop = false;
            this.grbxPlayerIndex.Text = "Properties";
            // 
            // cbxPlayerCharacter
            // 
            this.cbxPlayerCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlayerCharacter.FormattingEnabled = true;
            this.cbxPlayerCharacter.Items.AddRange(new object[] {
            "Sphinx",
            "Mummy",
            "Tut"});
            this.cbxPlayerCharacter.Location = new System.Drawing.Point(100, 19);
            this.cbxPlayerCharacter.Name = "cbxPlayerCharacter";
            this.cbxPlayerCharacter.Size = new System.Drawing.Size(159, 21);
            this.cbxPlayerCharacter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Character:";
            // 
            // UserControl_PlayerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbxPlayerIndex);
            this.Name = "UserControl_PlayerData";
            this.Size = new System.Drawing.Size(865, 622);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbxPlayerIndex.ResumeLayout(false);
            this.grbxPlayerIndex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private ListView_ColumnSortingClick lvwTripMummyRot;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox5;
        private ListView_ColumnSortingClick lvwTripMummyPos;
        private System.Windows.Forms.ColumnHeader ColMumPosX;
        private System.Windows.Forms.ColumnHeader ColMumPosY;
        private System.Windows.Forms.ColumnHeader ColMumPosZ;
        private System.Windows.Forms.ColumnHeader ColMumPosW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkMummyCopy2;
        private System.Windows.Forms.CheckBox chkMummyCopy1;
        private System.Windows.Forms.GroupBox grbxPlayerIndex;
        private System.Windows.Forms.ComboBox cbxPlayerCharacter;
        private System.Windows.Forms.Label label1;
    }
}
