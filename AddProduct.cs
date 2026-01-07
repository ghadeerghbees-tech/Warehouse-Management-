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
    public partial class AddProduct : Form
    {
        Home h;
        public AddProduct(Home h)
        {
            InitializeComponent();
            this.h = h;
        }
        private void but_Add_Click(object sender, EventArgs e)
        {
            if (!RegexHelper.IsValidUsername(txt_Name.Text))
            {
                MessageBox.Show("Name Category is invalid");
                return;
            }

            if (!RegexHelper.IsValidNumber(txt_PriceW.Text))
            {
                MessageBox.Show("Enter a NUMBER in Price Before Sale");
                return;
            }
            if (!RegexHelper.IsValidNumber(txt_PriceS.Text))
            {
                MessageBox.Show("Enter a NUMBER in Price after Sale");
                return;
            }
            if (!RegexHelper.IsValidNumber(TB_Qun.Text))
            {
                MessageBox.Show("Enter a NUMBER in Ouantity");
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Name.Text))
                {
                    throw new NullException("text Name");
                }
                if (string.IsNullOrWhiteSpace(txt_PriceW.Text))
                {
                    throw new NullException("text Price Before Sale");
                }
                if (string.IsNullOrWhiteSpace(txt_PriceS.Text))
                {
                    throw new NullException("text Price After Sale");
                }
                if (string.IsNullOrWhiteSpace(TB_Qun.Text))
                {
                    throw new NullException("text Ouantity");
                }




                if (int.Parse(txt_PriceW.Text) < 0)
                {
                    throw new NegtiveQuantityException("Price Before Sale");
                }
                if (int.Parse(txt_PriceS.Text) < 0)
                {
                    throw new NegtiveQuantityException("Price After Sale");
                }
                if (int.Parse(TB_Qun.Text) <0)
                {
                    throw new NegtiveQuantityException("Ouantity");
                }

                if(int.Parse(txt_PriceS.Text)<= int.Parse(txt_PriceW.Text))
                {
                    throw new PriceException();
                }

            }
            catch (NullException c)
            {
                MessageBox.Show(c.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch(NegtiveQuantityException q)
            {
                MessageBox.Show(q.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch(PriceException r)
            {
                MessageBox.Show(r.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            List<Product> products = FileManager.LoadFormFile<Product>("Product.json");

            int newId = products.Count > 0 ? products.Max(c => c.Id) + 1 : 1;

            Product p = new Product();
            p.Id = newId;
            p.Name = txt_Name.Text;
            p.PriceS = decimal.Parse(txt_PriceS.Text);
            p.PriceW = decimal.Parse(txt_PriceW.Text);
            p.DT = DateTime.Now;
            p.Qun= int.Parse(TB_Qun.Text);
            string selectedCategory = CMB_Add.SelectedItem.ToString();
            if (CMB_Add.SelectedValue != null)
            {
                p.IdCtegory = Convert.ToInt32(CMB_Add.SelectedValue);
            }
            else
            {
                MessageBox.Show("enter to Categry");
            }
          
           products.Add(p);
            FileManager.SaveToFile(products,"Product.json");
            MessageBox.Show("Product Added");
            this.Close();

        }

        private void Add_Name(object sender, EventArgs e)
        {

        }

        private void CMB_Add_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
          
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var json = File.ReadAllText("Catgories.json");
            var c = JsonConvert.DeserializeObject<List<Category>>(json);
          CMB_Add.Items.Clear();
            CMB_Add.DataSource = c;
            CMB_Add.DisplayMember = "Name";
            CMB_Add.ValueMember = "Id";

           

        }
   
    }
}
