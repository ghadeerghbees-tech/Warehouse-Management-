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
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
        {
            InitializeComponent();
        }
      
            List<Account> accounts = new List<Account>();
            string filePath = "Account.json";

          

            private void UpdateAccount_Load(object sender, EventArgs e)
            {
                LoadAccounts();
                txtID.Enabled = false; 
            }

           
            void LoadAccounts()
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    accounts = JsonConvert.DeserializeObject<List<Account>>(json);
                }

            DGVAccount.DataSource = null;
            DGVAccount.DataSource = accounts;
            }

            void SaveAccounts()
            {
                string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

            void FillTextBoxes(Account acc)
            {
                txtID.Text = acc.Id.ToString();
                txtName.Text = acc.Name;
                txtPassword.Text = acc.Password;
                txtPhone.Text = acc.Phone.ToString();
                chkIsAdmin.Checked = acc.IsAdmin;
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
            if (!RegexHelper.IsValidUsername(txtSearchName.Text))
            {
                MessageBox.Show("Enter a Character in Name");
                return;
            }
         
            Account acc = accounts
                    .FirstOrDefault(a => a.Name == txtSearchName.Text);

                if (acc != null)
                {
                    FillTextBoxes(acc);
                }
                else
                {
                    MessageBox.Show("The Account does not exist");
                }
            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    Account acc = (Account)DGVAccount.Rows[e.RowIndex].DataBoundItem;
                    FillTextBoxes(acc);
                }
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
            if (!RegexHelper.IsValidUsername(txtName.Text))
            {
                MessageBox.Show("Name Category is invalid");
                return;
            }
            if (!RegexHelper.IsValidPassword(txtPassword.Text))
            {
                MessageBox.Show("Password Category is invalid");
                return;
            }
            if (!RegexHelper.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone Category is invalid");
                return;
            }


            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    throw new NullException("text Name");
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    throw new NullException("text Password");
                }
                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    throw new NullException("text Phone");
                }
            }
            catch (NullException c)
            {
                MessageBox.Show(c.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                if (txtID.Text == "")
                {
                    MessageBox.Show("Choose an account first");
                    return;
                }
           

                int id = int.Parse(txtID.Text);

                Account acc = accounts.FirstOrDefault(a => a.Id == id);

                if (acc != null)
                {
                    acc.Name = txtName.Text;
                    acc.Password = txtPassword.Text;
                    acc.Phone = int.Parse(txtPhone.Text);
                    acc.IsAdmin = chkIsAdmin.Checked;

                    SaveAccounts();
                    LoadAccounts();

                    MessageBox.Show("The account has been modified successfully");
                }
            }
    }
    }

