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
using System.Xml.Linq;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Warehouse_Management__
{
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }
      
        string filePath = "Account.json";
        private List<Account> accounts;
        Account selectedAccount;

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            LoadProducts();
            RefreshDGV();

        }
        void LoadProducts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText("Account.json");
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                accounts = new List<Account>();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            string searchTerm = txtSearchUser.Text.ToLower();

             selectedAccount = accounts.FirstOrDefault(a => a.Name.ToLower().Contains(searchTerm));

            if (selectedAccount != null)
            {
                FillFields(selectedAccount);
            }
            else
            {
                MessageBox.Show("Enter to Account in the Text Seare");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    throw new NullException("texts");
                }
            }
            catch(NullException c)
            {

                MessageBox.Show(c.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             
                string accountName = txtUserName.Text.ToLower(); 

                var selectedAccount = accounts.FirstOrDefault(a => a.Name.ToLower() == accountName);

                
                if (selectedAccount != null)
                {
                 
                    accounts.Remove(selectedAccount);

                RefreshDGV();

                    
                    string json = JsonConvert.SerializeObject(accounts);
                    File.WriteAllText("Account.json", json);

                   
                    ClearFields();

                    MessageBox.Show("The account has been successfully deleted");
                }
             
          
           
        }

        void RefreshDGV()
        {

            dgvAccount.DataSource = new BindingList<Account>(accounts);
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            selectedAccount = (Account)dgvAccount.Rows[e.RowIndex].DataBoundItem;
            if (selectedAccount != null)
                FillFields(selectedAccount);
        }
        
        void FillFields(Account p)
        {  
            txtID.Text = p.Id.ToString();
            txtUserName.Text = p.Name;
            txtPssword.Text = p.Password;
            txtPhon.Text = p.Phone.ToString();
            IsAdminLabel.Text = p.IsAdmin ? "Admin" : "Cash"; 

        }
        void ClearFields()
        {
            txtID.Clear();
            txtUserName.Clear();
            txtPssword.Clear();
            txtPhon.Clear();
            IsAdminLabel.Text = string.Empty;
        }
    }
}

