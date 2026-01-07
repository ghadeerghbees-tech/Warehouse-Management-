using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Warehouse_Management__
{
    public partial class DeleteProduct : Form
    {
        string filePath = "Product.json";
        List<Product> products;
        Product selectedProduct;
        public DeleteProduct()
        {
            InitializeComponent();
        }
        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
         
            FillGrid();
        }
        void LoadCategories()
        {
            var json = File.ReadAllText("Catgories.json");
            var c = JsonConvert.DeserializeObject<List<Category>>(json);
            cmbCategory.Items.Clear();
            cmbCategory.DataSource = new BindingSource(c, null);
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategories.DataSource = new BindingSource(c, null); ;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
        }
     
        void LoadProducts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                products = new List<Product>();
            }
        }
        void FillGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }
        void FillFields(Product p)
        {
            txtId.Text = p.Id.ToString();
            txtName.Text = p.Name;
            txtPriceS.Text = p.PriceS.ToString();
            txtPriceW.Text = p.PriceW.ToString();
            txtQun.Text = p.Qun.ToString();
            cmbCategories.SelectedValue = p.IdCtegory;
        }
        void SaveProducts()
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchId.Text, out int id))
            {
                MessageBox.Show("Please enter the correct number");
                return;
            }
            selectedProduct = products.FirstOrDefault(p => p.Id == id);
            if (selectedProduct != null)
            {
                FillFields(selectedProduct);
            }
            else
            {
                MessageBox.Show("Prroduct not found");
            }
        }
       
       
     
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedProduct==null)
            {
                MessageBox.Show("Choose a product first");
                return;
            }
            var result = MessageBox.Show($"Are you sure to delete the product{selectedProduct.Name}","?",MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                SaveProducts();
                FillGrid();
                ClearFields();
                selectedProduct = null;
                MessageBox.Show("The Product has been successfully deleted");
            }
        }
        void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtPriceS.Clear();
            txtPriceW.Clear();
            txtQun.Clear();
            cmbCategories.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            selectedProduct = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;
            if (selectedProduct != null)
                FillFields(selectedProduct);
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedValue == null)
                return;
            Category selectedCat = (Category)cmbCategories.SelectedItem;
            int categoryId = selectedCat.Id;
            var filteredProducts = products.Where(p => p.IdCtegory == categoryId).ToList();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = filteredProducts;
        }
    }
}
