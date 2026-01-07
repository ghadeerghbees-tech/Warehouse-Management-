using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management__
{
    public partial class Home : Form
    {
        List<Category> categories = new List<Category>();
        List<Product> products = new List<Product>();
        List<Account> accounts = new List<Account>();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnAccount.Visible = CurrentUser.User.IsAdmin;
           lblWelcome.Text = "Welcome to " + CurrentUser.User.Name;
            categories = FileManager.LoadFormFile<Category>("Catgories.json");
            products = FileManager.LoadFormFile<Product>("Product.json");
            accounts = FileManager.LoadFormFile<Account>("Account.json");
            if (categories.Count == 0)
            {
                categories.Add(new Category() { Id=1,Name = "Elctronih", Switch = true });
                categories.Add(new Category() { Id = 2, Name = "Dieteics", Switch = false });
                categories.Add(new Category() { Id = 3, Name = "Electncals", Switch = false });
                FileManager.SaveToFile(categories, "Catgories.json");
            }

            if (products.Count == 0)
            {
                products.Add(new Product() { Id = 1 ,Name = "Laptop", PriceW = 1000, PriceS = 2000, DT = DateTime.Now, IdCtegory = 1, Qun = 3 });
                products.Add(new Product() { Id = 2, Name = "Brick", PriceW = 200, PriceS = 400, DT = DateTime.Now, IdCtegory = 2 ,Qun=122});
                products.Add(new Product() { Id = 3, Name = "Broom", PriceW = 5010, PriceS = 10000, DT = DateTime.Now, IdCtegory = 1 ,Qun=4});
                products.Add(new Product() { Id = 4, Name = "Mouse", PriceW = 980, PriceS = 1400, DT = DateTime.Now, IdCtegory = 1,Qun=16 });

                FileManager.SaveToFile(products, "Product.json");
            }
            
            if (accounts.Count == 0)
            {
                accounts.Add(new Account { Id = 0 ,Name = "Ahmad", Password = "sado1016",  Phone = 0985255064, IsAdmin = true });
                accounts.Add(new Account { Id = 1, Name = "Aya", Password = "maoud228", Phone = 0925376489, IsAdmin = false });
                accounts.Add(new Account { Id = 2, Name = "Gader", Password = "ro009wo", Phone = 0937468287, IsAdmin = false });
                FileManager.SaveToFile(accounts, "Account.json");

            }


            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price Before Sale", typeof(decimal));
            dt.Columns.Add("Price After Sale", typeof(decimal));
            dt.Columns.Add("Ouantity", typeof(int));
            dt.Columns.Add("DateTime", typeof(string));
            dt.Columns.Add("Category Name", typeof(string));
            foreach (var p in products)
            {
                string catName = categories.FirstOrDefault(c => c.Id == p.IdCtegory)?.Name ?? "emp";
                dt.Rows.Add(p.Id, p.Name, p.PriceW, p.PriceS,p.Qun, p.DT.ToString("yyyy/MM/dd hh:mm"), catName);
            }
            DGVhome.DataSource = dt;
        }

        private void but_AddP_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct(this);
            ap.ShowDialog();
            RefreshProductsGrid();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            AddCategory ap = new AddCategory(this);
            ap.ShowDialog();
            RefreshProductsGrid();
        }

        private void but_ubdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategory frm = new UpdateCategory();
            frm.ShowDialog();
            RefreshProductsGrid(); 
        }
        public void RefreshProductsGrid()
        {
            categories = FileManager.LoadFormFile<Category>("Catgories.json");
            products = FileManager.LoadFormFile<Product>("Product.json");
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price Before Sale", typeof(decimal));
            dt.Columns.Add("Price After Sale", typeof(decimal));
            dt.Columns.Add("Ouantity", typeof(int));
            dt.Columns.Add("DateTime", typeof(string));
            dt.Columns.Add("Category Name", typeof(string));

            foreach (var p in products)
            {
                string catName = categories.FirstOrDefault(c => c.Id == p.IdCtegory)?.Name ?? "emp";
                dt.Rows.Add(p.Id, p.Name, p.PriceW, p.PriceS,p.Qun, p.DT.ToString("yyyy/MM/dd hh:mm "), catName);
            }
            DGVhome.DataSource = dt;
        }

        private void btn_UpdateP_Click(object sender, EventArgs e)
        {
            UpdateProducte frm = new UpdateProducte();
            frm.ShowDialog();
            RefreshProductsGrid();
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct frm = new DeleteProduct();
            frm.ShowDialog();
            RefreshProductsGrid();

        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory frm = new DeleteCategory();
            frm.ShowDialog();
            RefreshProductsGrid();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Accounts frm = new Accounts();
            frm.ShowDialog();
        }
    }
    }