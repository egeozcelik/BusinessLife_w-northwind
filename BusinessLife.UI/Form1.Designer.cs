namespace BusinessLife.UI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(4, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(864, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriİşlemlerToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem,
            this.çalışanİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kategoriİşlemlerToolStripMenuItem
            // 
            this.kategoriİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriEkleToolStripMenuItem,
            this.kategoriGüncelleToolStripMenuItem,
            this.kategoriSilToolStripMenuItem});
            this.kategoriİşlemlerToolStripMenuItem.Name = "kategoriİşlemlerToolStripMenuItem";
            this.kategoriİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.kategoriİşlemlerToolStripMenuItem.Text = "Kategori İşlemler";
            // 
            // kategoriEkleToolStripMenuItem
            // 
            this.kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            this.kategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.kategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            this.kategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.kategoriEkleToolStripMenuItem_Click);
            // 
            // kategoriGüncelleToolStripMenuItem
            // 
            this.kategoriGüncelleToolStripMenuItem.Name = "kategoriGüncelleToolStripMenuItem";
            this.kategoriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.kategoriGüncelleToolStripMenuItem.Text = "Kategori Güncelle";
            this.kategoriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kategoriGüncelleToolStripMenuItem_Click);
            // 
            // kategoriSilToolStripMenuItem
            // 
            this.kategoriSilToolStripMenuItem.Name = "kategoriSilToolStripMenuItem";
            this.kategoriSilToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.kategoriSilToolStripMenuItem.Text = "Kategori Sil";
            this.kategoriSilToolStripMenuItem.Click += new System.EventHandler(this.kategoriSilToolStripMenuItem_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünGüncelleToolStripMenuItem,
            this.ürünSilToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün işlemleri";
            this.ürünİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ürünİşlemleriToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            this.ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            this.ürünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ürünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ürünSilToolStripMenuItem.Text = "Ürün Sil";
            // 
            // çalışanİşlemleriToolStripMenuItem
            // 
            this.çalışanİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanEkleToolStripMenuItem,
            this.çalışanGüncelleToolStripMenuItem,
            this.çalışanSilToolStripMenuItem});
            this.çalışanİşlemleriToolStripMenuItem.Name = "çalışanİşlemleriToolStripMenuItem";
            this.çalışanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.çalışanİşlemleriToolStripMenuItem.Text = "Çalışan İşlemleri";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            // 
            // çalışanGüncelleToolStripMenuItem
            // 
            this.çalışanGüncelleToolStripMenuItem.Name = "çalışanGüncelleToolStripMenuItem";
            this.çalışanGüncelleToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.çalışanGüncelleToolStripMenuItem.Text = "Çalışan Güncelle";
            // 
            // çalışanSilToolStripMenuItem
            // 
            this.çalışanSilToolStripMenuItem.Name = "çalışanSilToolStripMenuItem";
            this.çalışanSilToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.çalışanSilToolStripMenuItem.Text = "Çalışan Sil";
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.dataGridView1);
            this.grpCategory.Location = new System.Drawing.Point(24, 33);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.grpCategory.Size = new System.Drawing.Size(872, 251);
            this.grpCategory.TabIndex = 3;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Kategori Listesi";
            this.grpCategory.Enter += new System.EventHandler(this.grpCategory_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 314);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanSilToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCategory;
    }
}

