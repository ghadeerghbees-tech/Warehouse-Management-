namespace Warehouse_Management__
{
    partial class AddProduct
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.but_Add = new System.Windows.Forms.Button();
            this.CMB_Add = new System.Windows.Forms.ComboBox();
            this.txt_PriceW = new System.Windows.Forms.TextBox();
            this.txt_PriceS = new System.Windows.Forms.TextBox();
            this.TB_Qun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(317, 85);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(23, 3, 5, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(327, 22);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.TextChanged += new System.EventHandler(this.Add_Name);
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(417, 367);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(130, 36);
            this.but_Add.TabIndex = 1;
            this.but_Add.Text = "Add Product";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // CMB_Add
            // 
            this.CMB_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Add.FormattingEnabled = true;
            this.CMB_Add.Location = new System.Drawing.Point(317, 316);
            this.CMB_Add.Name = "CMB_Add";
            this.CMB_Add.Size = new System.Drawing.Size(327, 24);
            this.CMB_Add.TabIndex = 2;
            this.CMB_Add.SelectedIndexChanged += new System.EventHandler(this.CMB_Add_SelectedIndexChanged);
            // 
            // txt_PriceW
            // 
            this.txt_PriceW.Location = new System.Drawing.Point(317, 145);
            this.txt_PriceW.Name = "txt_PriceW";
            this.txt_PriceW.Size = new System.Drawing.Size(327, 22);
            this.txt_PriceW.TabIndex = 3;
            // 
            // txt_PriceS
            // 
            this.txt_PriceS.Location = new System.Drawing.Point(317, 204);
            this.txt_PriceS.Name = "txt_PriceS";
            this.txt_PriceS.Size = new System.Drawing.Size(327, 22);
            this.txt_PriceS.TabIndex = 4;
            // 
            // TB_Qun
            // 
            this.TB_Qun.Location = new System.Drawing.Point(317, 258);
            this.TB_Qun.Name = "TB_Qun";
            this.TB_Qun.Size = new System.Drawing.Size(327, 22);
            this.TB_Qun.TabIndex = 5;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 512);
            this.Controls.Add(this.TB_Qun);
            this.Controls.Add(this.txt_PriceS);
            this.Controls.Add(this.txt_PriceW);
            this.Controls.Add(this.CMB_Add);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.txt_Name);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.ComboBox CMB_Add;
        private System.Windows.Forms.TextBox txt_PriceW;
        private System.Windows.Forms.TextBox txt_PriceS;
        private System.Windows.Forms.TextBox TB_Qun;
    }
}