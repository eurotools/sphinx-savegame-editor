
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
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettings_SetHashCodes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp_About = new System.Windows.Forms.ToolStripMenuItem();
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
            this.UserControl_LevelTriggers = new SavegameEditor.Forms.Panels.UserControl_LevelTriggers();
            this.tabPagePlayerData = new System.Windows.Forms.TabPage();
            this.userControl_PlayerData1 = new SavegameEditor.Forms.Panels.UserControl_PlayerData();
            this.tabPageOthers = new System.Windows.Forms.TabPage();
            this.UserControl_OtherData = new SavegameEditor.Forms.Panels.UserControl_OtherData();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTotalHealthThirds = new System.Windows.Forms.NumericUpDown();
            this.nudHealthThirds = new System.Windows.Forms.NumericUpDown();
            this.lblTotalHealthThirds = new System.Windows.Forms.Label();
            this.lblHealthThirds = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabelPlatform = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelObjectivesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelSphinxItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelSphinxItemsValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelMummyItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelMummyItemsValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogHashCodes = new System.Windows.Forms.OpenFileDialog();
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
            this.tabPageOthers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalHealthThirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthThirds)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_Settings,
            this.MenuItem_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(840, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpenFile,
            this.MenuItem_Save,
            this.toolStripSeparator1,
            this.MenuItem_Exit});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItem_File.Text = "File";
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
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(103, 22);
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItem_Settings
            // 
            this.MenuItem_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettings_SetHashCodes});
            this.MenuItem_Settings.Name = "MenuItem_Settings";
            this.MenuItem_Settings.Size = new System.Drawing.Size(61, 20);
            this.MenuItem_Settings.Text = "Settings";
            // 
            // MenuItemSettings_SetHashCodes
            // 
            this.MenuItemSettings_SetHashCodes.Name = "MenuItemSettings_SetHashCodes";
            this.MenuItemSettings_SetHashCodes.Size = new System.Drawing.Size(178, 22);
            this.MenuItemSettings_SetHashCodes.Text = "Set Hashcodes Path";
            this.MenuItemSettings_SetHashCodes.Click += new System.EventHandler(this.MenuItemSettings_SetHashCodes_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelp_About});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuItem_Help.Text = "Help";
            // 
            // MenuItemHelp_About
            // 
            this.MenuItemHelp_About.Name = "MenuItemHelp_About";
            this.MenuItemHelp_About.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHelp_About.Text = "About";
            this.MenuItemHelp_About.Click += new System.EventHandler(this.MenuItemHelp_About_Click);
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
            this.btnAutoLOad.Visible = false;
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
            this.Button_Test.Visible = false;
            this.Button_Test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // txtbLevelTime
            // 
            this.txtbLevelTime.Location = new System.Drawing.Point(354, 73);
            this.txtbLevelTime.Name = "txtbLevelTime";
            this.txtbLevelTime.Size = new System.Drawing.Size(93, 20);
            this.txtbLevelTime.TabIndex = 21;
            this.txtbLevelTime.Text = "0";
            this.txtbLevelTime.Validated += new System.EventHandler(this.TxtbLevelTime_Validated);
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
            this.txtGameTime.Validated += new System.EventHandler(this.TxtGameTime_Validated);
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
            this.tabPageCurrentLevel.Controls.Add(this.UserControl_LevelTriggers);
            this.tabPageCurrentLevel.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurrentLevel.Name = "tabPageCurrentLevel";
            this.tabPageCurrentLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentLevel.Size = new System.Drawing.Size(808, 581);
            this.tabPageCurrentLevel.TabIndex = 2;
            this.tabPageCurrentLevel.Text = "Current Level";
            // 
            // UserControl_LevelTriggers
            // 
            this.UserControl_LevelTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_LevelTriggers.Location = new System.Drawing.Point(3, 3);
            this.UserControl_LevelTriggers.Name = "UserControl_LevelTriggers";
            this.UserControl_LevelTriggers.Size = new System.Drawing.Size(802, 575);
            this.UserControl_LevelTriggers.TabIndex = 0;
            // 
            // tabPagePlayerData
            // 
            this.tabPagePlayerData.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePlayerData.Controls.Add(this.userControl_PlayerData1);
            this.tabPagePlayerData.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayerData.Name = "tabPagePlayerData";
            this.tabPagePlayerData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayerData.Size = new System.Drawing.Size(808, 581);
            this.tabPagePlayerData.TabIndex = 3;
            this.tabPagePlayerData.Text = "Player Data";
            // 
            // userControl_PlayerData1
            // 
            this.userControl_PlayerData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_PlayerData1.Location = new System.Drawing.Point(3, 3);
            this.userControl_PlayerData1.Name = "userControl_PlayerData1";
            this.userControl_PlayerData1.Size = new System.Drawing.Size(802, 575);
            this.userControl_PlayerData1.TabIndex = 0;
            // 
            // tabPageOthers
            // 
            this.tabPageOthers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageOthers.Controls.Add(this.UserControl_OtherData);
            this.tabPageOthers.Location = new System.Drawing.Point(4, 22);
            this.tabPageOthers.Name = "tabPageOthers";
            this.tabPageOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOthers.Size = new System.Drawing.Size(808, 581);
            this.tabPageOthers.TabIndex = 4;
            this.tabPageOthers.Text = "Others";
            // 
            // UserControl_OtherData
            // 
            this.UserControl_OtherData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_OtherData.Location = new System.Drawing.Point(3, 3);
            this.UserControl_OtherData.Name = "UserControl_OtherData";
            this.UserControl_OtherData.Size = new System.Drawing.Size(802, 575);
            this.UserControl_OtherData.TabIndex = 0;
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
            this.StatusLabelSphinxItemsValue,
            this.StatusLabelMummyItems,
            this.StatusLabelMummyItemsValue});
            this.statusBar.Location = new System.Drawing.Point(0, 769);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(840, 22);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "statusBar";
            // 
            // StatusLabelPlatform
            // 
            this.StatusLabelPlatform.Name = "StatusLabelPlatform";
            this.StatusLabelPlatform.Size = new System.Drawing.Size(467, 17);
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
            this.StatusLabelSphinxItems.Size = new System.Drawing.Size(106, 17);
            this.StatusLabelSphinxItems.Text = "Total Sphinx Items:";
            // 
            // StatusLabelSphinxItemsValue
            // 
            this.StatusLabelSphinxItemsValue.Name = "StatusLabelSphinxItemsValue";
            this.StatusLabelSphinxItemsValue.Size = new System.Drawing.Size(13, 17);
            this.StatusLabelSphinxItemsValue.Text = "0";
            this.StatusLabelSphinxItemsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabelMummyItems
            // 
            this.StatusLabelMummyItems.Name = "StatusLabelMummyItems";
            this.StatusLabelMummyItems.Size = new System.Drawing.Size(116, 17);
            this.StatusLabelMummyItems.Text = "Total Mummy Items:";
            // 
            // StatusLabelMummyItemsValue
            // 
            this.StatusLabelMummyItemsValue.Name = "StatusLabelMummyItemsValue";
            this.StatusLabelMummyItemsValue.Size = new System.Drawing.Size(13, 17);
            this.StatusLabelMummyItemsValue.Text = "0";
            this.StatusLabelMummyItemsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // openFileDialogHashCodes
            // 
            this.openFileDialogHashCodes.Filter = "Header Files (*.h)|*.h|All Files (*.*)|*.*";
            this.openFileDialogHashCodes.RestoreDirectory = true;
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
            this.tabPageOthers.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp_About;
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
        private UserControl_BosInventory SphinxInventory;
        private UserControl_BosInventory MummyInventory;
        protected internal System.Windows.Forms.ComboBox cbxLevelHashCode;
        protected internal System.Windows.Forms.TabControl tabControlInventory;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TabPage tabPageCurrentLevel;
        private System.Windows.Forms.TabPage tabPagePlayerData;
        private System.Windows.Forms.TabPage tabPageOthers;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.Button btnAutoLOad;
        protected internal System.Windows.Forms.ToolStripStatusLabel StatusLabelObjectivesCount;
        protected internal Forms.Panels.UserControl_Objectives UserControl_Objectives;
        private Forms.Panels.UserControl_LevelTriggers UserControl_LevelTriggers;
        private Forms.Panels.UserControl_PlayerData userControl_PlayerData1;
        private Forms.Panels.UserControl_OtherData UserControl_OtherData;
        protected internal System.Windows.Forms.ToolStripStatusLabel StatusLabelSphinxItemsValue;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelMummyItems;
        protected internal System.Windows.Forms.ToolStripStatusLabel StatusLabelMummyItemsValue;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelSphinxItems;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Settings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings_SetHashCodes;
        private System.Windows.Forms.OpenFileDialog openFileDialogHashCodes;
    }
}

