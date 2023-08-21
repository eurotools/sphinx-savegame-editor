
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
            this.components = new System.ComponentModel.Container();
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
            this.cbxProgSphinxBut4 = new System.Windows.Forms.ComboBox();
            this.lblProgSphinxBut4 = new System.Windows.Forms.Label();
            this.cbxProgSphinxBut3 = new System.Windows.Forms.ComboBox();
            this.lblProgSphinxBut3 = new System.Windows.Forms.Label();
            this.cbxProgSphinxBut2 = new System.Windows.Forms.ComboBox();
            this.lblProgSphinxBut2 = new System.Windows.Forms.Label();
            this.cbxProgSphinxBut1 = new System.Windows.Forms.ComboBox();
            this.lblProgSphinxBut1 = new System.Windows.Forms.Label();
            this.grbxMummy = new System.Windows.Forms.GroupBox();
            this.cbxProgMumBut4 = new System.Windows.Forms.ComboBox();
            this.lblProgMumBut4 = new System.Windows.Forms.Label();
            this.cbxProgMumBut3 = new System.Windows.Forms.ComboBox();
            this.lblProgMumBut3 = new System.Windows.Forms.Label();
            this.cbxProgMumBut2 = new System.Windows.Forms.ComboBox();
            this.lblProgMumBut2 = new System.Windows.Forms.Label();
            this.cbxProgMumBut1 = new System.Windows.Forms.ComboBox();
            this.lblProgMumBut1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudW = new System.Windows.Forms.NumericUpDown();
            this.lblW = new System.Windows.Forms.Label();
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            this.lblZ = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.nudCamDistance = new System.Windows.Forms.NumericUpDown();
            this.nudCamElevation = new System.Windows.Forms.NumericUpDown();
            this.nudCamAngle = new System.Windows.Forms.NumericUpDown();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.ContextMenu_InvNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Notes_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Notes_Remove = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamElevation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamAngle)).BeginInit();
            this.ContextMenu_InvNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlNotes
            // 
            this.tabControlNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlNotes.Controls.Add(this.tabPageSphinx);
            this.tabControlNotes.Controls.Add(this.tabPageMummy);
            this.tabControlNotes.Location = new System.Drawing.Point(3, 280);
            this.tabControlNotes.Name = "tabControlNotes";
            this.tabControlNotes.SelectedIndex = 0;
            this.tabControlNotes.Size = new System.Drawing.Size(797, 319);
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
            this.tabPageSphinx.Size = new System.Drawing.Size(789, 293);
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
            this.lvwNotesSphinxInv.ContextMenuStrip = this.ContextMenu_InvNotes;
            this.lvwNotesSphinxInv.FullRowSelect = true;
            this.lvwNotesSphinxInv.HideSelection = false;
            this.lvwNotesSphinxInv.Location = new System.Drawing.Point(6, 62);
            this.lvwNotesSphinxInv.Name = "lvwNotesSphinxInv";
            this.lvwNotesSphinxInv.Size = new System.Drawing.Size(777, 225);
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
            this.tabPageMummy.Size = new System.Drawing.Size(789, 293);
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
            this.lvwNotesMummyInv.ContextMenuStrip = this.ContextMenu_InvNotes;
            this.lvwNotesMummyInv.FullRowSelect = true;
            this.lvwNotesMummyInv.HideSelection = false;
            this.lvwNotesMummyInv.Location = new System.Drawing.Point(6, 62);
            this.lvwNotesMummyInv.Name = "lvwNotesMummyInv";
            this.lvwNotesMummyInv.Size = new System.Drawing.Size(777, 225);
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
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut4);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut4);
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut3);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut3);
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut2);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut2);
            this.grbxSphinx.Controls.Add(this.cbxProgSphinxBut1);
            this.grbxSphinx.Controls.Add(this.lblProgSphinxBut1);
            this.grbxSphinx.Location = new System.Drawing.Point(3, 197);
            this.grbxSphinx.Name = "grbxSphinx";
            this.grbxSphinx.Size = new System.Drawing.Size(797, 77);
            this.grbxSphinx.TabIndex = 12;
            this.grbxSphinx.TabStop = false;
            this.grbxSphinx.Text = "Sphinx Programmable Buttons";
            // 
            // cbxProgSphinxBut4
            // 
            this.cbxProgSphinxBut4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgSphinxBut4.FormattingEnabled = true;
            this.cbxProgSphinxBut4.Location = new System.Drawing.Point(59, 46);
            this.cbxProgSphinxBut4.Name = "cbxProgSphinxBut4";
            this.cbxProgSphinxBut4.Size = new System.Drawing.Size(200, 21);
            this.cbxProgSphinxBut4.TabIndex = 7;
            this.cbxProgSphinxBut4.SelectionChangeCommitted += new System.EventHandler(this.CbxProgSphinxBut4_SelectionChangeCommitted);
            // 
            // lblProgSphinxBut4
            // 
            this.lblProgSphinxBut4.AutoSize = true;
            this.lblProgSphinxBut4.Location = new System.Drawing.Point(6, 49);
            this.lblProgSphinxBut4.Name = "lblProgSphinxBut4";
            this.lblProgSphinxBut4.Size = new System.Drawing.Size(47, 13);
            this.lblProgSphinxBut4.TabIndex = 6;
            this.lblProgSphinxBut4.Text = "Button4:";
            // 
            // cbxProgSphinxBut3
            // 
            this.cbxProgSphinxBut3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgSphinxBut3.FormattingEnabled = true;
            this.cbxProgSphinxBut3.Location = new System.Drawing.Point(577, 19);
            this.cbxProgSphinxBut3.Name = "cbxProgSphinxBut3";
            this.cbxProgSphinxBut3.Size = new System.Drawing.Size(200, 21);
            this.cbxProgSphinxBut3.TabIndex = 5;
            this.cbxProgSphinxBut3.SelectionChangeCommitted += new System.EventHandler(this.CbxProgSphinxBut3_SelectionChangeCommitted);
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
            this.cbxProgSphinxBut2.SelectionChangeCommitted += new System.EventHandler(this.CbxProgSphinxBut2_SelectionChangeCommitted);
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
            this.cbxProgSphinxBut1.SelectionChangeCommitted += new System.EventHandler(this.CbxProgSphinxBut1_SelectionChangeCommitted);
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
            this.grbxMummy.Controls.Add(this.cbxProgMumBut4);
            this.grbxMummy.Controls.Add(this.lblProgMumBut4);
            this.grbxMummy.Controls.Add(this.cbxProgMumBut3);
            this.grbxMummy.Controls.Add(this.lblProgMumBut3);
            this.grbxMummy.Controls.Add(this.cbxProgMumBut2);
            this.grbxMummy.Controls.Add(this.lblProgMumBut2);
            this.grbxMummy.Controls.Add(this.cbxProgMumBut1);
            this.grbxMummy.Controls.Add(this.lblProgMumBut1);
            this.grbxMummy.Location = new System.Drawing.Point(3, 114);
            this.grbxMummy.Name = "grbxMummy";
            this.grbxMummy.Size = new System.Drawing.Size(797, 77);
            this.grbxMummy.TabIndex = 11;
            this.grbxMummy.TabStop = false;
            this.grbxMummy.Text = "Mummy Programmable Buttons";
            // 
            // cbxProgMumBut4
            // 
            this.cbxProgMumBut4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgMumBut4.FormattingEnabled = true;
            this.cbxProgMumBut4.Location = new System.Drawing.Point(59, 46);
            this.cbxProgMumBut4.Name = "cbxProgMumBut4";
            this.cbxProgMumBut4.Size = new System.Drawing.Size(200, 21);
            this.cbxProgMumBut4.TabIndex = 7;
            this.cbxProgMumBut4.SelectionChangeCommitted += new System.EventHandler(this.CbxProgMumBut4_SelectionChangeCommitted);
            // 
            // lblProgMumBut4
            // 
            this.lblProgMumBut4.AutoSize = true;
            this.lblProgMumBut4.Location = new System.Drawing.Point(6, 49);
            this.lblProgMumBut4.Name = "lblProgMumBut4";
            this.lblProgMumBut4.Size = new System.Drawing.Size(47, 13);
            this.lblProgMumBut4.TabIndex = 6;
            this.lblProgMumBut4.Text = "Button4:";
            // 
            // cbxProgMumBut3
            // 
            this.cbxProgMumBut3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgMumBut3.FormattingEnabled = true;
            this.cbxProgMumBut3.Location = new System.Drawing.Point(577, 19);
            this.cbxProgMumBut3.Name = "cbxProgMumBut3";
            this.cbxProgMumBut3.Size = new System.Drawing.Size(200, 21);
            this.cbxProgMumBut3.TabIndex = 5;
            this.cbxProgMumBut3.SelectionChangeCommitted += new System.EventHandler(this.CbxProgMumBut3_SelectionChangeCommitted);
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
            this.cbxProgMumBut2.SelectionChangeCommitted += new System.EventHandler(this.CbxProgMumBut2_SelectionChangeCommitted);
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
            this.cbxProgMumBut1.SelectionChangeCommitted += new System.EventHandler(this.CbxProgMumBut1_SelectionChangeCommitted);
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
            this.groupBox7.Controls.Add(this.nudW);
            this.groupBox7.Controls.Add(this.lblW);
            this.groupBox7.Controls.Add(this.nudZ);
            this.groupBox7.Controls.Add(this.lblZ);
            this.groupBox7.Controls.Add(this.nudY);
            this.groupBox7.Controls.Add(this.lblY);
            this.groupBox7.Controls.Add(this.nudX);
            this.groupBox7.Controls.Add(this.lblX);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(797, 105);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Camera";
            // 
            // nudW
            // 
            this.nudW.DecimalPlaces = 8;
            this.nudW.Location = new System.Drawing.Point(480, 74);
            this.nudW.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudW.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudW.Name = "nudW";
            this.nudW.Size = new System.Drawing.Size(120, 20);
            this.nudW.TabIndex = 15;
            this.nudW.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudW_MouseClick);
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(453, 76);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(21, 13);
            this.lblW.TabIndex = 14;
            this.lblW.Text = "W:";
            // 
            // nudZ
            // 
            this.nudZ.DecimalPlaces = 8;
            this.nudZ.Location = new System.Drawing.Point(327, 74);
            this.nudZ.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudZ.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(120, 20);
            this.nudZ.TabIndex = 13;
            this.nudZ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudZ_MouseClick);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(304, 76);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 13);
            this.lblZ.TabIndex = 12;
            this.lblZ.Text = "Z:";
            // 
            // nudY
            // 
            this.nudY.DecimalPlaces = 8;
            this.nudY.Location = new System.Drawing.Point(178, 74);
            this.nudY.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(120, 20);
            this.nudY.TabIndex = 11;
            this.nudY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudY_MouseClick);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(155, 76);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 10;
            this.lblY.Text = "Y:";
            // 
            // nudX
            // 
            this.nudX.DecimalPlaces = 8;
            this.nudX.Location = new System.Drawing.Point(29, 74);
            this.nudX.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 20);
            this.nudX.TabIndex = 9;
            this.nudX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudX_MouseClick);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 76);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X:";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.nudCamDistance);
            this.groupBox8.Controls.Add(this.nudCamElevation);
            this.groupBox8.Controls.Add(this.nudCamAngle);
            this.groupBox8.Controls.Add(this.lblDistance);
            this.groupBox8.Controls.Add(this.lblElevation);
            this.groupBox8.Controls.Add(this.lblAngle);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(784, 49);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Settings";
            // 
            // nudCamDistance
            // 
            this.nudCamDistance.DecimalPlaces = 8;
            this.nudCamDistance.Location = new System.Drawing.Point(379, 20);
            this.nudCamDistance.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudCamDistance.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudCamDistance.Name = "nudCamDistance";
            this.nudCamDistance.Size = new System.Drawing.Size(100, 20);
            this.nudCamDistance.TabIndex = 18;
            this.nudCamDistance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudCamDistance_MouseClick);
            // 
            // nudCamElevation
            // 
            this.nudCamElevation.DecimalPlaces = 8;
            this.nudCamElevation.Location = new System.Drawing.Point(215, 20);
            this.nudCamElevation.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudCamElevation.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudCamElevation.Name = "nudCamElevation";
            this.nudCamElevation.Size = new System.Drawing.Size(100, 20);
            this.nudCamElevation.TabIndex = 17;
            this.nudCamElevation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudCamElevation_MouseClick);
            // 
            // nudCamAngle
            // 
            this.nudCamAngle.DecimalPlaces = 8;
            this.nudCamAngle.Location = new System.Drawing.Point(49, 20);
            this.nudCamAngle.Maximum = new decimal(new int[] {
            -892143830,
            0,
            0,
            0});
            this.nudCamAngle.Minimum = new decimal(new int[] {
            1175494351,
            0,
            0,
            -2147483648});
            this.nudCamAngle.Name = "nudCamAngle";
            this.nudCamAngle.Size = new System.Drawing.Size(100, 20);
            this.nudCamAngle.TabIndex = 16;
            this.nudCamAngle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NudCamAngle_MouseClick);
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
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Location = new System.Drawing.Point(155, 22);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(54, 13);
            this.lblElevation.TabIndex = 2;
            this.lblElevation.Text = "Elevation:";
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
            // ContextMenu_InvNotes
            // 
            this.ContextMenu_InvNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Notes_Add,
            this.MenuItem_Notes_Remove});
            this.ContextMenu_InvNotes.Name = "ContextMenu_InvNotes";
            this.ContextMenu_InvNotes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenu_InvNotes.Size = new System.Drawing.Size(181, 70);
            // 
            // MenuItem_Notes_Add
            // 
            this.MenuItem_Notes_Add.Name = "MenuItem_Notes_Add";
            this.MenuItem_Notes_Add.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Notes_Add.Text = "Add";
            this.MenuItem_Notes_Add.Click += new System.EventHandler(this.MenuItem_Notes_Add_Click);
            // 
            // MenuItem_Notes_Remove
            // 
            this.MenuItem_Notes_Remove.Name = "MenuItem_Notes_Remove";
            this.MenuItem_Notes_Remove.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Notes_Remove.Text = "Remove";
            this.MenuItem_Notes_Remove.Click += new System.EventHandler(this.MenuItem_Notes_Remove_Click);
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
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamElevation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamAngle)).EndInit();
            this.ContextMenu_InvNotes.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.ComboBox cbxProgSphinxBut4;
        private System.Windows.Forms.Label lblProgSphinxBut4;
        private System.Windows.Forms.ComboBox cbxProgMumBut4;
        private System.Windows.Forms.Label lblProgMumBut4;
        protected internal System.Windows.Forms.NumericUpDown nudW;
        private System.Windows.Forms.Label lblW;
        protected internal System.Windows.Forms.NumericUpDown nudZ;
        private System.Windows.Forms.Label lblZ;
        protected internal System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label lblY;
        protected internal System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label lblX;
        protected internal System.Windows.Forms.NumericUpDown nudCamDistance;
        protected internal System.Windows.Forms.NumericUpDown nudCamElevation;
        protected internal System.Windows.Forms.NumericUpDown nudCamAngle;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_InvNotes;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Notes_Add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Notes_Remove;
    }
}
