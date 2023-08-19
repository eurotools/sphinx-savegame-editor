
namespace SavegameEditor
{
    partial class FrmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAutoLOad = new System.Windows.Forms.Button();
            this.Button_Test = new System.Windows.Forms.Button();
            this.txtbLevelTime = new System.Windows.Forms.TextBox();
            this.lvlLevelTime = new System.Windows.Forms.Label();
            this.numLevelEntrance = new System.Windows.Forms.NumericUpDown();
            this.lvlLevelEntrance = new System.Windows.Forms.Label();
            this.numLevelRestart = new System.Windows.Forms.NumericUpDown();
            this.lblLevelRestart = new System.Windows.Forms.Label();
            this.cbxLevelHashCode = new System.Windows.Forms.ComboBox();
            this.lblLevelHashcode = new System.Windows.Forms.Label();
            this.txtbTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.numCrowns = new System.Windows.Forms.NumericUpDown();
            this.lblCrowns = new System.Windows.Forms.Label();
            this.numHealthAnkhs = new System.Windows.Forms.NumericUpDown();
            this.lblHealthAnkhs = new System.Windows.Forms.Label();
            this.numScarabs = new System.Windows.Forms.NumericUpDown();
            this.lblSacarabs = new System.Windows.Forms.Label();
            this.txtGameTime = new System.Windows.Forms.TextBox();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabPageObjectives = new System.Windows.Forms.TabPage();
            this.UserControl_Objectives = new SavegameEditor.Forms.Panels.UserControl_Objectives();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabControlInventory = new System.Windows.Forms.TabControl();
            this.tabPageSphinxInv = new System.Windows.Forms.TabPage();
            this.SphinxInventory = new SavegameEditor.UserControl_BosInventory();
            this.tabPageMummyInv = new System.Windows.Forms.TabPage();
            this.MummyInventory = new SavegameEditor.UserControl_BosInventory();
            this.tabPageCurrentLevel = new System.Windows.Forms.TabPage();
            this.lvwCurrentLevelTriggers = new SavegameEditor.ListView_ColumnSortingClick();
            this.colTrigType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTrigSubtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSavedStateValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPagePlayerData = new System.Windows.Forms.TabPage();
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
            this.tabPageOthers = new System.Windows.Forms.TabPage();
            this.tabControlNotes = new System.Windows.Forms.TabControl();
            this.tabPageSphinx = new System.Windows.Forms.TabPage();
            this.grbxPropsSphinxInv = new System.Windows.Forms.GroupBox();
            this.nudSphinxActiveNotes = new System.Windows.Forms.NumericUpDown();
            this.lblSphinxActiveNotes = new System.Windows.Forms.Label();
            this.lvwNotesSphinxInv = new SavegameEditor.ListView_ColumnSortingClick();
            this.colSphinxNoteTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSphinxNoteDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageMummy = new System.Windows.Forms.TabPage();
            this.grbxPropsMummyInv = new System.Windows.Forms.GroupBox();
            this.nudMummyActiveNotes = new System.Windows.Forms.NumericUpDown();
            this.lblMummyActiveNotes = new System.Windows.Forms.Label();
            this.lvwNotesMummyInv = new SavegameEditor.ListView_ColumnSortingClick();
            this.colMummyTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMummyDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbxSphinx = new System.Windows.Forms.GroupBox();
            this.cbxProgSphinxBut3 = new System.Windows.Forms.ComboBox();
            this.lblProgSphinxBut3 = new System.Windows.Forms.Label();
            this.cbxProgSphinxBut2 = new System.Windows.Forms.ComboBox();
            this.lblProgSphinxBut2 = new System.Windows.Forms.Label();
            this.cbxProgSphinxBut1 = new System.Windows.Forms.ComboBox();
            this.lblProgSphinxBut1 = new System.Windows.Forms.Label();
            this.grbxMummy = new System.Windows.Forms.GroupBox();
            this.cbxProgMumBut3 = new System.Windows.Forms.ComboBox();
            this.lblProgMumBut3 = new System.Windows.Forms.Label();
            this.cbxProgMumBut2 = new System.Windows.Forms.ComboBox();
            this.lblProgMumBut2 = new System.Windows.Forms.Label();
            this.cbxProgMumBut1 = new System.Windows.Forms.ComboBox();
            this.lblProgMumBut1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lvwCameraPos = new SavegameEditor.ListView_ColumnSortingClick();
            this.colCameraX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCameraY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCameraZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCameraW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtElevation = new System.Windows.Forms.TextBox();
            this.lblElevation = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTotalHealthThirds = new System.Windows.Forms.NumericUpDown();
            this.nudHealthThirds = new System.Windows.Forms.NumericUpDown();
            this.lblTotalHealthThirds = new System.Windows.Forms.Label();
            this.lblHealthThirds = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabelPlatform = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelObjectivesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelSphinxItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelMummyItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrowns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealthAnkhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScarabs)).BeginInit();
            this.tabContent.SuspendLayout();
            this.tabPageObjectives.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabControlInventory.SuspendLayout();
            this.tabPageSphinxInv.SuspendLayout();
            this.tabPageMummyInv.SuspendLayout();
            this.tabPageCurrentLevel.SuspendLayout();
            this.tabPagePlayerData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbxPlayerIndex.SuspendLayout();
            this.tabPageOthers.SuspendLayout();
            this.tabControlNotes.SuspendLayout();
            this.tabPageSphinx.SuspendLayout();
            this.grbxPropsSphinxInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphinxActiveNotes)).BeginInit();
            this.tabPageMummy.SuspendLayout();
            this.grbxPropsMummyInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummyActiveNotes)).BeginInit();
            this.grbxSphinx.SuspendLayout();
            this.grbxMummy.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalHealthThirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthThirds)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(840, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpenFile,
            this.MenuItem_Save,
            this.toolStripSeparator1,
            this.MenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuItemOpenFile
            // 
            this.MenuItemOpenFile.Name = "MenuItemOpenFile";
            this.MenuItemOpenFile.Size = new System.Drawing.Size(103, 22);
            this.MenuItemOpenFile.Text = "Open";
            this.MenuItemOpenFile.Click += new System.EventHandler(this.MenuItemOpenFile_Click);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Name = "MenuItem_Save";
            this.MenuItem_Save.Size = new System.Drawing.Size(103, 22);
            this.MenuItem_Save.Text = "Save";
            this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(103, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAutoLOad);
            this.groupBox2.Controls.Add(this.Button_Test);
            this.groupBox2.Controls.Add(this.txtbLevelTime);
            this.groupBox2.Controls.Add(this.lvlLevelTime);
            this.groupBox2.Controls.Add(this.numLevelEntrance);
            this.groupBox2.Controls.Add(this.lvlLevelEntrance);
            this.groupBox2.Controls.Add(this.numLevelRestart);
            this.groupBox2.Controls.Add(this.lblLevelRestart);
            this.groupBox2.Controls.Add(this.cbxLevelHashCode);
            this.groupBox2.Controls.Add(this.lblLevelHashcode);
            this.groupBox2.Controls.Add(this.txtbTag);
            this.groupBox2.Controls.Add(this.lblTag);
            this.groupBox2.Controls.Add(this.numCrowns);
            this.groupBox2.Controls.Add(this.lblCrowns);
            this.groupBox2.Controls.Add(this.numHealthAnkhs);
            this.groupBox2.Controls.Add(this.lblHealthAnkhs);
            this.groupBox2.Controls.Add(this.numScarabs);
            this.groupBox2.Controls.Add(this.lblSacarabs);
            this.groupBox2.Controls.Add(this.txtGameTime);
            this.groupBox2.Controls.Add(this.lblGameTime);
            this.groupBox2.Controls.Add(this.txtVersion);
            this.groupBox2.Controls.Add(this.lblVersion);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Header Data";
            // 
            // btnAutoLOad
            // 
            this.btnAutoLOad.Location = new System.Drawing.Point(534, 71);
            this.btnAutoLOad.Name = "btnAutoLOad";
            this.btnAutoLOad.Size = new System.Drawing.Size(75, 23);
            this.btnAutoLOad.TabIndex = 23;
            this.btnAutoLOad.Text = "Auto Load";
            this.btnAutoLOad.UseVisualStyleBackColor = true;
            this.btnAutoLOad.Click += new System.EventHandler(this.BtnAutoLOad_Click);
            // 
            // Button_Test
            // 
            this.Button_Test.Location = new System.Drawing.Point(453, 70);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(75, 23);
            this.Button_Test.TabIndex = 22;
            this.Button_Test.Text = "Test Save";
            this.Button_Test.UseVisualStyleBackColor = true;
            this.Button_Test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // txtbLevelTime
            // 
            this.txtbLevelTime.Location = new System.Drawing.Point(354, 73);
            this.txtbLevelTime.Name = "txtbLevelTime";
            this.txtbLevelTime.Size = new System.Drawing.Size(93, 20);
            this.txtbLevelTime.TabIndex = 21;
            this.txtbLevelTime.Text = "0";
            // 
            // lvlLevelTime
            // 
            this.lvlLevelTime.AutoSize = true;
            this.lvlLevelTime.Location = new System.Drawing.Point(286, 76);
            this.lvlLevelTime.Name = "lvlLevelTime";
            this.lvlLevelTime.Size = new System.Drawing.Size(62, 13);
            this.lvlLevelTime.TabIndex = 20;
            this.lvlLevelTime.Text = "Level Time:";
            // 
            // numLevelEntrance
            // 
            this.numLevelEntrance.Location = new System.Drawing.Point(555, 45);
            this.numLevelEntrance.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numLevelEntrance.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numLevelEntrance.Name = "numLevelEntrance";
            this.numLevelEntrance.Size = new System.Drawing.Size(65, 20);
            this.numLevelEntrance.TabIndex = 19;
            this.numLevelEntrance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumLevelEntrance_MouseClick);
            // 
            // lvlLevelEntrance
            // 
            this.lvlLevelEntrance.AutoSize = true;
            this.lvlLevelEntrance.Location = new System.Drawing.Point(453, 48);
            this.lvlLevelEntrance.Name = "lvlLevelEntrance";
            this.lvlLevelEntrance.Size = new System.Drawing.Size(96, 13);
            this.lvlLevelEntrance.TabIndex = 18;
            this.lvlLevelEntrance.Text = "Level Entrance ID:";
            // 
            // numLevelRestart
            // 
            this.numLevelRestart.Location = new System.Drawing.Point(555, 20);
            this.numLevelRestart.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numLevelRestart.Name = "numLevelRestart";
            this.numLevelRestart.Size = new System.Drawing.Size(65, 20);
            this.numLevelRestart.TabIndex = 17;
            this.numLevelRestart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumLevelRestart_MouseClick);
            // 
            // lblLevelRestart
            // 
            this.lblLevelRestart.AutoSize = true;
            this.lblLevelRestart.Location = new System.Drawing.Point(462, 22);
            this.lblLevelRestart.Name = "lblLevelRestart";
            this.lblLevelRestart.Size = new System.Drawing.Size(87, 13);
            this.lblLevelRestart.TabIndex = 16;
            this.lblLevelRestart.Text = "Level Restart ID:";
            // 
            // cbxLevelHashCode
            // 
            this.cbxLevelHashCode.DisplayMember = "Value";
            this.cbxLevelHashCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevelHashCode.FormattingEnabled = true;
            this.cbxLevelHashCode.Location = new System.Drawing.Point(101, 73);
            this.cbxLevelHashCode.Name = "cbxLevelHashCode";
            this.cbxLevelHashCode.Size = new System.Drawing.Size(179, 21);
            this.cbxLevelHashCode.TabIndex = 15;
            this.cbxLevelHashCode.ValueMember = "Key";
            this.cbxLevelHashCode.SelectionChangeCommitted += new System.EventHandler(this.CbxLevelHashCode_SelectionChangeCommitted);
            // 
            // lblLevelHashcode
            // 
            this.lblLevelHashcode.AutoSize = true;
            this.lblLevelHashcode.Location = new System.Drawing.Point(6, 76);
            this.lblLevelHashcode.Name = "lblLevelHashcode";
            this.lblLevelHashcode.Size = new System.Drawing.Size(89, 13);
            this.lblLevelHashcode.TabIndex = 14;
            this.lblLevelHashcode.Text = "Level HashCode:";
            // 
            // txtbTag
            // 
            this.txtbTag.BackColor = System.Drawing.SystemColors.Window;
            this.txtbTag.Location = new System.Drawing.Point(344, 45);
            this.txtbTag.MaxLength = 16;
            this.txtbTag.Name = "txtbTag";
            this.txtbTag.ReadOnly = true;
            this.txtbTag.Size = new System.Drawing.Size(103, 20);
            this.txtbTag.TabIndex = 13;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(309, 48);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 12;
            this.lblTag.Text = "Tag:";
            // 
            // numCrowns
            // 
            this.numCrowns.Location = new System.Drawing.Point(395, 20);
            this.numCrowns.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numCrowns.Name = "numCrowns";
            this.numCrowns.Size = new System.Drawing.Size(61, 20);
            this.numCrowns.TabIndex = 11;
            this.numCrowns.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumCrowns_MouseClick);
            // 
            // lblCrowns
            // 
            this.lblCrowns.AutoSize = true;
            this.lblCrowns.Location = new System.Drawing.Point(344, 22);
            this.lblCrowns.Name = "lblCrowns";
            this.lblCrowns.Size = new System.Drawing.Size(45, 13);
            this.lblCrowns.TabIndex = 10;
            this.lblCrowns.Text = "Crowns:";
            // 
            // numHealthAnkhs
            // 
            this.numHealthAnkhs.Location = new System.Drawing.Point(243, 46);
            this.numHealthAnkhs.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numHealthAnkhs.Name = "numHealthAnkhs";
            this.numHealthAnkhs.Size = new System.Drawing.Size(60, 20);
            this.numHealthAnkhs.TabIndex = 9;
            this.numHealthAnkhs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumHealthAnkhs_MouseClick);
            // 
            // lblHealthAnkhs
            // 
            this.lblHealthAnkhs.AutoSize = true;
            this.lblHealthAnkhs.Location = new System.Drawing.Point(163, 48);
            this.lblHealthAnkhs.Name = "lblHealthAnkhs";
            this.lblHealthAnkhs.Size = new System.Drawing.Size(74, 13);
            this.lblHealthAnkhs.TabIndex = 8;
            this.lblHealthAnkhs.Text = "Health Ankhs:";
            // 
            // numScarabs
            // 
            this.numScarabs.Location = new System.Drawing.Point(218, 20);
            this.numScarabs.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numScarabs.Name = "numScarabs";
            this.numScarabs.Size = new System.Drawing.Size(120, 20);
            this.numScarabs.TabIndex = 7;
            this.numScarabs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumScarabs_MouseClick);
            // 
            // lblSacarabs
            // 
            this.lblSacarabs.AutoSize = true;
            this.lblSacarabs.Location = new System.Drawing.Point(163, 22);
            this.lblSacarabs.Name = "lblSacarabs";
            this.lblSacarabs.Size = new System.Drawing.Size(49, 13);
            this.lblSacarabs.TabIndex = 6;
            this.lblSacarabs.Text = "Scarabs:";
            // 
            // txtGameTime
            // 
            this.txtGameTime.Location = new System.Drawing.Point(76, 45);
            this.txtGameTime.Name = "txtGameTime";
            this.txtGameTime.Size = new System.Drawing.Size(81, 20);
            this.txtGameTime.TabIndex = 5;
            this.txtGameTime.Text = "0";
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.Location = new System.Drawing.Point(6, 48);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(64, 13);
            this.lblGameTime.TabIndex = 4;
            this.lblGameTime.Text = "Game Time:";
            // 
            // txtVersion
            // 
            this.txtVersion.BackColor = System.Drawing.SystemColors.Window;
            this.txtVersion.Location = new System.Drawing.Point(57, 19);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.Text = "0";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(6, 22);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version:";
            // 
            // tabContent
            // 
            this.tabContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContent.Controls.Add(this.tabPageObjectives);
            this.tabContent.Controls.Add(this.tabPageInventory);
            this.tabContent.Controls.Add(this.tabPageCurrentLevel);
            this.tabContent.Controls.Add(this.tabPagePlayerData);
            this.tabContent.Controls.Add(this.tabPageOthers);
            this.tabContent.Location = new System.Drawing.Point(12, 159);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(816, 607);
            this.tabContent.TabIndex = 4;
            // 
            // tabPageObjectives
            // 
            this.tabPageObjectives.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageObjectives.Controls.Add(this.UserControl_Objectives);
            this.tabPageObjectives.Location = new System.Drawing.Point(4, 22);
            this.tabPageObjectives.Name = "tabPageObjectives";
            this.tabPageObjectives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObjectives.Size = new System.Drawing.Size(808, 581);
            this.tabPageObjectives.TabIndex = 0;
            this.tabPageObjectives.Text = "Objectives";
            // 
            // UserControl_Objectives
            // 
            this.UserControl_Objectives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_Objectives.Location = new System.Drawing.Point(3, 3);
            this.UserControl_Objectives.Name = "UserControl_Objectives";
            this.UserControl_Objectives.Size = new System.Drawing.Size(802, 575);
            this.UserControl_Objectives.TabIndex = 0;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageInventory.Controls.Add(this.tabControlInventory);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(808, 581);
            this.tabPageInventory.TabIndex = 1;
            this.tabPageInventory.Text = "Inventory";
            // 
            // tabControlInventory
            // 
            this.tabControlInventory.Controls.Add(this.tabPageSphinxInv);
            this.tabControlInventory.Controls.Add(this.tabPageMummyInv);
            this.tabControlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInventory.Location = new System.Drawing.Point(3, 3);
            this.tabControlInventory.Name = "tabControlInventory";
            this.tabControlInventory.SelectedIndex = 0;
            this.tabControlInventory.Size = new System.Drawing.Size(802, 575);
            this.tabControlInventory.TabIndex = 0;
            // 
            // tabPageSphinxInv
            // 
            this.tabPageSphinxInv.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSphinxInv.Controls.Add(this.SphinxInventory);
            this.tabPageSphinxInv.Location = new System.Drawing.Point(4, 22);
            this.tabPageSphinxInv.Name = "tabPageSphinxInv";
            this.tabPageSphinxInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSphinxInv.Size = new System.Drawing.Size(794, 549);
            this.tabPageSphinxInv.TabIndex = 0;
            this.tabPageSphinxInv.Text = "Sphinx";
            // 
            // SphinxInventory
            // 
            this.SphinxInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SphinxInventory.Location = new System.Drawing.Point(3, 3);
            this.SphinxInventory.Name = "SphinxInventory";
            this.SphinxInventory.Size = new System.Drawing.Size(788, 543);
            this.SphinxInventory.TabIndex = 0;
            // 
            // tabPageMummyInv
            // 
            this.tabPageMummyInv.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMummyInv.Controls.Add(this.MummyInventory);
            this.tabPageMummyInv.Location = new System.Drawing.Point(4, 22);
            this.tabPageMummyInv.Name = "tabPageMummyInv";
            this.tabPageMummyInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMummyInv.Size = new System.Drawing.Size(794, 549);
            this.tabPageMummyInv.TabIndex = 1;
            this.tabPageMummyInv.Text = "Mummy";
            // 
            // MummyInventory
            // 
            this.MummyInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MummyInventory.Location = new System.Drawing.Point(3, 3);
            this.MummyInventory.Name = "MummyInventory";
            this.MummyInventory.Size = new System.Drawing.Size(788, 543);
            this.MummyInventory.TabIndex = 0;
            // 
            // tabPageCurrentLevel
            // 
            this.tabPageCurrentLevel.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCurrentLevel.Controls.Add(this.lvwCurrentLevelTriggers);
            this.tabPageCurrentLevel.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurrentLevel.Name = "tabPageCurrentLevel";
            this.tabPageCurrentLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentLevel.Size = new System.Drawing.Size(808, 581);
            this.tabPageCurrentLevel.TabIndex = 2;
            this.tabPageCurrentLevel.Text = "Current Level";
            // 
            // lvwCurrentLevelTriggers
            // 
            this.lvwCurrentLevelTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrigType,
            this.ColTrigSubtype,
            this.ColSavedStateValue,
            this.ColPosX,
            this.ColPosY,
            this.ColPosZ});
            this.lvwCurrentLevelTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCurrentLevelTriggers.FullRowSelect = true;
            this.lvwCurrentLevelTriggers.HideSelection = false;
            this.lvwCurrentLevelTriggers.Location = new System.Drawing.Point(3, 3);
            this.lvwCurrentLevelTriggers.Name = "lvwCurrentLevelTriggers";
            this.lvwCurrentLevelTriggers.Size = new System.Drawing.Size(802, 575);
            this.lvwCurrentLevelTriggers.TabIndex = 0;
            this.lvwCurrentLevelTriggers.UseCompatibleStateImageBehavior = false;
            this.lvwCurrentLevelTriggers.View = System.Windows.Forms.View.Details;
            // 
            // colTrigType
            // 
            this.colTrigType.Text = "Trigger Type";
            this.colTrigType.Width = 120;
            // 
            // ColTrigSubtype
            // 
            this.ColTrigSubtype.Text = "Trigger Subtype";
            this.ColTrigSubtype.Width = 120;
            // 
            // ColSavedStateValue
            // 
            this.ColSavedStateValue.Text = "Saved State Value";
            this.ColSavedStateValue.Width = 120;
            // 
            // ColPosX
            // 
            this.ColPosX.Text = "X";
            this.ColPosX.Width = 100;
            // 
            // ColPosY
            // 
            this.ColPosY.Text = "Y";
            this.ColPosY.Width = 100;
            // 
            // ColPosZ
            // 
            this.ColPosZ.Text = "Z";
            this.ColPosZ.Width = 100;
            // 
            // tabPagePlayerData
            // 
            this.tabPagePlayerData.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePlayerData.Controls.Add(this.groupBox3);
            this.tabPagePlayerData.Controls.Add(this.grbxPlayerIndex);
            this.tabPagePlayerData.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayerData.Name = "tabPagePlayerData";
            this.tabPagePlayerData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayerData.Size = new System.Drawing.Size(808, 581);
            this.tabPagePlayerData.TabIndex = 3;
            this.tabPagePlayerData.Text = "Player Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(6, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(796, 508);
            this.groupBox3.TabIndex = 1;
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
            this.groupBox6.Size = new System.Drawing.Size(784, 255);
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
            this.lvwTripMummyRot.Size = new System.Drawing.Size(778, 236);
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
            this.groupBox5.Size = new System.Drawing.Size(784, 173);
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
            this.lvwTripMummyPos.Size = new System.Drawing.Size(778, 154);
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
            this.grbxPlayerIndex.Location = new System.Drawing.Point(6, 6);
            this.grbxPlayerIndex.Name = "grbxPlayerIndex";
            this.grbxPlayerIndex.Size = new System.Drawing.Size(796, 55);
            this.grbxPlayerIndex.TabIndex = 0;
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
            // tabPageOthers
            // 
            this.tabPageOthers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageOthers.Controls.Add(this.tabControlNotes);
            this.tabPageOthers.Controls.Add(this.grbxSphinx);
            this.tabPageOthers.Controls.Add(this.grbxMummy);
            this.tabPageOthers.Controls.Add(this.groupBox7);
            this.tabPageOthers.Location = new System.Drawing.Point(4, 22);
            this.tabPageOthers.Name = "tabPageOthers";
            this.tabPageOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOthers.Size = new System.Drawing.Size(808, 581);
            this.tabPageOthers.TabIndex = 4;
            this.tabPageOthers.Text = "Others";
            // 
            // tabControlNotes
            // 
            this.tabControlNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlNotes.Controls.Add(this.tabPageSphinx);
            this.tabControlNotes.Controls.Add(this.tabPageMummy);
            this.tabControlNotes.Location = new System.Drawing.Point(6, 315);
            this.tabControlNotes.Name = "tabControlNotes";
            this.tabControlNotes.SelectedIndex = 0;
            this.tabControlNotes.Size = new System.Drawing.Size(796, 260);
            this.tabControlNotes.TabIndex = 9;
            // 
            // tabPageSphinx
            // 
            this.tabPageSphinx.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSphinx.Controls.Add(this.grbxPropsSphinxInv);
            this.tabPageSphinx.Controls.Add(this.lvwNotesSphinxInv);
            this.tabPageSphinx.Location = new System.Drawing.Point(4, 22);
            this.tabPageSphinx.Name = "tabPageSphinx";
            this.tabPageSphinx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSphinx.Size = new System.Drawing.Size(788, 234);
            this.tabPageSphinx.TabIndex = 0;
            this.tabPageSphinx.Text = "Sphinx";
            // 
            // grbxPropsSphinxInv
            // 
            this.grbxPropsSphinxInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxPropsSphinxInv.Controls.Add(this.nudSphinxActiveNotes);
            this.grbxPropsSphinxInv.Controls.Add(this.lblSphinxActiveNotes);
            this.grbxPropsSphinxInv.Location = new System.Drawing.Point(6, 6);
            this.grbxPropsSphinxInv.Name = "grbxPropsSphinxInv";
            this.grbxPropsSphinxInv.Size = new System.Drawing.Size(776, 50);
            this.grbxPropsSphinxInv.TabIndex = 3;
            this.grbxPropsSphinxInv.TabStop = false;
            this.grbxPropsSphinxInv.Text = "Properties";
            // 
            // nudSphinxActiveNotes
            // 
            this.nudSphinxActiveNotes.Location = new System.Drawing.Point(83, 19);
            this.nudSphinxActiveNotes.Name = "nudSphinxActiveNotes";
            this.nudSphinxActiveNotes.Size = new System.Drawing.Size(120, 20);
            this.nudSphinxActiveNotes.TabIndex = 1;
            this.nudSphinxActiveNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudSphinxActiveNotes_MouseClick);
            // 
            // lblSphinxActiveNotes
            // 
            this.lblSphinxActiveNotes.AutoSize = true;
            this.lblSphinxActiveNotes.Location = new System.Drawing.Point(6, 21);
            this.lblSphinxActiveNotes.Name = "lblSphinxActiveNotes";
            this.lblSphinxActiveNotes.Size = new System.Drawing.Size(71, 13);
            this.lblSphinxActiveNotes.TabIndex = 0;
            this.lblSphinxActiveNotes.Text = "Active Notes:";
            // 
            // lvwNotesSphinxInv
            // 
            this.lvwNotesSphinxInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwNotesSphinxInv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSphinxNoteTitle,
            this.colSphinxNoteDesc});
            this.lvwNotesSphinxInv.FullRowSelect = true;
            this.lvwNotesSphinxInv.HideSelection = false;
            this.lvwNotesSphinxInv.Location = new System.Drawing.Point(6, 62);
            this.lvwNotesSphinxInv.Name = "lvwNotesSphinxInv";
            this.lvwNotesSphinxInv.Size = new System.Drawing.Size(776, 166);
            this.lvwNotesSphinxInv.TabIndex = 2;
            this.lvwNotesSphinxInv.UseCompatibleStateImageBehavior = false;
            this.lvwNotesSphinxInv.View = System.Windows.Forms.View.Details;
            // 
            // colSphinxNoteTitle
            // 
            this.colSphinxNoteTitle.Text = "Title";
            this.colSphinxNoteTitle.Width = 200;
            // 
            // colSphinxNoteDesc
            // 
            this.colSphinxNoteDesc.Text = "Description";
            this.colSphinxNoteDesc.Width = 200;
            // 
            // tabPageMummy
            // 
            this.tabPageMummy.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMummy.Controls.Add(this.grbxPropsMummyInv);
            this.tabPageMummy.Controls.Add(this.lvwNotesMummyInv);
            this.tabPageMummy.Location = new System.Drawing.Point(4, 22);
            this.tabPageMummy.Name = "tabPageMummy";
            this.tabPageMummy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMummy.Size = new System.Drawing.Size(788, 234);
            this.tabPageMummy.TabIndex = 1;
            this.tabPageMummy.Text = "Mummy";
            // 
            // grbxPropsMummyInv
            // 
            this.grbxPropsMummyInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxPropsMummyInv.Controls.Add(this.nudMummyActiveNotes);
            this.grbxPropsMummyInv.Controls.Add(this.lblMummyActiveNotes);
            this.grbxPropsMummyInv.Location = new System.Drawing.Point(6, 6);
            this.grbxPropsMummyInv.Name = "grbxPropsMummyInv";
            this.grbxPropsMummyInv.Size = new System.Drawing.Size(776, 50);
            this.grbxPropsMummyInv.TabIndex = 1;
            this.grbxPropsMummyInv.TabStop = false;
            this.grbxPropsMummyInv.Text = "Properties";
            // 
            // nudMummyActiveNotes
            // 
            this.nudMummyActiveNotes.Location = new System.Drawing.Point(83, 19);
            this.nudMummyActiveNotes.Name = "nudMummyActiveNotes";
            this.nudMummyActiveNotes.Size = new System.Drawing.Size(120, 20);
            this.nudMummyActiveNotes.TabIndex = 1;
            this.nudMummyActiveNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudMummyActiveNotes_MouseClick);
            // 
            // lblMummyActiveNotes
            // 
            this.lblMummyActiveNotes.AutoSize = true;
            this.lblMummyActiveNotes.Location = new System.Drawing.Point(6, 21);
            this.lblMummyActiveNotes.Name = "lblMummyActiveNotes";
            this.lblMummyActiveNotes.Size = new System.Drawing.Size(71, 13);
            this.lblMummyActiveNotes.TabIndex = 0;
            this.lblMummyActiveNotes.Text = "Active Notes:";
            // 
            // lvwNotesMummyInv
            // 
            this.lvwNotesMummyInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwNotesMummyInv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMummyTitle,
            this.colMummyDesc});
            this.lvwNotesMummyInv.FullRowSelect = true;
            this.lvwNotesMummyInv.HideSelection = false;
            this.lvwNotesMummyInv.Location = new System.Drawing.Point(6, 62);
            this.lvwNotesMummyInv.Name = "lvwNotesMummyInv";
            this.lvwNotesMummyInv.Size = new System.Drawing.Size(776, 166);
            this.lvwNotesMummyInv.TabIndex = 0;
            this.lvwNotesMummyInv.UseCompatibleStateImageBehavior = false;
            this.lvwNotesMummyInv.View = System.Windows.Forms.View.Details;
            // 
            // colMummyTitle
            // 
            this.colMummyTitle.Text = "Title";
            this.colMummyTitle.Width = 200;
            // 
            // colMummyDesc
            // 
            this.colMummyDesc.Text = "Description";
            this.colMummyDesc.Width = 200;
            // 
            // grbxSphinx
            // 
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut3);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut3);
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut2);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut2);
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut1);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut1);
            this.grbxSphinx.Location = new System.Drawing.Point(6, 251);
            this.grbxSphinx.Name = "grbxSphinx";
            this.grbxSphinx.Size = new System.Drawing.Size(796, 58);
            this.grbxSphinx.TabIndex = 8;
            this.grbxSphinx.TabStop = false;
            this.grbxSphinx.Text = "Sphinx Programmable Buttons";
            // 
            // cbxProgSphinxBut3
            // 
            this.cbxProgSphinxBut3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgSphinxBut3.FormattingEnabled = true;
            this.cbxProgSphinxBut3.Location = new System.Drawing.Point(577, 19);
            this.cbxProgSphinxBut3.Name = "cbxProgSphinxBut3";
            this.cbxProgSphinxBut3.Size = new System.Drawing.Size(200, 21);
            this.cbxProgSphinxBut3.TabIndex = 5;
            // 
            // lblProgSphinxBut3
            // 
            this.lblProgSphinxBut3.AutoSize = true;
            this.lblProgSphinxBut3.Location = new System.Drawing.Point(524, 22);
            this.lblProgSphinxBut3.Name = "lblProgSphinxBut3";
            this.lblProgSphinxBut3.Size = new System.Drawing.Size(47, 13);
            this.lblProgSphinxBut3.TabIndex = 4;
            this.lblProgSphinxBut3.Text = "Button3:";
            // 
            // cbxProgSphinxBut2
            // 
            this.cbxProgSphinxBut2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgSphinxBut2.FormattingEnabled = true;
            this.cbxProgSphinxBut2.Location = new System.Drawing.Point(318, 19);
            this.cbxProgSphinxBut2.Name = "cbxProgSphinxBut2";
            this.cbxProgSphinxBut2.Size = new System.Drawing.Size(200, 21);
            this.cbxProgSphinxBut2.TabIndex = 3;
            // 
            // lblProgSphinxBut2
            // 
            this.lblProgSphinxBut2.AutoSize = true;
            this.lblProgSphinxBut2.Location = new System.Drawing.Point(265, 22);
            this.lblProgSphinxBut2.Name = "lblProgSphinxBut2";
            this.lblProgSphinxBut2.Size = new System.Drawing.Size(47, 13);
            this.lblProgSphinxBut2.TabIndex = 2;
            this.lblProgSphinxBut2.Text = "Button2:";
            // 
            // cbxProgSphinxBut1
            // 
            this.cbxProgSphinxBut1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgSphinxBut1.FormattingEnabled = true;
            this.cbxProgSphinxBut1.Location = new System.Drawing.Point(59, 19);
            this.cbxProgSphinxBut1.Name = "cbxProgSphinxBut1";
            this.cbxProgSphinxBut1.Size = new System.Drawing.Size(200, 21);
            this.cbxProgSphinxBut1.TabIndex = 1;
            // 
            // lblProgSphinxBut1
            // 
            this.lblProgSphinxBut1.AutoSize = true;
            this.lblProgSphinxBut1.Location = new System.Drawing.Point(6, 22);
            this.lblProgSphinxBut1.Name = "lblProgSphinxBut1";
            this.lblProgSphinxBut1.Size = new System.Drawing.Size(47, 13);
            this.lblProgSphinxBut1.TabIndex = 0;
            this.lblProgSphinxBut1.Text = "Button1:";
            // 
            // grbxMummy
            // 
            this.grbxMummy.Controls.Add(this.cbxProgMumBut3);
            this.grbxMummy.Controls.Add(this.lblProgMumBut3);
            this.grbxMummy.Controls.Add(this.cbxProgMumBut2);
            this.grbxMummy.Controls.Add(this.lblProgMumBut2);
            this.grbxMummy.Controls.Add(this.cbxProgMumBut1);
            this.grbxMummy.Controls.Add(this.lblProgMumBut1);
            this.grbxMummy.Location = new System.Drawing.Point(6, 184);
            this.grbxMummy.Name = "grbxMummy";
            this.grbxMummy.Size = new System.Drawing.Size(796, 61);
            this.grbxMummy.TabIndex = 1;
            this.grbxMummy.TabStop = false;
            this.grbxMummy.Text = "Mummy Programmable Buttons";
            // 
            // cbxProgMumBut3
            // 
            this.cbxProgMumBut3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgMumBut3.FormattingEnabled = true;
            this.cbxProgMumBut3.Location = new System.Drawing.Point(577, 19);
            this.cbxProgMumBut3.Name = "cbxProgMumBut3";
            this.cbxProgMumBut3.Size = new System.Drawing.Size(200, 21);
            this.cbxProgMumBut3.TabIndex = 5;
            // 
            // lblProgMumBut3
            // 
            this.lblProgMumBut3.AutoSize = true;
            this.lblProgMumBut3.Location = new System.Drawing.Point(524, 22);
            this.lblProgMumBut3.Name = "lblProgMumBut3";
            this.lblProgMumBut3.Size = new System.Drawing.Size(47, 13);
            this.lblProgMumBut3.TabIndex = 4;
            this.lblProgMumBut3.Text = "Button3:";
            // 
            // cbxProgMumBut2
            // 
            this.cbxProgMumBut2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgMumBut2.FormattingEnabled = true;
            this.cbxProgMumBut2.Location = new System.Drawing.Point(318, 19);
            this.cbxProgMumBut2.Name = "cbxProgMumBut2";
            this.cbxProgMumBut2.Size = new System.Drawing.Size(200, 21);
            this.cbxProgMumBut2.TabIndex = 3;
            // 
            // lblProgMumBut2
            // 
            this.lblProgMumBut2.AutoSize = true;
            this.lblProgMumBut2.Location = new System.Drawing.Point(265, 22);
            this.lblProgMumBut2.Name = "lblProgMumBut2";
            this.lblProgMumBut2.Size = new System.Drawing.Size(47, 13);
            this.lblProgMumBut2.TabIndex = 2;
            this.lblProgMumBut2.Text = "Button2:";
            // 
            // cbxProgMumBut1
            // 
            this.cbxProgMumBut1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgMumBut1.FormattingEnabled = true;
            this.cbxProgMumBut1.Location = new System.Drawing.Point(59, 19);
            this.cbxProgMumBut1.Name = "cbxProgMumBut1";
            this.cbxProgMumBut1.Size = new System.Drawing.Size(200, 21);
            this.cbxProgMumBut1.TabIndex = 1;
            // 
            // lblProgMumBut1
            // 
            this.lblProgMumBut1.AutoSize = true;
            this.lblProgMumBut1.Location = new System.Drawing.Point(6, 22);
            this.lblProgMumBut1.Name = "lblProgMumBut1";
            this.lblProgMumBut1.Size = new System.Drawing.Size(47, 13);
            this.lblProgMumBut1.TabIndex = 0;
            this.lblProgMumBut1.Text = "Button1:";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lvwCameraPos);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(796, 172);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Camera";
            // 
            // lvwCameraPos
            // 
            this.lvwCameraPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCameraPos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCameraX,
            this.colCameraY,
            this.colCameraZ,
            this.colCameraW});
            this.lvwCameraPos.FullRowSelect = true;
            this.lvwCameraPos.HideSelection = false;
            this.lvwCameraPos.Location = new System.Drawing.Point(6, 74);
            this.lvwCameraPos.Name = "lvwCameraPos";
            this.lvwCameraPos.Size = new System.Drawing.Size(784, 92);
            this.lvwCameraPos.TabIndex = 1;
            this.lvwCameraPos.UseCompatibleStateImageBehavior = false;
            this.lvwCameraPos.View = System.Windows.Forms.View.Details;
            // 
            // colCameraX
            // 
            this.colCameraX.Text = "X";
            this.colCameraX.Width = 80;
            // 
            // colCameraY
            // 
            this.colCameraY.Text = "Y";
            this.colCameraY.Width = 80;
            // 
            // colCameraZ
            // 
            this.colCameraZ.Text = "Z";
            this.colCameraZ.Width = 80;
            // 
            // colCameraW
            // 
            this.colCameraW.Text = "W";
            this.colCameraW.Width = 80;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtDistance);
            this.groupBox8.Controls.Add(this.lblDistance);
            this.groupBox8.Controls.Add(this.txtElevation);
            this.groupBox8.Controls.Add(this.lblElevation);
            this.groupBox8.Controls.Add(this.txtAngle);
            this.groupBox8.Controls.Add(this.lblAngle);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(784, 49);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Settings";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(379, 19);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 5;
            this.txtDistance.Text = "0";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(321, 22);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(52, 13);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Distance:";
            // 
            // txtElevation
            // 
            this.txtElevation.Location = new System.Drawing.Point(215, 19);
            this.txtElevation.Name = "txtElevation";
            this.txtElevation.Size = new System.Drawing.Size(100, 20);
            this.txtElevation.TabIndex = 3;
            this.txtElevation.Text = "0";
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Location = new System.Drawing.Point(155, 22);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(54, 13);
            this.lblElevation.TabIndex = 2;
            this.lblElevation.Text = "Elevation:";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(49, 19);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 1;
            this.txtAngle.Text = "0";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(6, 22);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(37, 13);
            this.lblAngle.TabIndex = 0;
            this.lblAngle.Text = "Angle:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudTotalHealthThirds);
            this.groupBox1.Controls.Add(this.nudHealthThirds);
            this.groupBox1.Controls.Add(this.lblTotalHealthThirds);
            this.groupBox1.Controls.Add(this.lblHealthThirds);
            this.groupBox1.Location = new System.Drawing.Point(648, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secondary Header";
            // 
            // nudTotalHealthThirds
            // 
            this.nudTotalHealthThirds.Location = new System.Drawing.Point(112, 45);
            this.nudTotalHealthThirds.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudTotalHealthThirds.Name = "nudTotalHealthThirds";
            this.nudTotalHealthThirds.Size = new System.Drawing.Size(62, 20);
            this.nudTotalHealthThirds.TabIndex = 23;
            this.nudTotalHealthThirds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudTotalHealthThirds_MouseClick);
            // 
            // nudHealthThirds
            // 
            this.nudHealthThirds.Location = new System.Drawing.Point(85, 19);
            this.nudHealthThirds.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudHealthThirds.Name = "nudHealthThirds";
            this.nudHealthThirds.Size = new System.Drawing.Size(89, 20);
            this.nudHealthThirds.TabIndex = 22;
            this.nudHealthThirds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudHealthThirds_MouseClick);
            // 
            // lblTotalHealthThirds
            // 
            this.lblTotalHealthThirds.AutoSize = true;
            this.lblTotalHealthThirds.Location = new System.Drawing.Point(6, 48);
            this.lblTotalHealthThirds.Name = "lblTotalHealthThirds";
            this.lblTotalHealthThirds.Size = new System.Drawing.Size(100, 13);
            this.lblTotalHealthThirds.TabIndex = 2;
            this.lblTotalHealthThirds.Text = "Total Health Thirds:";
            // 
            // lblHealthThirds
            // 
            this.lblHealthThirds.AutoSize = true;
            this.lblHealthThirds.Location = new System.Drawing.Point(6, 22);
            this.lblHealthThirds.Name = "lblHealthThirds";
            this.lblHealthThirds.Size = new System.Drawing.Size(73, 13);
            this.lblHealthThirds.TabIndex = 0;
            this.lblHealthThirds.Text = "Health Thirds:";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelPlatform,
            this.StatusLabelObjectivesCount,
            this.StatusLabelSphinxItems,
            this.StatusLabelMummyItems});
            this.statusBar.Location = new System.Drawing.Point(0, 769);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(840, 22);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "statusBar";
            // 
            // StatusLabelPlatform
            // 
            this.StatusLabelPlatform.Name = "StatusLabelPlatform";
            this.StatusLabelPlatform.Size = new System.Drawing.Size(475, 17);
            this.StatusLabelPlatform.Spring = true;
            this.StatusLabelPlatform.Text = "Platform: NA";
            this.StatusLabelPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabelObjectivesCount
            // 
            this.StatusLabelObjectivesCount.Name = "StatusLabelObjectivesCount";
            this.StatusLabelObjectivesCount.Size = new System.Drawing.Size(110, 17);
            this.StatusLabelObjectivesCount.Text = "Objectives Count: 0";
            // 
            // StatusLabelSphinxItems
            // 
            this.StatusLabelSphinxItems.Name = "StatusLabelSphinxItems";
            this.StatusLabelSphinxItems.Size = new System.Drawing.Size(115, 17);
            this.StatusLabelSphinxItems.Text = "Total Sphinx Items: 0";
            // 
            // StatusLabelMummyItems
            // 
            this.StatusLabelMummyItems.Name = "StatusLabelMummyItems";
            this.StatusLabelMummyItems.Size = new System.Drawing.Size(125, 17);
            this.StatusLabelMummyItems.Text = "Total Mummy Items: 0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.RestoreDirectory = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilePath.Location = new System.Drawing.Point(69, 27);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(759, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 30);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(51, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File Path:";
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 791);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabContent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FrmMain";
            this.Text = "Sphinx Savegame";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrowns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealthAnkhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScarabs)).EndInit();
            this.tabContent.ResumeLayout(false);
            this.tabPageObjectives.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabControlInventory.ResumeLayout(false);
            this.tabPageSphinxInv.ResumeLayout(false);
            this.tabPageMummyInv.ResumeLayout(false);
            this.tabPageCurrentLevel.ResumeLayout(false);
            this.tabPagePlayerData.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbxPlayerIndex.ResumeLayout(false);
            this.grbxPlayerIndex.PerformLayout();
            this.tabPageOthers.ResumeLayout(false);
            this.tabControlNotes.ResumeLayout(false);
            this.tabPageSphinx.ResumeLayout(false);
            this.grbxPropsSphinxInv.ResumeLayout(false);
            this.grbxPropsSphinxInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphinxActiveNotes)).EndInit();
            this.tabPageMummy.ResumeLayout(false);
            this.grbxPropsMummyInv.ResumeLayout(false);
            this.grbxPropsMummyInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMummyActiveNotes)).EndInit();
            this.grbxSphinx.ResumeLayout(false);
            this.grbxSphinx.PerformLayout();
            this.grbxMummy.ResumeLayout(false);
            this.grbxMummy.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalHealthThirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthThirds)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabContent;
        private System.Windows.Forms.TabPage tabPageObjectives;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageSphinxInv;
        private System.Windows.Forms.TabPage tabPageMummyInv;
        private System.Windows.Forms.TextBox txtGameTime;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.NumericUpDown numScarabs;
        private System.Windows.Forms.Label lblSacarabs;
        private System.Windows.Forms.TextBox txtbLevelTime;
        private System.Windows.Forms.Label lvlLevelTime;
        private System.Windows.Forms.NumericUpDown numLevelEntrance;
        private System.Windows.Forms.Label lvlLevelEntrance;
        private System.Windows.Forms.NumericUpDown numLevelRestart;
        private System.Windows.Forms.Label lblLevelRestart;
        private System.Windows.Forms.Label lblLevelHashcode;
        private System.Windows.Forms.TextBox txtbTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.NumericUpDown numCrowns;
        private System.Windows.Forms.Label lblCrowns;
        private System.Windows.Forms.NumericUpDown numHealthAnkhs;
        private System.Windows.Forms.Label lblHealthAnkhs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHealthThirds;
        private System.Windows.Forms.Label lblTotalHealthThirds;
        private System.Windows.Forms.NumericUpDown nudTotalHealthThirds;
        private System.Windows.Forms.NumericUpDown nudHealthThirds;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelPlatform;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelSphinxItems;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelMummyItems;
        private UserControl_BosInventory SphinxInventory;
        private UserControl_BosInventory MummyInventory;
        protected internal System.Windows.Forms.ComboBox cbxLevelHashCode;
        protected internal System.Windows.Forms.TabControl tabControlInventory;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TabPage tabPageCurrentLevel;
        private ListView_ColumnSortingClick lvwCurrentLevelTriggers;
        private System.Windows.Forms.ColumnHeader colTrigType;
        private System.Windows.Forms.ColumnHeader ColTrigSubtype;
        private System.Windows.Forms.ColumnHeader ColSavedStateValue;
        private System.Windows.Forms.ColumnHeader ColPosX;
        private System.Windows.Forms.ColumnHeader ColPosY;
        private System.Windows.Forms.ColumnHeader ColPosZ;
        private System.Windows.Forms.TabPage tabPagePlayerData;
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
        private System.Windows.Forms.GroupBox grbxPlayerIndex;
        private System.Windows.Forms.ComboBox cbxPlayerCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMummyCopy2;
        private System.Windows.Forms.CheckBox chkMummyCopy1;
        private System.Windows.Forms.TabPage tabPageOthers;
        private System.Windows.Forms.GroupBox groupBox7;
        private ListView_ColumnSortingClick lvwCameraPos;
        private System.Windows.Forms.ColumnHeader colCameraX;
        private System.Windows.Forms.ColumnHeader colCameraY;
        private System.Windows.Forms.ColumnHeader colCameraZ;
        private System.Windows.Forms.ColumnHeader colCameraW;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtElevation;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.GroupBox grbxSphinx;
        private System.Windows.Forms.ComboBox cbxProgSphinxBut3;
        private System.Windows.Forms.Label lblProgSphinxBut3;
        private System.Windows.Forms.ComboBox cbxProgSphinxBut2;
        private System.Windows.Forms.Label lblProgSphinxBut2;
        private System.Windows.Forms.ComboBox cbxProgSphinxBut1;
        private System.Windows.Forms.Label lblProgSphinxBut1;
        private System.Windows.Forms.GroupBox grbxMummy;
        private System.Windows.Forms.ComboBox cbxProgMumBut3;
        private System.Windows.Forms.Label lblProgMumBut3;
        private System.Windows.Forms.ComboBox cbxProgMumBut2;
        private System.Windows.Forms.Label lblProgMumBut2;
        private System.Windows.Forms.ComboBox cbxProgMumBut1;
        private System.Windows.Forms.Label lblProgMumBut1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.Button btnAutoLOad;
        private System.Windows.Forms.TabControl tabControlNotes;
        private System.Windows.Forms.TabPage tabPageSphinx;
        private System.Windows.Forms.TabPage tabPageMummy;
        private ListView_ColumnSortingClick lvwNotesMummyInv;
        private System.Windows.Forms.GroupBox grbxPropsSphinxInv;
        private System.Windows.Forms.NumericUpDown nudSphinxActiveNotes;
        private System.Windows.Forms.Label lblSphinxActiveNotes;
        private ListView_ColumnSortingClick lvwNotesSphinxInv;
        private System.Windows.Forms.GroupBox grbxPropsMummyInv;
        private System.Windows.Forms.NumericUpDown nudMummyActiveNotes;
        private System.Windows.Forms.Label lblMummyActiveNotes;
        private System.Windows.Forms.ColumnHeader colSphinxNoteTitle;
        private System.Windows.Forms.ColumnHeader colSphinxNoteDesc;
        private System.Windows.Forms.ColumnHeader colMummyTitle;
        private System.Windows.Forms.ColumnHeader colMummyDesc;
        protected internal System.Windows.Forms.ToolStripStatusLabel StatusLabelObjectivesCount;
        protected internal Forms.Panels.UserControl_Objectives UserControl_Objectives;
    }
}

