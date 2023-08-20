
namespace SavegameEditor
{
    partial class UserControl_BosInventory
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
            this.grbxInventory = new System.Windows.Forms.GroupBox();
            this.nudCurrentCycle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFilterOptional = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFilterExclude = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFilterInclude = new System.Windows.Forms.NumericUpDown();
            this.lblFilterInclude = new System.Windows.Forms.Label();
            this.tabInventoryCycles = new System.Windows.Forms.TabControl();
            this.grbxInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterOptional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterExclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterInclude)).BeginInit();
            this.SuspendLayout();
            // 
            // grbxInventory
            // 
            this.grbxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxInventory.Controls.Add(this.nudCurrentCycle);
            this.grbxInventory.Controls.Add(this.label3);
            this.grbxInventory.Controls.Add(this.nudFilterOptional);
            this.grbxInventory.Controls.Add(this.label2);
            this.grbxInventory.Controls.Add(this.nudFilterExclude);
            this.grbxInventory.Controls.Add(this.label1);
            this.grbxInventory.Controls.Add(this.nudFilterInclude);
            this.grbxInventory.Controls.Add(this.lblFilterInclude);
            this.grbxInventory.Location = new System.Drawing.Point(3, 3);
            this.grbxInventory.Name = "grbxInventory";
            this.grbxInventory.Size = new System.Drawing.Size(643, 55);
            this.grbxInventory.TabIndex = 0;
            this.grbxInventory.TabStop = false;
            this.grbxInventory.Text = "Properties";
            // 
            // nudCurrentCycle
            // 
            this.nudCurrentCycle.Location = new System.Drawing.Point(559, 20);
            this.nudCurrentCycle.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudCurrentCycle.Name = "nudCurrentCycle";
            this.nudCurrentCycle.Size = new System.Drawing.Size(76, 20);
            this.nudCurrentCycle.TabIndex = 7;
            this.nudCurrentCycle.Click += new System.EventHandler(this.NudCurrentCycle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Cycle:";
            // 
            // nudFilterOptional
            // 
            this.nudFilterOptional.Location = new System.Drawing.Point(240, 20);
            this.nudFilterOptional.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudFilterOptional.Name = "nudFilterOptional";
            this.nudFilterOptional.Size = new System.Drawing.Size(76, 20);
            this.nudFilterOptional.TabIndex = 5;
            this.nudFilterOptional.Click += new System.EventHandler(this.NudFilterOptional_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter Optional:";
            // 
            // nudFilterExclude
            // 
            this.nudFilterExclude.Location = new System.Drawing.Point(401, 20);
            this.nudFilterExclude.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudFilterExclude.Name = "nudFilterExclude";
            this.nudFilterExclude.Size = new System.Drawing.Size(76, 20);
            this.nudFilterExclude.TabIndex = 3;
            this.nudFilterExclude.Click += new System.EventHandler(this.NudFilterExclude_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Exclude:";
            // 
            // nudFilterInclude
            // 
            this.nudFilterInclude.Location = new System.Drawing.Point(82, 20);
            this.nudFilterInclude.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudFilterInclude.Name = "nudFilterInclude";
            this.nudFilterInclude.Size = new System.Drawing.Size(76, 20);
            this.nudFilterInclude.TabIndex = 1;
            this.nudFilterInclude.Click += new System.EventHandler(this.NudFilterInclude_Click);
            // 
            // lblFilterInclude
            // 
            this.lblFilterInclude.AutoSize = true;
            this.lblFilterInclude.Location = new System.Drawing.Point(6, 22);
            this.lblFilterInclude.Name = "lblFilterInclude";
            this.lblFilterInclude.Size = new System.Drawing.Size(70, 13);
            this.lblFilterInclude.TabIndex = 0;
            this.lblFilterInclude.Text = "Filter Include:";
            // 
            // tabInventoryCycles
            // 
            this.tabInventoryCycles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInventoryCycles.Location = new System.Drawing.Point(0, 64);
            this.tabInventoryCycles.Name = "tabInventoryCycles";
            this.tabInventoryCycles.SelectedIndex = 0;
            this.tabInventoryCycles.Size = new System.Drawing.Size(649, 382);
            this.tabInventoryCycles.TabIndex = 1;
            // 
            // UserControl_BosInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabInventoryCycles);
            this.Controls.Add(this.grbxInventory);
            this.Name = "UserControl_BosInventory";
            this.Size = new System.Drawing.Size(649, 446);
            this.grbxInventory.ResumeLayout(false);
            this.grbxInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterOptional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterExclude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterInclude)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxInventory;
        private System.Windows.Forms.NumericUpDown nudCurrentCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFilterOptional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFilterExclude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFilterInclude;
        private System.Windows.Forms.Label lblFilterInclude;
        protected internal System.Windows.Forms.TabControl tabInventoryCycles;
    }
}
