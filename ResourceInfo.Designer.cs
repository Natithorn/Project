namespace Project
{
    partial class ResourceInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ชื่อสินค้า = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.หมวดหมู่ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.จำนวน = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaxAmount = new System.Windows.Forms.Button();
            this.MinAmount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ชื่อสินค้า,
            this.หมวดหมู่,
            this.จำนวน});
            this.dataGridView1.Location = new System.Drawing.Point(52, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(429, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // ชื่อสินค้า
            // 
            this.ชื่อสินค้า.HeaderText = "ชื่อสินค้า";
            this.ชื่อสินค้า.MinimumWidth = 6;
            this.ชื่อสินค้า.Name = "ชื่อสินค้า";
            this.ชื่อสินค้า.Width = 125;
            // 
            // หมวดหมู่
            // 
            this.หมวดหมู่.HeaderText = "หมวดหมู่";
            this.หมวดหมู่.MinimumWidth = 6;
            this.หมวดหมู่.Name = "หมวดหมู่";
            this.หมวดหมู่.Width = 125;
            // 
            // จำนวน
            // 
            this.จำนวน.HeaderText = "จำนวน";
            this.จำนวน.MinimumWidth = 6;
            this.จำนวน.Name = "จำนวน";
            this.จำนวน.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem1,
            this.loadToolStripMenuItem});
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.newItemToolStripMenuItem.Text = "Item";
            // 
            // newItemToolStripMenuItem1
            // 
            this.newItemToolStripMenuItem1.Name = "newItemToolStripMenuItem1";
            this.newItemToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.newItemToolStripMenuItem1.Text = "New Item";
            this.newItemToolStripMenuItem1.Click += new System.EventHandler(this.newItemToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // MaxAmount
            // 
            this.MaxAmount.Location = new System.Drawing.Point(587, 120);
            this.MaxAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxAmount.Name = "MaxAmount";
            this.MaxAmount.Size = new System.Drawing.Size(152, 49);
            this.MaxAmount.TabIndex = 2;
            this.MaxAmount.Text = "Max Amount";
            this.MaxAmount.UseVisualStyleBackColor = true;
            this.MaxAmount.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinAmount
            // 
            this.MinAmount.Location = new System.Drawing.Point(587, 200);
            this.MinAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinAmount.Name = "MinAmount";
            this.MinAmount.Size = new System.Drawing.Size(152, 54);
            this.MinAmount.TabIndex = 3;
            this.MinAmount.Text = "Min Amount";
            this.MinAmount.UseVisualStyleBackColor = true;
            this.MinAmount.Click += new System.EventHandler(this.MinAmount_Click);
            // 
            // ResourceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 537);
            this.Controls.Add(this.MinAmount);
            this.Controls.Add(this.MaxAmount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ResourceInfo";
            this.Text = "ResourceInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ชื่อสินค้า;
        private DataGridViewTextBoxColumn หมวดหมู่;
        private DataGridViewTextBoxColumn จำนวน;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newItemToolStripMenuItem;
        private ToolStripMenuItem newItemToolStripMenuItem1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private Button MaxAmount;
        private Button MinAmount;
    }
}