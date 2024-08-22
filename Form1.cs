using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitUrunTakipUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        public void LoadProducts()
        {
            dwgProducts.DataSource = _productDal.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts(); //listeleme methodunu oluşturduk.
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                ProductName = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxPrice.Text),
                Stock = Convert.ToInt32(tbxStock.Text)
            });
            LoadProducts(); //bu sayede ürün eklenir eklenmez liste güncellenecek.
            MessageBox.Show("Product added!");
        }
        private void DwgProducts_CellClick(object sender, DataGridViewCellEventArgs e) //satıra tıkladığımızda satırdaki bilgileri update bölümüne çeker
        {
            tbxNameUp.Text = dwgProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPriceUp.Text = dwgProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockUp.Text = dwgProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e) //bilgileri çektikten sonra günceller
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dwgProducts.CurrentRow.Cells[0].Value),
                ProductName = tbxNameUp.Text,
                UnitPrice = Convert.ToDecimal(tbxPriceUp.Text),
                Stock = Convert.ToInt32(tbxStockUp.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated");
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dwgProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted!");
        }
    }
}
