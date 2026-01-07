namespace Warehouse_Management__
{
    partial class DeleteAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPssword = new System.Windows.Forms.TextBox();
            this.txtPhon = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.IsAdminLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(69, 29);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(100, 22);
            this.txtSearchUser.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(244, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(123, 87);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(735, 246);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(207, 358);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(512, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(207, 386);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(512, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPssword
            // 
            this.txtPssword.Location = new System.Drawing.Point(207, 414);
            this.txtPssword.Name = "txtPssword";
            this.txtPssword.ReadOnly = true;
            this.txtPssword.Size = new System.Drawing.Size(512, 22);
            this.txtPssword.TabIndex = 5;
            // 
            // txtPhon
            // 
            this.txtPhon.Location = new System.Drawing.Point(207, 442);
            this.txtPhon.Name = "txtPhon";
            this.txtPhon.ReadOnly = true;
            this.txtPhon.Size = new System.Drawing.Size(512, 22);
            this.txtPhon.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(826, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 80);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IsAdminLabel
            // 
            this.IsAdminLabel.AutoSize = true;
            this.IsAdminLabel.Location = new System.Drawing.Point(441, 480);
            this.IsAdminLabel.Name = "IsAdminLabel";
            this.IsAdminLabel.Size = new System.Drawing.Size(44, 16);
            this.IsAdminLabel.TabIndex = 9;
            this.IsAdminLabel.Text = "label1";
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 582);
            this.Controls.Add(this.IsAdminLabel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPhon);
            this.Controls.Add(this.txtPssword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchUser);
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.Load += new System.EventHandler(this.DeleteAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPssword;
        private System.Windows.Forms.TextBox txtPhon;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label IsAdminLabel;
    }
}