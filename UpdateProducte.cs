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
    public partial class UpdateProducte : Form
    {
        List<Product> products = new List<Product>();
        Product selectedProduct;

        string filePath = "Product.json";

        public UpdateProducte()
        {
            InitializeComponent();
        }


        private void UpdateProducte_Load(object sender, EventArgs e)
        {

            LoadCategories();
            LoadProducts();
            FillGrid();
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

        void LoadCategories()
        {
            var json = File.ReadAllText("Catgories.json");
            var c = JsonConvert.DeserializeObject<List<Category>>(json);
            cmbCategory.Items.Clear();
            cmbCategory.DataSource = new BindingSource(c,null);
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbUC.Items.Clear();
            cmbUC.DataSource = new BindingSource(c, null); ;
            cmbUC.DisplayMember = "Name";
            cmbUC.ValueMember = "Id";
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
            txtBuyPrice.Text = p.PriceW.ToString();
            txtSellPrice.Text = p.PriceS.ToString();
            txtQuantity.Text = p.Qun.ToString();
            cmbCategory.SelectedValue = p.IdCtegory;
        }

      

        void SaveProducts()
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

      

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (!RegexHelper.IsValidNumber(txtSearchId.Text))
            {
                MessageBox.Show("Enter a NUMBER in ID");
                return;
            }
            if (!int.TryParse(txtSearchId.Text, out int id))
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            selectedProduct = products.FirstOrDefault(p => p.Id == id);

            if (selectedProduct == null)
            {
                MessageBox.Show("Product not fount");
                return;
            }

            FillFields(selectedProduct);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!RegexHelper.IsValidUsername(txtName.Text))
            {
                MessageBox.Show("Name Category is invalid");
                return;
            }

            if (!RegexHelper.IsValidNumber(txtBuyPrice.Text))
            {
                MessageBox.Show("Enter a NUMBER in Price Before Sale");
                return;
            }
            if (!RegexHelper.IsValidNumber(txtSellPrice.Text))
            {
                MessageBox.Show("Enter a NUMBER in Price after Sale");
                return;
            }
            if (!RegexHelper.IsValidNumber(txtQuantity.Text))
            {
                MessageBox.Show("Enter a NUMBER in Ouantity");
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    throw new NullException("text Name");
                }
                if (string.IsNullOrWhiteSpace(txtBuyPrice.Text))
                {
                    throw new NullException("text Price Before Sale");
                }
                if (string.IsNullOrWhiteSpace(txtSellPrice.Text))
                {
                    throw new NullException("text Price After Sale");
                }
                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    throw new NullException("text Ouantity");
                }




                if (int.Parse(txtBuyPrice.Text) < 0)
                {
                    throw new NegtiveQuantityException("Price Before Sale");
                }
                if (int.Parse(txtSellPrice.Text) < 0)
                {
                    throw new NegtiveQuantityException("Price After Sale");
                }
                if (int.Parse(txtQuantity.Text) < 0)
                {
                    throw new NegtiveQuantityException("Ouantity");
                }

                if (int.Parse(txtSellPrice.Text) <= int.Parse(txtBuyPrice.Text))
                {
                    throw new PriceException();
                }

            }
            catch (NullException c)
            {
                MessageBox.Show(c.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (NegtiveQuantityException q)
            {
                MessageBox.Show(q.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (PriceException r)
            {
                MessageBox.Show(r.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedProduct == null)
            {
                MessageBox.Show("Choose a product first");
                return;
            }
            Category selectedCat = (Category)cmbUC.SelectedItem;
            
            selectedProduct.Name = txtName.Text;
            selectedProduct.PriceW = decimal.Parse(txtBuyPrice.Text);
            selectedProduct.PriceS = decimal.Parse(txtSellPrice.Text);
            selectedProduct.Qun = int.Parse(txtQuantity.Text);
            selectedProduct.IdCtegory = selectedCat.Id;

            SaveProducts();
            FillGrid();

            MessageBox.Show("The product has been modified successfully");

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null)
                return;
            Category selectedCat = (Category)cmbCategory.SelectedItem;
            int categoryId =selectedCat.Id;
            var filteredProducts = products.Where(p => p.IdCtegory == categoryId).ToList();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = filteredProducts;
        }


        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedProduct = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;
            if (selectedProduct != null)
                FillFields(selectedProduct);
        }
    }

  
}
   
