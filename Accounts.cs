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
    public partial class Accounts : Form
    {
        List<Account> accounts;
        string filePath = "Account.json";

        public Accounts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccount fr = new AddAccount();
            fr.ShowDialog();
            this.Close();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            FillGrid();
        }
        void FillGrid()
        {
            dgvAccounts.DataSource = null;
            dgvAccounts.DataSource = accounts;
        }
        void LoadProducts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                accounts = new List<Account>();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount fr = new UpdateAccount();
            fr.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAccount fr = new DeleteAccount();
            fr.ShowDialog();
            this.Close();
        }
    }

              
    }

