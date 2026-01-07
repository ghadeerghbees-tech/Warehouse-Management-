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

namespace Warehouse_Management__
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            LoadUsers();
        }
        List<Account> users = new List<Account>();


        void LoadUsers()
        {
            if (!File.Exists("Account.json"))
            {
                MessageBox.Show("Users file not found");
                return;
            }

          var j = File.ReadAllText("Account.json");
            users = JsonConvert.DeserializeObject<List<Account>>(j);
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
         
            try
            {
                username = txtUsername.Text.Trim();
                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new NullException("text Name");
                }
                password = txtPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new NullException("text Password");
                }
            }
            catch (NullException c)
            {
                MessageBox.Show(c.Message, "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!RegexHelper.IsValidUsername(txtUsername.Text))
            {
                MessageBox.Show("Name Category is invalid");
                return;
            }
            if (!RegexHelper.IsValidPassword(txtPassword.Text))
            {
                MessageBox.Show("Password Category is invalid");
                return;
            }

            var user = users.FirstOrDefault(u =>
                u.Name == username && u.Password == password);

            if (user == null)
            {
                lbLMessage.Text = "This user does not exist . Check the name or password";
                lbLMessage.ForeColor = Color.Red;
                return;
            }

            CurrentUser.User = user;

            if (user.IsAdmin)
            {
                MessageBox.Show("Logged in as an Admin");
            }
            else
            {
                MessageBox.Show("Logged in as  Cash");
            }

            this.Hide();
           Home frm = new Home();
            frm.ShowDialog();
        }
    
}
}
