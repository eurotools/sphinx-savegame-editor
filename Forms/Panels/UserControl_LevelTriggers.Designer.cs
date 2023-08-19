
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
            this.lvwCurrentLevelTriggers = new SavegameEditor.ListView_ColumnSortingClick();
            this.colTrigType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTrigSubtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSavedStateValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPosZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.lvwCurrentLevelTriggers.Location = new System.Drawing.Point(0, 0);
            this.lvwCurrentLevelTriggers.Name = "lvwCurrentLevelTriggers";
            this.lvwCurrentLevelTriggers.Size = new System.Drawing.Size(742, 442);
            this.lvwCurrentLevelTriggers.TabIndex = 1;
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
            // UserControl_LevelTriggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwCurrentLevelTriggers);
            this.Name = "UserControl_LevelTriggers";
            this.Size = new System.Drawing.Size(742, 442);
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
    }
}
