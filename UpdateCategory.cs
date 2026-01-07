using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management__
{
    public partial class UpdateCategory : Form
    {
        public UpdateCategory()
        {
            InitializeComponent();
        }
        List<Category> categories;
        List<Product> products;
        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            categories = FileManager.LoadFormFile<Category>("Catgories.json");
            products = FileManager.LoadFormFile<Product>("Product.json");
            CB_categories.DataSource = null;
            CB_categories.DataSource = categories;
            CB_categories.DisplayMember = "Name";
            CB_categories.ValueMember = "Id";

        }
        private void but_update_Click(object sender, EventArgs e)
        {
            if (!RegexHelper.IsValidUsername(TB_category.Text))
            {
                MessageBox.Show("Name Category is invalid");
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(TB_category.Text))
                {
                    throw new NullException("text Name");
                }
            }
            catch (NullException c)
            {
                MessageBox.Show(c.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Category selectedCat = (Category)CB_categories.SelectedItem;
            if (selectedCat == null)
                return;
            selectedCat.Name = TB_category.Text;
            selectedCat.Switch = CB_inter.Checked;
            FileManager.SaveToFile(categories, "Catgories.json");
            MessageBox.Show("Yes");
            this.Close();
        }
        
    
    }
}
