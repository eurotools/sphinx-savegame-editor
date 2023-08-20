
namespace SavegameEditor.Forms.Panels
{
    partial class UserControl_LevelTriggers
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
            this.ContextMenu_Options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwCurrentLevelTriggers = new SavegameEditor.ListView_ColumnSortingClick();
            this.colTrigType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTrigSubtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSavedStateValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenu_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenu_Options
            // 
            this.ContextMenu_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Add,
            this.MenuItem_Modify,
            this.MenuItem_Remove});
            this.ContextMenu_Options.Name = "ContextMenu_Options";
            this.ContextMenu_Options.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenu_Options.Size = new System.Drawing.Size(118, 70);
            // 
            // MenuItem_Add
            // 
            this.MenuItem_Add.Name = "MenuItem_Add";
            this.MenuItem_Add.Size = new System.Drawing.Size(117, 22);
            this.MenuItem_Add.Text = "Add";
            this.MenuItem_Add.Click += new System.EventHandler(this.MenuItem_Add_Click);
            // 
            // MenuItem_Modify
            // 
            this.MenuItem_Modify.Name = "MenuItem_Modify";
            this.MenuItem_Modify.Size = new System.Drawing.Size(117, 22);
            this.MenuItem_Modify.Text = "Modify";
            this.MenuItem_Modify.Click += new System.EventHandler(this.MenuItem_Modify_Click);
            // 
            // MenuItem_Remove
            // 
            this.MenuItem_Remove.Name = "MenuItem_Remove";
            this.MenuItem_Remove.Size = new System.Drawing.Size(117, 22);
            this.MenuItem_Remove.Text = "Remove";
            this.MenuItem_Remove.Click += new System.EventHandler(this.MenuItem_Remove_Click);
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
            this.lvwCurrentLevelTriggers.ContextMenuStrip = this.ContextMenu_Options;
            this.lvwCurrentLevelTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCurrentLevelTriggers.FullRowSelect = true;
            this.lvwCurrentLevelTriggers.HideSelection = false;
            this.lvwCurrentLevelTriggers.Location = new System.Drawing.Point(0, 0);
            this.lvwCurrentLevelTriggers.Name = "lvwCurrentLevelTriggers";
            this.lvwCurrentLevelTriggers.Size = new System.Drawing.Size(667, 426);
            this.lvwCurrentLevelTriggers.TabIndex = 1;
            this.lvwCurrentLevelTriggers.UseCompatibleStateImageBehavior = false;
            this.lvwCurrentLevelTriggers.View = System.Windows.Forms.View.Details;
            this.lvwCurrentLevelTriggers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwCurrentLevelTriggers_MouseDoubleClick);
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
            // UserControl_LevelTriggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwCurrentLevelTriggers);
            this.Name = "UserControl_LevelTriggers";
            this.Size = new System.Drawing.Size(667, 426);
            this.ContextMenu_Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView_ColumnSortingClick lvwCurrentLevelTriggers;
        private System.Windows.Forms.ColumnHeader colTrigType;
        private System.Windows.Forms.ColumnHeader ColTrigSubtype;
        private System.Windows.Forms.ColumnHeader ColSavedStateValue;
        private System.Windows.Forms.ColumnHeader ColPosX;
        private System.Windows.Forms.ColumnHeader ColPosY;
        private System.Windows.Forms.ColumnHeader ColPosZ;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Options;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Modify;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Remove;
    }
}
