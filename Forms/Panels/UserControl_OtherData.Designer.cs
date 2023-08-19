
namespace SavegameEditor.Forms.Panels
{
    partial class UserControl_OtherData
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
            this.SuspendLayout();
            // 
            // tabControlNotes
            // 
            this.tabControlNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlNotes.Controls.Add(this.tabPageSphinx);
            this.tabControlNotes.Controls.Add(this.tabPageMummy);
            this.tabControlNotes.Location = new System.Drawing.Point(3, 312);
            this.tabControlNotes.Name = "tabControlNotes";
            this.tabControlNotes.SelectedIndex = 0;
            this.tabControlNotes.Size = new System.Drawing.Size(797, 287);
            this.tabControlNotes.TabIndex = 13;
            // 
            // tabPageSphinx
            // 
            this.tabPageSphinx.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSphinx.Controls.Add(this.grbxPropsSphinxInv);
            this.tabPageSphinx.Controls.Add(this.lvwNotesSphinxInv);
            this.tabPageSphinx.Location = new System.Drawing.Point(4, 22);
            this.tabPageSphinx.Name = "tabPageSphinx";
            this.tabPageSphinx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSphinx.Size = new System.Drawing.Size(789, 261);
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
            this.grbxPropsSphinxInv.Size = new System.Drawing.Size(777, 50);
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
            this.lvwNotesSphinxInv.Size = new System.Drawing.Size(777, 193);
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
            this.tabPageMummy.Size = new System.Drawing.Size(789, 261);
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
            this.grbxPropsMummyInv.Size = new System.Drawing.Size(777, 50);
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
            this.lvwNotesMummyInv.Size = new System.Drawing.Size(777, 193);
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
            this.grbxSphinx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut3);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut3);
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut2);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut2);
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut1);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut1);
            this.grbxSphinx.Location = new System.Drawing.Point(3, 248);
            this.grbxSphinx.Name = "grbxSphinx";
            this.grbxSphinx.Size = new System.Drawing.Size(797, 58);
            this.grbxSphinx.TabIndex = 12;
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
            this.grbxMummy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxMummy.Controls.Add(this.cbxProgMumBut3);
            this.grbxMummy.Controls.Add(this.lblProgMumBut3);
            this.grbxMummy.Controls.Add(this.cbxProgMumBut2);
            this.grbxMummy.Controls.Add(this.lblProgMumBut2);
            this.grbxMummy.Controls.Add(this.cbxProgMumBut1);
            this.grbxMummy.Controls.Add(this.lblProgMumBut1);
            this.grbxMummy.Location = new System.Drawing.Point(3, 181);
            this.grbxMummy.Name = "grbxMummy";
            this.grbxMummy.Size = new System.Drawing.Size(797, 61);
            this.grbxMummy.TabIndex = 11;
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
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(797, 172);
            this.groupBox7.TabIndex = 10;
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
            this.lvwCameraPos.Size = new System.Drawing.Size(785, 92);
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
            // UserControl_OtherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlNotes);
            this.Controls.Add(this.grbxSphinx);
            this.Controls.Add(this.grbxMummy);
            this.Controls.Add(this.groupBox7);
            this.Name = "UserControl_OtherData";
            this.Size = new System.Drawing.Size(803, 602);
            this.Load += new System.EventHandler(this.UserControl_OtherData_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNotes;
        private System.Windows.Forms.TabPage tabPageSphinx;
        private System.Windows.Forms.GroupBox grbxPropsSphinxInv;
        private System.Windows.Forms.NumericUpDown nudSphinxActiveNotes;
        private System.Windows.Forms.Label lblSphinxActiveNotes;
        private ListView_ColumnSortingClick lvwNotesSphinxInv;
        private System.Windows.Forms.ColumnHeader colSphinxNoteTitle;
        private System.Windows.Forms.ColumnHeader colSphinxNoteDesc;
        private System.Windows.Forms.TabPage tabPageMummy;
        private System.Windows.Forms.GroupBox grbxPropsMummyInv;
        private System.Windows.Forms.NumericUpDown nudMummyActiveNotes;
        private System.Windows.Forms.Label lblMummyActiveNotes;
        private ListView_ColumnSortingClick lvwNotesMummyInv;
        private System.Windows.Forms.ColumnHeader colMummyTitle;
        private System.Windows.Forms.ColumnHeader colMummyDesc;
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
    }
}
