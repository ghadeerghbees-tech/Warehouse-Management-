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

namespace Warehouse_Management__
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
            
            txtPassword.PasswordChar = '*';
        }
      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!RegexHelper.IsValidUsername(txtUserName.Text))
            {
                MessageBox.Show("UserName is invalid");
                return;
            }

            if (!RegexHelper.IsValidPassword(txtPassword.Text))
            {
                MessageBox.Show("The password must be 4 to 20 characters long");
                return;
            }

            if (!RegexHelper.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("The phone number starts with 09 or +9639 and eight other numbers");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
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


           
            if (txtUserName.Text == txtPassword.Text)
            {
                MessageBox.Show("You cannot put the name the same as the password");
                return;
            }

            List<Account> accounts = FileManager.LoadFormFile<Account>("Account.json");
           
            if (accounts.Any(a => a.Name == txtUserName.Text))
            {
                MessageBox.Show("Username already exists");
                return;
            }

           
            Account ac = new Account
            {
                Id = accounts.Count == 0 ? 1 : accounts.Max(a => a.Id) + 1,
                Name = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
              
                Phone = int.Parse(txtPhone.Text.Trim()),
                IsAdmin = chklsAdmin.Checked
            };

            
            accounts.Add(ac);
            FileManager.SaveToFile(accounts, "Account.json");
            MessageBox.Show("An account has been added successfully");
            ClearFields();
        }

        void ClearFields()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            chklsAdmin.Checked = false;
        }
       
    }
}

