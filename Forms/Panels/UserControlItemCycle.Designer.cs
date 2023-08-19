
namespace SavegameEditor
{
    partial class UserControlItemCycle
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
            this.grbxSettings = new System.Windows.Forms.GroupBox();
            this.nudSelectedItem = new System.Windows.Forms.NumericUpDown();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lvwCycle = new SavegameEditor.ListView_ColumnSortingClick();
            this.colHashCodeLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrentCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrentMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_AddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ModifyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectedItem)).BeginInit();
            this.ContextMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxSettings
            // 
            this.grbxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxSettings.Controls.Add(this.nudSelectedItem);
            this.grbxSettings.Controls.Add(this.lblSelectedItem);
            this.grbxSettings.Location = new System.Drawing.Point(3, 3);
            this.grbxSettings.Name = "grbxSettings";
            this.grbxSettings.Size = new System.Drawing.Size(546, 50);
            this.grbxSettings.TabIndex = 0;
            this.grbxSettings.TabStop = false;
            this.grbxSettings.Text = "Cycle Settings";
            // 
            // nudSelectedItem
            // 
            this.nudSelectedItem.Location = new System.Drawing.Point(87, 19);
            this.nudSelectedItem.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudSelectedItem.Name = "nudSelectedItem";
            this.nudSelectedItem.Size = new System.Drawing.Size(116, 20);
            this.nudSelectedItem.TabIndex = 2;
            this.nudSelectedItem.Click += new System.EventHandler(this.NudSelectedItem_Click);
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(6, 21);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(75, 13);
            this.lblSelectedItem.TabIndex = 1;
            this.lblSelectedItem.Text = "Selected Item:";
            // 
            // lvwCycle
            // 
            this.lvwCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCycle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHashCodeLabel,
            this.colHashCode,
            this.colCurrentCount,
            this.colCurrentMax,
            this.ColFlags});
            this.lvwCycle.ContextMenuStrip = this.ContextMenuOptions;
            this.lvwCycle.FullRowSelect = true;
            this.lvwCycle.HideSelection = false;
            this.lvwCycle.Location = new System.Drawing.Point(3, 59);
            this.lvwCycle.Name = "lvwCycle";
            this.lvwCycle.Size = new System.Drawing.Size(546, 408);
            this.lvwCycle.TabIndex = 1;
            this.lvwCycle.UseCompatibleStateImageBehavior = false;
            this.lvwCycle.View = System.Windows.Forms.View.Details;
            this.lvwCycle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwCycle_MouseDoubleClick);
            // 
            // colHashCodeLabel
            // 
            this.colHashCodeLabel.Text = "Label";
            this.colHashCodeLabel.Width = 200;
            // 
            // colHashCode
            // 
            this.colHashCode.Text = "HashCode";
            this.colHashCode.Width = 90;
            // 
            // colCurrentCount
            // 
            this.colCurrentCount.Text = "Current Count";
            this.colCurrentCount.Width = 80;
            // 
            // colCurrentMax
            // 
            this.colCurrentMax.Text = "Max Count";
            this.colCurrentMax.Width = 80;
            // 
            // ColFlags
            // 
            this.ColFlags.Text = "Flags";
            this.ColFlags.Width = 80;
            // 
            // ContextMenuOptions
            // 
            this.ContextMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AddItem,
            this.MenuItem_RemoveItem,
            this.MenuItem_ModifyItem});
            this.ContextMenuOptions.Name = "ContextMenuOptions";
            this.ContextMenuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenuOptions.Size = new System.Drawing.Size(181, 92);
            // 
            // MenuItem_AddItem
            // 
            this.MenuItem_AddItem.Name = "MenuItem_AddItem";
            this.MenuItem_AddItem.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_AddItem.Text = "Add";
            this.MenuItem_AddItem.Click += new System.EventHandler(this.MenuItem_AddItem_Click);
            // 
            // MenuItem_RemoveItem
            // 
            this.MenuItem_RemoveItem.Name = "MenuItem_RemoveItem";
            this.MenuItem_RemoveItem.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_RemoveItem.Text = "Remove";
            this.MenuItem_RemoveItem.Click += new System.EventHandler(this.MenuItem_RemoveItem_Click);
            // 
            // MenuItem_ModifyItem
            // 
            this.MenuItem_ModifyItem.Name = "MenuItem_ModifyItem";
            this.MenuItem_ModifyItem.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_ModifyItem.Text = "Modify";
            this.MenuItem_ModifyItem.Click += new System.EventHandler(this.MenuItem_ModifyItem_Click);
            // 
            // UserControlItemCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwCycle);
            this.Controls.Add(this.grbxSettings);
            this.Name = "UserControlItemCycle";
            this.Size = new System.Drawing.Size(552, 470);
            this.grbxSettings.ResumeLayout(false);
            this.grbxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectedItem)).EndInit();
            this.ContextMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxSettings;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.ColumnHeader colHashCodeLabel;
        private System.Windows.Forms.ColumnHeader colHashCode;
        private System.Windows.Forms.ColumnHeader colCurrentCount;
        private System.Windows.Forms.ColumnHeader colCurrentMax;
        private System.Windows.Forms.ColumnHeader ColFlags;
        protected internal System.Windows.Forms.NumericUpDown nudSelectedItem;
        protected internal ListView_ColumnSortingClick lvwCycle;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AddItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_RemoveItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ModifyItem;
    }
}
