using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Product > products
            ;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product= new Product();
            product.name = tbProduct.Text;
            product.Price = Convert.ToDouble(tbPrice.Text);
            products.Add(product);
            showProducts();

        }
        private void showProducts()
        {
            dgvProducts.DataSource=null;
            dgvProducts.DataSource = products;
        }
    }
}
