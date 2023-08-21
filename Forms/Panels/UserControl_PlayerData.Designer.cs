
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbxMumAbility = new System.Windows.Forms.GroupBox();
            this.chkMum3Ability = new System.Windows.Forms.CheckBox();
            this.chkMum2Ability = new System.Windows.Forms.CheckBox();
            this.chkMum1Ability = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudMummy3_MaxTime = new System.Windows.Forms.NumericUpDown();
            this.lblTimeMax_Mum3 = new System.Windows.Forms.Label();
            this.nudMummy2_MaxTime = new System.Windows.Forms.NumericUpDown();
            this.lblTimeMax_Mum2 = new System.Windows.Forms.Label();
            this.nudMummy1_MaxTime = new System.Windows.Forms.NumericUpDown();
            this.lblTimeMax_Mum1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMummy3_CurrTime = new System.Windows.Forms.NumericUpDown();
            this.lblTimeCurrent_Mum3 = new System.Windows.Forms.Label();
            this.nudMummy2_CurrTime = new System.Windows.Forms.NumericUpDown();
            this.lblTimeCurrent_Mum2 = new System.Windows.Forms.Label();
            this.nudMummy1_CurrTime = new System.Windows.Forms.NumericUpDown();
            this.lblTimeCurrent_Mum1 = new System.Windows.Forms.Label();
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
            this.ContextMenu_Position = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Pos_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Pos_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Pos_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkMummyCopy2 = new System.Windows.Forms.CheckBox();
            this.chkMummyCopy1 = new System.Windows.Forms.CheckBox();
            this.grbxPlayerIndex = new System.Windows.Forms.GroupBox();
            this.cbxPlayerCharacter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContextMenu_Rotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Rot_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Rot_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Rot_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.grbxMumAbility.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy3_MaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy2_MaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy1_MaxTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy3_CurrTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy2_CurrTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy1_CurrTime)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ContextMenu_Position.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbxPlayerIndex.SuspendLayout();
            this.ContextMenu_Rotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grbxMumAbility);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(3, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(895, 446);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Triple Mummy Copies";
            // 
            // grbxMumAbility
            // 
            this.grbxMumAbility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxMumAbility.Controls.Add(this.chkMum3Ability);
            this.grbxMumAbility.Controls.Add(this.chkMum2Ability);
            this.grbxMumAbility.Controls.Add(this.chkMum1Ability);
            this.grbxMumAbility.Controls.Add(this.groupBox7);
            this.grbxMumAbility.Controls.Add(this.groupBox2);
            this.grbxMumAbility.Location = new System.Drawing.Point(6, 276);
            this.grbxMumAbility.Name = "grbxMumAbility";
            this.grbxMumAbility.Size = new System.Drawing.Size(883, 164);
            this.grbxMumAbility.TabIndex = 3;
            this.grbxMumAbility.TabStop = false;
            this.grbxMumAbility.Text = "Mummy Ability";
            // 
            // chkMum3Ability
            // 
            this.chkMum3Ability.AutoSize = true;
            this.chkMum3Ability.Location = new System.Drawing.Point(160, 19);
            this.chkMum3Ability.Name = "chkMum3Ability";
            this.chkMum3Ability.Size = new System.Drawing.Size(71, 17);
            this.chkMum3Ability.TabIndex = 4;
            this.chkMum3Ability.Text = "Mummy 3";
            this.chkMum3Ability.UseVisualStyleBackColor = true;
            this.chkMum3Ability.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChkMum3Ability_MouseClick);
            // 
            // chkMum2Ability
            // 
            this.chkMum2Ability.AutoSize = true;
            this.chkMum2Ability.Location = new System.Drawing.Point(83, 19);
            this.chkMum2Ability.Name = "chkMum2Ability";
            this.chkMum2Ability.Size = new System.Drawing.Size(71, 17);
            this.chkMum2Ability.TabIndex = 3;
            this.chkMum2Ability.Text = "Mummy 2";
            this.chkMum2Ability.UseVisualStyleBackColor = true;
            this.chkMum2Ability.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChkMum2Ability_MouseClick);
            // 
            // chkMum1Ability
            // 
            this.chkMum1Ability.AutoSize = true;
            this.chkMum1Ability.Location = new System.Drawing.Point(6, 19);
            this.chkMum1Ability.Name = "chkMum1Ability";
            this.chkMum1Ability.Size = new System.Drawing.Size(71, 17);
            this.chkMum1Ability.TabIndex = 2;
            this.chkMum1Ability.Text = "Mummy 1";
            this.chkMum1Ability.UseVisualStyleBackColor = true;
            this.chkMum1Ability.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChkMum1Ability_MouseClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.nudMummy3_MaxTime);
            this.groupBox7.Controls.Add(this.lblTimeMax_Mum3);
            this.groupBox7.Controls.Add(this.nudMummy2_MaxTime);
            this.groupBox7.Controls.Add(this.lblTimeMax_Mum2);
            this.groupBox7.Controls.Add(this.nudMummy1_MaxTime);
            this.groupBox7.Controls.Add(this.lblTimeMax_Mum1);
            this.groupBox7.Location = new System.Drawing.Point(3, 95);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(871, 49);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Time Maximum";
            // 
            // nudMummy3_MaxTime
            // 
            this.nudMummy3_MaxTime.Location = new System.Drawing.Point(444, 19);
            this.nudMummy3_MaxTime.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudMummy3_MaxTime.Name = "nudMummy3_MaxTime";
            this.nudMummy3_MaxTime.Size = new System.Drawing.Size(120, 20);
            this.nudMummy3_MaxTime.TabIndex = 11;
            this.nudMummy3_MaxTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudMummy3_MaxTime_MouseClick);
            // 
            // lblTimeMax_Mum3
            // 
            this.lblTimeMax_Mum3.AutoSize = true;
            this.lblTimeMax_Mum3.Location = new System.Drawing.Point(383, 21);
            this.lblTimeMax_Mum3.Name = "lblTimeMax_Mum3";
            this.lblTimeMax_Mum3.Size = new System.Drawing.Size(55, 13);
            this.lblTimeMax_Mum3.TabIndex = 10;
            this.lblTimeMax_Mum3.Text = "Mummy 3:";
            // 
            // nudMummy2_MaxTime
            // 
            this.nudMummy2_MaxTime.Location = new System.Drawing.Point(257, 19);
            this.nudMummy2_MaxTime.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudMummy2_MaxTime.Name = "nudMummy2_MaxTime";
            this.nudMummy2_MaxTime.Size = new System.Drawing.Size(120, 20);
            this.nudMummy2_MaxTime.TabIndex = 9;
            this.nudMummy2_MaxTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudMummy2_MaxTime_MouseClick);
            // 
            // lblTimeMax_Mum2
            // 
            this.lblTimeMax_Mum2.AutoSize = true;
            this.lblTimeMax_Mum2.Location = new System.Drawing.Point(196, 21);
            this.lblTimeMax_Mum2.Name = "lblTimeMax_Mum2";
            this.lblTimeMax_Mum2.Size = new System.Drawing.Size(55, 13);
            this.lblTimeMax_Mum2.TabIndex = 8;
            this.lblTimeMax_Mum2.Text = "Mummy 2:";
            // 
            // nudMummy1_MaxTime
            // 
            this.nudMummy1_MaxTime.Location = new System.Drawing.Point(70, 19);
            this.nudMummy1_MaxTime.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudMummy1_MaxTime.Name = "nudMummy1_MaxTime";
            this.nudMummy1_MaxTime.Size = new System.Drawing.Size(120, 20);
            this.nudMummy1_MaxTime.TabIndex = 7;
            this.nudMummy1_MaxTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudMummy1_MaxTime_MouseClick);
            // 
            // lblTimeMax_Mum1
            // 
            this.lblTimeMax_Mum1.AutoSize = true;
            this.lblTimeMax_Mum1.Location = new System.Drawing.Point(9, 21);
            this.lblTimeMax_Mum1.Name = "lblTimeMax_Mum1";
            this.lblTimeMax_Mum1.Size = new System.Drawing.Size(55, 13);
            this.lblTimeMax_Mum1.TabIndex = 6;
            this.lblTimeMax_Mum1.Text = "Mummy 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.nudMummy3_CurrTime);
            this.groupBox2.Controls.Add(this.lblTimeCurrent_Mum3);
            this.groupBox2.Controls.Add(this.nudMummy2_CurrTime);
            this.groupBox2.Controls.Add(this.lblTimeCurrent_Mum2);
            this.groupBox2.Controls.Add(this.nudMummy1_CurrTime);
            this.groupBox2.Controls.Add(this.lblTimeCurrent_Mum1);
            this.groupBox2.Location = new System.Drawing.Point(6, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 47);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Current";
            // 
            // nudMummy3_CurrTime
            // 
            this.nudMummy3_CurrTime.Location = new System.Drawing.Point(441, 19);
            this.nudMummy3_CurrTime.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudMummy3_CurrTime.Name = "nudMummy3_CurrTime";
            this.nudMummy3_CurrTime.Size = new System.Drawing.Size(120, 20);
            this.nudMummy3_CurrTime.TabIndex = 5;
            this.nudMummy3_CurrTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudMummy3_CurrTime_MouseClick);
            // 
            // lblTimeCurrent_Mum3
            // 
            this.lblTimeCurrent_Mum3.AutoSize = true;
            this.lblTimeCurrent_Mum3.Location = new System.Drawing.Point(380, 21);
            this.lblTimeCurrent_Mum3.Name = "lblTimeCurrent_Mum3";
            this.lblTimeCurrent_Mum3.Size = new System.Drawing.Size(55, 13);
            this.lblTimeCurrent_Mum3.TabIndex = 4;
            this.lblTimeCurrent_Mum3.Text = "Mummy 3:";
            // 
            // nudMummy2_CurrTime
            // 
            this.nudMummy2_CurrTime.Location = new System.Drawing.Point(254, 19);
            this.nudMummy2_CurrTime.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudMummy2_CurrTime.Name = "nudMummy2_CurrTime";
            this.nudMummy2_CurrTime.Size = new System.Drawing.Size(120, 20);
            this.nudMummy2_CurrTime.TabIndex = 3;
            this.nudMummy2_CurrTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudMummy2_CurrTime_MouseClick);
            // 
            // lblTimeCurrent_Mum2
            // 
            this.lblTimeCurrent_Mum2.AutoSize = true;
            this.lblTimeCurrent_Mum2.Location = new System.Drawing.Point(193, 21);
            this.lblTimeCurrent_Mum2.Name = "lblTimeCurrent_Mum2";
            this.lblTimeCurrent_Mum2.Size = new System.Drawing.Size(55, 13);
            this.lblTimeCurrent_Mum2.TabIndex = 2;
            this.lblTimeCurrent_Mum2.Text = "Mummy 2:";
            // 
            // nudMummy1_CurrTime
            // 
            this.nudMummy1_CurrTime.Location = new System.Drawing.Point(67, 19);
            this.nudMummy1_CurrTime.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudMummy1_CurrTime.Name = "nudMummy1_CurrTime";
            this.nudMummy1_CurrTime.Size = new System.Drawing.Size(120, 20);
            this.nudMummy1_CurrTime.TabIndex = 1;
            this.nudMummy1_CurrTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudMummy1_CurrTime_MouseClick);
            // 
            // lblTimeCurrent_Mum1
            // 
            this.lblTimeCurrent_Mum1.AutoSize = true;
            this.lblTimeCurrent_Mum1.Location = new System.Drawing.Point(6, 21);
            this.lblTimeCurrent_Mum1.Name = "lblTimeCurrent_Mum1";
            this.lblTimeCurrent_Mum1.Size = new System.Drawing.Size(55, 13);
            this.lblTimeCurrent_Mum1.TabIndex = 0;
            this.lblTimeCurrent_Mum1.Text = "Mummy 1:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lvwTripMummyRot);
            this.groupBox6.Location = new System.Drawing.Point(6, 164);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(883, 106);
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
            this.lvwTripMummyRot.ContextMenuStrip = this.ContextMenu_Rotation;
            this.lvwTripMummyRot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTripMummyRot.FullRowSelect = true;
            this.lvwTripMummyRot.HideSelection = false;
            this.lvwTripMummyRot.Location = new System.Drawing.Point(3, 16);
            this.lvwTripMummyRot.Name = "lvwTripMummyRot";
            this.lvwTripMummyRot.Size = new System.Drawing.Size(877, 87);
            this.lvwTripMummyRot.TabIndex = 0;
            this.lvwTripMummyRot.UseCompatibleStateImageBehavior = false;
            this.lvwTripMummyRot.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "X";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Y";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Z";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "W";
            this.columnHeader4.Width = 90;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lvwTripMummyPos);
            this.groupBox5.Location = new System.Drawing.Point(6, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(883, 90);
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
            this.lvwTripMummyPos.ContextMenuStrip = this.ContextMenu_Position;
            this.lvwTripMummyPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTripMummyPos.FullRowSelect = true;
            this.lvwTripMummyPos.HideSelection = false;
            this.lvwTripMummyPos.Location = new System.Drawing.Point(3, 16);
            this.lvwTripMummyPos.Name = "lvwTripMummyPos";
            this.lvwTripMummyPos.Size = new System.Drawing.Size(877, 71);
            this.lvwTripMummyPos.TabIndex = 0;
            this.lvwTripMummyPos.UseCompatibleStateImageBehavior = false;
            this.lvwTripMummyPos.View = System.Windows.Forms.View.Details;
            // 
            // ColMumPosX
            // 
            this.ColMumPosX.Text = "X";
            this.ColMumPosX.Width = 90;
            // 
            // ColMumPosY
            // 
            this.ColMumPosY.Text = "Y";
            this.ColMumPosY.Width = 90;
            // 
            // ColMumPosZ
            // 
            this.ColMumPosZ.Text = "Z";
            this.ColMumPosZ.Width = 90;
            // 
            // ColMumPosW
            // 
            this.ColMumPosW.Text = "W";
            this.ColMumPosW.Width = 90;
            // 
            // ContextMenu_Position
            // 
            this.ContextMenu_Position.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Pos_Add,
            this.MenuItem_Pos_Modify,
            this.MenuItem_Pos_Remove});
            this.ContextMenu_Position.Name = "ContextMenu_Position";
            this.ContextMenu_Position.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenu_Position.Size = new System.Drawing.Size(113, 70);
            // 
            // MenuItem_Pos_Add
            // 
            this.MenuItem_Pos_Add.Name = "MenuItem_Pos_Add";
            this.MenuItem_Pos_Add.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_Pos_Add.Text = "Add";
            this.MenuItem_Pos_Add.Click += new System.EventHandler(this.MenuItem_Pos_Add_Click);
            // 
            // MenuItem_Pos_Modify
            // 
            this.MenuItem_Pos_Modify.Name = "MenuItem_Pos_Modify";
            this.MenuItem_Pos_Modify.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_Pos_Modify.Text = "Modify";
            this.MenuItem_Pos_Modify.Click += new System.EventHandler(this.MenuItem_Pos_Modify_Click);
            // 
            // MenuItem_Pos_Remove
            // 
            this.MenuItem_Pos_Remove.Name = "MenuItem_Pos_Remove";
            this.MenuItem_Pos_Remove.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_Pos_Remove.Text = "Delete";
            this.MenuItem_Pos_Remove.Click += new System.EventHandler(this.MenuItem_Pos_Remove_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chkMummyCopy2);
            this.groupBox4.Controls.Add(this.chkMummyCopy1);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(883, 43);
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
            this.chkMummyCopy2.CheckedChanged += new System.EventHandler(this.ChkMummyCopy2_CheckedChanged);
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
            this.chkMummyCopy1.CheckedChanged += new System.EventHandler(this.ChkMummyCopy1_CheckedChanged);
            // 
            // grbxPlayerIndex
            // 
            this.grbxPlayerIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxPlayerIndex.Controls.Add(this.cbxPlayerCharacter);
            this.grbxPlayerIndex.Controls.Add(this.label1);
            this.grbxPlayerIndex.Location = new System.Drawing.Point(3, 3);
            this.grbxPlayerIndex.Name = "grbxPlayerIndex";
            this.grbxPlayerIndex.Size = new System.Drawing.Size(895, 55);
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
            this.cbxPlayerCharacter.SelectionChangeCommitted += new System.EventHandler(this.CbxPlayerCharacter_SelectionChangeCommitted);
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
            // ContextMenu_Rotation
            // 
            this.ContextMenu_Rotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Rot_Add,
            this.MenuItem_Rot_Modify,
            this.MenuItem_Rot_Delete});
            this.ContextMenu_Rotation.Name = "ContextMenu_Rotation";
            this.ContextMenu_Rotation.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenu_Rotation.Size = new System.Drawing.Size(181, 92);
            // 
            // MenuItem_Rot_Add
            // 
            this.MenuItem_Rot_Add.Name = "MenuItem_Rot_Add";
            this.MenuItem_Rot_Add.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Rot_Add.Text = "Add";
            this.MenuItem_Rot_Add.Click += new System.EventHandler(this.MenuItem_Rot_Add_Click);
            // 
            // MenuItem_Rot_Modify
            // 
            this.MenuItem_Rot_Modify.Name = "MenuItem_Rot_Modify";
            this.MenuItem_Rot_Modify.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Rot_Modify.Text = "Modify";
            this.MenuItem_Rot_Modify.Click += new System.EventHandler(this.MenuItem_Rot_Modify_Click);
            // 
            // MenuItem_Rot_Delete
            // 
            this.MenuItem_Rot_Delete.Name = "MenuItem_Rot_Delete";
            this.MenuItem_Rot_Delete.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Rot_Delete.Text = "Delete";
            this.MenuItem_Rot_Delete.Click += new System.EventHandler(this.MenuItem_Rot_Delete_Click);
            // 
            // UserControl_PlayerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbxPlayerIndex);
            this.Name = "UserControl_PlayerData";
            this.Size = new System.Drawing.Size(901, 510);
            this.groupBox3.ResumeLayout(false);
            this.grbxMumAbility.ResumeLayout(false);
            this.grbxMumAbility.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy3_MaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy2_MaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy1_MaxTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy3_CurrTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy2_CurrTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummy1_CurrTime)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ContextMenu_Position.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbxPlayerIndex.ResumeLayout(false);
            this.grbxPlayerIndex.PerformLayout();
            this.ContextMenu_Rotation.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Position;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Pos_Add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Pos_Modify;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Pos_Remove;
        private System.Windows.Forms.GroupBox grbxMumAbility;
        private System.Windows.Forms.CheckBox chkMum3Ability;
        private System.Windows.Forms.CheckBox chkMum2Ability;
        private System.Windows.Forms.CheckBox chkMum1Ability;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudMummy1_CurrTime;
        private System.Windows.Forms.Label lblTimeCurrent_Mum1;
        private System.Windows.Forms.NumericUpDown nudMummy3_CurrTime;
        private System.Windows.Forms.Label lblTimeCurrent_Mum3;
        private System.Windows.Forms.NumericUpDown nudMummy2_CurrTime;
        private System.Windows.Forms.Label lblTimeCurrent_Mum2;
        private System.Windows.Forms.NumericUpDown nudMummy3_MaxTime;
        private System.Windows.Forms.Label lblTimeMax_Mum3;
        private System.Windows.Forms.NumericUpDown nudMummy2_MaxTime;
        private System.Windows.Forms.Label lblTimeMax_Mum2;
        private System.Windows.Forms.NumericUpDown nudMummy1_MaxTime;
        private System.Windows.Forms.Label lblTimeMax_Mum1;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Rotation;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Rot_Add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Rot_Modify;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Rot_Delete;
    }
}
