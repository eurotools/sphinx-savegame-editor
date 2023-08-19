
namespace SavegameEditor.Forms.Panels
{
    partial class UserControl_Objectives
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
            this.lvwObjectives = new SavegameEditor.ListView_ColumnSortingClick();
            this.colObjLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colObjHashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colObjValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuObjectives = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_AddObjectives = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DeleteObjective = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ModifyObjectives = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuObjectives.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwObjectives
            // 
            this.lvwObjectives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colObjLabel,
            this.colObjHashCode,
            this.colObjValue});
            this.lvwObjectives.ContextMenuStrip = this.ContextMenuObjectives;
            this.lvwObjectives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwObjectives.FullRowSelect = true;
            this.lvwObjectives.HideSelection = false;
            this.lvwObjectives.Location = new System.Drawing.Point(0, 0);
            this.lvwObjectives.Name = "lvwObjectives";
            this.lvwObjectives.Size = new System.Drawing.Size(783, 404);
            this.lvwObjectives.TabIndex = 1;
            this.lvwObjectives.UseCompatibleStateImageBehavior = false;
            this.lvwObjectives.View = System.Windows.Forms.View.Details;
            this.lvwObjectives.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwObjectives_MouseDoubleClick);
            // 
            // colObjLabel
            // 
            this.colObjLabel.Text = "Label";
            this.colObjLabel.Width = 300;
            // 
            // colObjHashCode
            // 
            this.colObjHashCode.Text = "HashCode";
            this.colObjHashCode.Width = 90;
            // 
            // colObjValue
            // 
            this.colObjValue.Text = "Value";
            this.colObjValue.Width = 90;
            // 
            // ContextMenuObjectives
            // 
            this.ContextMenuObjectives.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AddObjectives,
            this.MenuItem_DeleteObjective,
            this.MenuItem_ModifyObjectives});
            this.ContextMenuObjectives.Name = "contextMenuStrip1";
            this.ContextMenuObjectives.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenuObjectives.Size = new System.Drawing.Size(144, 70);
            // 
            // MenuItem_AddObjectives
            // 
            this.MenuItem_AddObjectives.Name = "MenuItem_AddObjectives";
            this.MenuItem_AddObjectives.Size = new System.Drawing.Size(143, 22);
            this.MenuItem_AddObjectives.Text = "Add";
            this.MenuItem_AddObjectives.Click += new System.EventHandler(this.MenuItem_AddObjectives_Click);
            // 
            // MenuItem_DeleteObjective
            // 
            this.MenuItem_DeleteObjective.Name = "MenuItem_DeleteObjective";
            this.MenuItem_DeleteObjective.Size = new System.Drawing.Size(143, 22);
            this.MenuItem_DeleteObjective.Text = "Delete";
            this.MenuItem_DeleteObjective.Click += new System.EventHandler(this.MenuItem_DeleteObjective_Click);
            // 
            // MenuItem_ModifyObjectives
            // 
            this.MenuItem_ModifyObjectives.Name = "MenuItem_ModifyObjectives";
            this.MenuItem_ModifyObjectives.Size = new System.Drawing.Size(143, 22);
            this.MenuItem_ModifyObjectives.Text = "Modify Value";
            this.MenuItem_ModifyObjectives.Click += new System.EventHandler(this.MenuItem_ModifyObjectives_Click);
            // 
            // UserControl_Objectives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwObjectives);
            this.Name = "UserControl_Objectives";
            this.Size = new System.Drawing.Size(783, 404);
            this.ContextMenuObjectives.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView_ColumnSortingClick lvwObjectives;
        private System.Windows.Forms.ColumnHeader colObjLabel;
        private System.Windows.Forms.ColumnHeader colObjHashCode;
        private System.Windows.Forms.ColumnHeader colObjValue;
        private System.Windows.Forms.ContextMenuStrip ContextMenuObjectives;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AddObjectives;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_DeleteObjective;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ModifyObjectives;
    }
}
