namespace Gurtas
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnMeasureTools = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.siparişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişGüncelleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gününSiparişleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaliteKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girdiKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teklifVeFiyatlandırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grdMainPage = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainPage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnProjects);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnMeasureTools);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 667);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "developer FarukEraslan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(11, 156);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(191, 26);
            this.btnProjects.TabIndex = 3;
            this.btnProjects.Text = "Projeler";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(12, 92);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(191, 26);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Siparişler";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(12, 188);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(191, 26);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Tedarikçiler";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(12, 124);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(191, 26);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Müşteriler";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(12, 589);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(191, 26);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Kullanıcılar";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnMeasureTools
            // 
            this.btnMeasureTools.Location = new System.Drawing.Point(11, 220);
            this.btnMeasureTools.Name = "btnMeasureTools";
            this.btnMeasureTools.Size = new System.Drawing.Size(191, 26);
            this.btnMeasureTools.TabIndex = 5;
            this.btnMeasureTools.Text = "Ölçüm Aleti Envanteri";
            this.btnMeasureTools.UseVisualStyleBackColor = true;
            this.btnMeasureTools.Click += new System.EventHandler(this.btnMeasureTools_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişİşlemleriToolStripMenuItem,
            this.kaliteKontrolToolStripMenuItem,
            this.teklifVeFiyatlandırmaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1119, 31);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            this.siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSiparişToolStripMenuItem,
            this.siparişGüncelleSilToolStripMenuItem,
            this.aktifSiparişlerToolStripMenuItem,
            this.geçmişSiparişlerToolStripMenuItem,
            this.gününSiparişleriToolStripMenuItem});
            this.siparişİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            this.siparişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // yeniSiparişToolStripMenuItem
            // 
            this.yeniSiparişToolStripMenuItem.Name = "yeniSiparişToolStripMenuItem";
            this.yeniSiparişToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.yeniSiparişToolStripMenuItem.Text = "Yeni Sipariş";
            this.yeniSiparişToolStripMenuItem.Click += new System.EventHandler(this.yeniSiparişToolStripMenuItem_Click);
            // 
            // siparişGüncelleSilToolStripMenuItem
            // 
            this.siparişGüncelleSilToolStripMenuItem.Name = "siparişGüncelleSilToolStripMenuItem";
            this.siparişGüncelleSilToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.siparişGüncelleSilToolStripMenuItem.Text = "Sipariş Güncelle/Sil";
            this.siparişGüncelleSilToolStripMenuItem.Click += new System.EventHandler(this.siparişGüncelleSilToolStripMenuItem_Click);
            // 
            // aktifSiparişlerToolStripMenuItem
            // 
            this.aktifSiparişlerToolStripMenuItem.Name = "aktifSiparişlerToolStripMenuItem";
            this.aktifSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.aktifSiparişlerToolStripMenuItem.Text = "Aktif Siparişler";
            this.aktifSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.aktifSiparişlerToolStripMenuItem_Click);
            // 
            // geçmişSiparişlerToolStripMenuItem
            // 
            this.geçmişSiparişlerToolStripMenuItem.Name = "geçmişSiparişlerToolStripMenuItem";
            this.geçmişSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.geçmişSiparişlerToolStripMenuItem.Text = "Geçmiş Siparişler";
            this.geçmişSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.geçmişSiparişlerToolStripMenuItem_Click);
            // 
            // gününSiparişleriToolStripMenuItem
            // 
            this.gününSiparişleriToolStripMenuItem.Name = "gününSiparişleriToolStripMenuItem";
            this.gününSiparişleriToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.gününSiparişleriToolStripMenuItem.Text = "Günün Siparişleri";
            this.gününSiparişleriToolStripMenuItem.Click += new System.EventHandler(this.gününSiparişleriToolStripMenuItem_Click);
            // 
            // kaliteKontrolToolStripMenuItem
            // 
            this.kaliteKontrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girdiKontrolToolStripMenuItem});
            this.kaliteKontrolToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kaliteKontrolToolStripMenuItem.Name = "kaliteKontrolToolStripMenuItem";
            this.kaliteKontrolToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.kaliteKontrolToolStripMenuItem.Text = "Kalite Kontrol";
            // 
            // girdiKontrolToolStripMenuItem
            // 
            this.girdiKontrolToolStripMenuItem.Name = "girdiKontrolToolStripMenuItem";
            this.girdiKontrolToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.girdiKontrolToolStripMenuItem.Text = "Girdi Kontrol";
            this.girdiKontrolToolStripMenuItem.Click += new System.EventHandler(this.girdiKontrolToolStripMenuItem_Click);
            // 
            // teklifVeFiyatlandırmaToolStripMenuItem
            // 
            this.teklifVeFiyatlandırmaToolStripMenuItem.Name = "teklifVeFiyatlandırmaToolStripMenuItem";
            this.teklifVeFiyatlandırmaToolStripMenuItem.Size = new System.Drawing.Size(196, 25);
            this.teklifVeFiyatlandırmaToolStripMenuItem.Text = "Teklif ve Fiyatlandırma";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grdMainPage
            // 
            this.grdMainPage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdMainPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMainPage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdMainPage.Location = new System.Drawing.Point(0, 0);
            this.grdMainPage.Name = "grdMainPage";
            this.grdMainPage.RowTemplate.Height = 25;
            this.grdMainPage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMainPage.Size = new System.Drawing.Size(898, 645);
            this.grdMainPage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(898, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "GurtasERP | 2022 Her Hakkı Saklıdır.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(221, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 22);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdMainPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 645);
            this.panel3.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 698);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gürtaş v.0.1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainPage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip2;
        private Button btnCustomers;
        private Button btnSuppliers;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private ToolStripMenuItem aktifSiparişlerToolStripMenuItem;
        private ToolStripMenuItem geçmişSiparişlerToolStripMenuItem;
        private Button btnOrders;
        private ToolStripMenuItem yeniSiparişToolStripMenuItem;
        private Button btnProjects;
        private ToolStripMenuItem siparişGüncelleSilToolStripMenuItem;
        private Label label3;
        private DataGridView grdMainPage;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem gününSiparişleriToolStripMenuItem;
        private ToolStripMenuItem kaliteKontrolToolStripMenuItem;
        private ToolStripMenuItem girdiKontrolToolStripMenuItem;
        private Button btnUsers;
        private Button btnMeasureTools;
        private ToolStripMenuItem teklifVeFiyatlandırmaToolStripMenuItem;
    }
}