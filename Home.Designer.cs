namespace Warehouse_Management__
{
    partial class Home
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
            this.DGVhome = new System.Windows.Forms.DataGridView();
            this.but_AddP = new System.Windows.Forms.Button();
            this.AddCategory = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.but_ubdateCategory = new System.Windows.Forms.Button();
            this.btn_UpdateP = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.DeleteCategory = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhome)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVhome
            // 
            this.DGVhome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhome.Location = new System.Drawing.Point(24, 71);
            this.DGVhome.Name = "DGVhome";
            this.DGVhome.ReadOnly = true;
            this.DGVhome.RowHeadersWidth = 51;
            this.DGVhome.RowTemplate.Height = 24;
            this.DGVhome.Size = new System.Drawing.Size(762, 208);
            this.DGVhome.TabIndex = 0;
            // 
            // but_AddP
            // 
            this.but_AddP.Location = new System.Drawing.Point(24, 311);
            this.but_AddP.Name = "but_AddP";
            this.but_AddP.Size = new System.Drawing.Size(112, 44);
            this.but_AddP.TabIndex = 1;
            this.but_AddP.Text = "ADD Product";
            this.but_AddP.UseVisualStyleBackColor = true;
            this.but_AddP.Click += new System.EventHandler(this.but_AddP_Click);
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(142, 311);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(112, 44);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "ADD Category";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // but_ubdateCategory
            // 
            this.but_ubdateCategory.Location = new System.Drawing.Point(260, 311);
            this.but_ubdateCategory.Name = "but_ubdateCategory";
            this.but_ubdateCategory.Size = new System.Drawing.Size(174, 44);
            this.but_ubdateCategory.TabIndex = 3;
            this.but_ubdateCategory.Text = "Update Category";
            this.but_ubdateCategory.UseVisualStyleBackColor = true;
            this.but_ubdateCategory.Click += new System.EventHandler(this.but_ubdateCategory_Click);
            // 
            // btn_UpdateP
            // 
            this.btn_UpdateP.Location = new System.Drawing.Point(440, 311);
            this.btn_UpdateP.Name = "btn_UpdateP";
            this.btn_UpdateP.Size = new System.Drawing.Size(123, 43);
            this.btn_UpdateP.TabIndex = 4;
            this.btn_UpdateP.Text = "Updte Producte";
            this.btn_UpdateP.UseVisualStyleBackColor = true;
            this.btn_UpdateP.Click += new System.EventHandler(this.btn_UpdateP_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(612, 313);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(107, 47);
            this.btn_DeleteProduct.TabIndex = 5;
            this.btn_DeleteProduct.Text = "Delete Product";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.Location = new System.Drawing.Point(12, 369);
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.Size = new System.Drawing.Size(140, 41);
            this.DeleteCategory.TabIndex = 6;
            this.DeleteCategory.Text = "Delete Category";
            this.DeleteCategory.UseVisualStyleBackColor = true;
            this.DeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(207, 369);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(94, 40);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Accounts";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(326, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(44, 16);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 444);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.DeleteCategory);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_UpdateP);
            this.Controls.Add(this.but_ubdateCategory);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.but_AddP);
            this.Controls.Add(this.DGVhome);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVhome;
        private System.Windows.Forms.Button but_AddP;
        private System.Windows.Forms.Button AddCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button but_ubdateCategory;
        private System.Windows.Forms.Button btn_UpdateP;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button DeleteCategory;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label lblWelcome;
    }
}

