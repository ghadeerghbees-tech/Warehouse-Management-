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
    public partial class AddCategory : Form
    {
        Home h;
        public AddCategory(Home h)
        {
            InitializeComponent();
            this.h = h;
        }
        int id = 4;

     

        private void but_add_Click(object sender, EventArgs e)
        {
            if (!RegexHelper.IsValidUsername(TB_addcategory.Text))
            {
                MessageBox.Show("Name Category is invalid");
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(TB_addcategory.Text))
                {
                    throw new NullException("text Name");
                }
            }
            catch (NullException c)
            {
                MessageBox.Show(c.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            List<Category> categories = FileManager.LoadFormFile<Category>("Catgories.json");
            int newId = categories.Count > 0 ? categories.Max(c => c.Id) + 1 :1;

            Category ca = new Category();

            ca.Id = newId;
            ca.Name = TB_addcategory.Text.Trim();
            ca.Switch = CB_inter.Checked;
            
            
           categories.Add(ca);
            FileManager.SaveToFile(categories, "Catgories.json");
            MessageBox.Show("Category Added");
            this.Close();
        }
    }
}
