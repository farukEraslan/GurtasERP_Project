namespace Gurtas
{
    partial class UpdateOrderForm
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
            this.grdUpdateOrder = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdUpdateOrder
            // 
            this.grdUpdateOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdUpdateOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUpdateOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdUpdateOrder.Location = new System.Drawing.Point(0, 0);
            this.grdUpdateOrder.Name = "grdUpdateOrder";
            this.grdUpdateOrder.RowTemplate.Height = 25;
            this.grdUpdateOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdateOrder.Size = new System.Drawing.Size(1029, 550);
            this.grdUpdateOrder.TabIndex = 0;
            this.grdUpdateOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateOrder_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 46);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞ GÜNCELLEMEK YA DA SİLMEK İÇİN İLGİLİ SİPARİŞİN ÜSTÜNE ÇİFT TIKLAYINIZ.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdUpdateOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 550);
            this.panel2.TabIndex = 2;
            // 
            // UpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Güncelle/Sil";
            this.Load += new System.EventHandler(this.UpdateOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdUpdateOrder;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}