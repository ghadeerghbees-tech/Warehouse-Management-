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
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
        {
            InitializeComponent();
            Load += DeleteCategory_Load;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            cmbMoveToCategory.Visible = false;
        }
        string productsPath = "Product.json";
        string categoriesPath = "Catgories.json";
        List<Category> categories = new List<Category>();
        List<Product> products = new List<Product>();
        bool waitingForMoveSelection = false;


     
        private void DeleteCategory_Load(object sender, EventArgs e)
        {
             LoadData();
            FillCategoryCombo();

        }
        void LoadData ()
        {
             categories = File.Exists(categoriesPath) ?JsonConvert.DeserializeObject<List<Category>>(
               File.ReadAllText(categoriesPath)):new List<Category>();
             products = File.Exists(productsPath) ? JsonConvert.DeserializeObject<List<Product>>(
        File.ReadAllText(productsPath)):new List<Product>();
        }
        void FillCategoryCombo()
        {
            cmbCategory.DataSource = null;
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
           cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void FillMoveToCategoryCombo(int excludedCategoryId)
        {

            cmbMoveToCategory.DataSource = null;
            cmbMoveToCategory.DataSource = categories.Where(c=>c.Id!=excludedCategoryId).ToList();
            cmbMoveToCategory.DisplayMember = "Name";
            cmbMoveToCategory.ValueMember = "Id";
           cmbMoveToCategory.DropDownStyle = ComboBoxStyle.DropDownList;

        }
      
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Choose a category fiirst", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Select a category to delete");
                return;
            }

            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            var category = categories.First(c => c.Id == categoryId);



            if (waitingForMoveSelection)
            {
                ConfirmMoveAndDelete(categoryId);
                return;
            }

            var relatedProducts = products
                .Where(p => p.IdCtegory == categoryId)
                .ToList();

         
            if (relatedProducts.Count == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete an item?",
                    "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    categories.Remove(category);
                    SaveAll();
                    RefreshUI();
                }
                return;
            }

        
            var result = MessageBox.Show(
                "A category containing products\n\n" +
                "Yes : Delete the item with products\n" +
                "No  : Transferring products to another category\n" +
                "Cancel : Cancel",
                "Warning",
                MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Cancel)
                return;

            if (result == DialogResult.Yes)
            {
                products.RemoveAll(p => p.IdCtegory == categoryId);
                categories.Remove(category);
                SaveAll();
                RefreshUI();
                return;
            }

           
            if (result == DialogResult.No)
            {
                FillMoveToCategoryCombo(categoryId);
                cmbMoveToCategory.Visible = true;
               
                waitingForMoveSelection = true;

                MessageBox.Show("Choose an alternative category and then choose Delete again");
            }
        }

        void ConfirmMoveAndDelete(int oldCategoryId)
        {
            if (cmbMoveToCategory.SelectedValue == null)
            {
                MessageBox.Show("Choose a category to transfer products to!");
                return;
            }

            int newCategoryId = Convert.ToInt32(cmbMoveToCategory.SelectedValue);

            foreach (var p in products.Where(p => p.IdCtegory == oldCategoryId))
                p.IdCtegory = newCategoryId;

            categories.RemoveAll(c => c.Id == oldCategoryId);

            SaveAll();
            RefreshUI();

            cmbMoveToCategory.Visible = false;
            
            waitingForMoveSelection = false;
        }
        void SaveAll()
        {
            File.WriteAllText(productsPath,
                JsonConvert.SerializeObject(products, Formatting.Indented));

            File.WriteAllText(categoriesPath,
                JsonConvert.SerializeObject(categories, Formatting.Indented));
        }

        void RefreshUI()
        {
            LoadData();
            FillCategoryCombo();
        }
 



    }


}

