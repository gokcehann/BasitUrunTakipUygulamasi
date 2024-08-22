namespace BasitUrunTakipUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxNameUp = new System.Windows.Forms.TextBox();
            this.tbxStockUp = new System.Windows.Forms.TextBox();
            this.lblNameUp = new System.Windows.Forms.Label();
            this.tbxPriceUp = new System.Windows.Forms.TextBox();
            this.lblPriceUp = new System.Windows.Forms.Label();
            this.lblStockUp = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.dwgProducts = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(694, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUp);
            this.gbxUpdate.Controls.Add(this.tbxStockUp);
            this.gbxUpdate.Controls.Add(this.lblNameUp);
            this.gbxUpdate.Controls.Add(this.tbxPriceUp);
            this.gbxUpdate.Controls.Add(this.lblPriceUp);
            this.gbxUpdate.Controls.Add(this.lblStockUp);
            this.gbxUpdate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(473, 329);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(386, 229);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(148, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // tbxNameUp
            // 
            this.tbxNameUp.Location = new System.Drawing.Point(106, 39);
            this.tbxNameUp.Name = "tbxNameUp";
            this.tbxNameUp.Size = new System.Drawing.Size(179, 29);
            this.tbxNameUp.TabIndex = 4;
            // 
            // tbxStockUp
            // 
            this.tbxStockUp.Location = new System.Drawing.Point(106, 129);
            this.tbxStockUp.Name = "tbxStockUp";
            this.tbxStockUp.Size = new System.Drawing.Size(179, 29);
            this.tbxStockUp.TabIndex = 6;
            // 
            // lblNameUp
            // 
            this.lblNameUp.AutoSize = true;
            this.lblNameUp.Location = new System.Drawing.Point(30, 47);
            this.lblNameUp.Name = "lblNameUp";
            this.lblNameUp.Size = new System.Drawing.Size(58, 21);
            this.lblNameUp.TabIndex = 1;
            this.lblNameUp.Text = "Name";
            // 
            // tbxPriceUp
            // 
            this.tbxPriceUp.Location = new System.Drawing.Point(106, 84);
            this.tbxPriceUp.Name = "tbxPriceUp";
            this.tbxPriceUp.Size = new System.Drawing.Size(179, 29);
            this.tbxPriceUp.TabIndex = 5;
            // 
            // lblPriceUp
            // 
            this.lblPriceUp.AutoSize = true;
            this.lblPriceUp.Location = new System.Drawing.Point(30, 92);
            this.lblPriceUp.Name = "lblPriceUp";
            this.lblPriceUp.Size = new System.Drawing.Size(53, 21);
            this.lblPriceUp.TabIndex = 2;
            this.lblPriceUp.Text = "Price";
            // 
            // lblStockUp
            // 
            this.lblStockUp.AutoSize = true;
            this.lblStockUp.Location = new System.Drawing.Point(30, 137);
            this.lblStockUp.Name = "lblStockUp";
            this.lblStockUp.Size = new System.Drawing.Size(55, 21);
            this.lblStockUp.TabIndex = 3;
            this.lblStockUp.Text = "Stock";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxStock);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxPrice);
            this.gbxAdd.Controls.Add(this.lblPrice);
            this.gbxAdd.Controls.Add(this.lblStock);
            this.gbxAdd.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(12, 329);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(386, 229);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(152, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(114, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(179, 29);
            this.tbxName.TabIndex = 4;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(114, 129);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(179, 29);
            this.tbxStock.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(114, 84);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(179, 29);
            this.tbxPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 92);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 21);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(30, 137);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(55, 21);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock";
            // 
            // dwgProducts
            // 
            this.dwgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dwgProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dwgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgProducts.Location = new System.Drawing.Point(12, 45);
            this.dwgProducts.Name = "dwgProducts";
            this.dwgProducts.RowHeadersWidth = 51;
            this.dwgProducts.RowTemplate.Height = 24;
            this.dwgProducts.Size = new System.Drawing.Size(847, 259);
            this.dwgProducts.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 569);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dwgProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxNameUp;
        private System.Windows.Forms.TextBox tbxStockUp;
        private System.Windows.Forms.Label lblNameUp;
        private System.Windows.Forms.TextBox tbxPriceUp;
        private System.Windows.Forms.Label lblPriceUp;
        private System.Windows.Forms.Label lblStockUp;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView dwgProducts;
    }
}

