namespace Warehouse_Management__
{
    partial class AddCategory
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
            this.TB_addcategory = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.CB_inter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TB_addcategory
            // 
            this.TB_addcategory.Location = new System.Drawing.Point(135, 90);
            this.TB_addcategory.Name = "TB_addcategory";
            this.TB_addcategory.Size = new System.Drawing.Size(292, 22);
            this.TB_addcategory.TabIndex = 0;
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(234, 259);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 2;
            this.but_add.Text = "Add Category";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // CB_inter
            // 
            this.CB_inter.AutoSize = true;
            this.CB_inter.Location = new System.Drawing.Point(166, 144);
            this.CB_inter.Name = "CB_inter";
            this.CB_inter.Size = new System.Drawing.Size(215, 20);
            this.CB_inter.TabIndex = 3;
            this.CB_inter.Text = "Interchangeable and returnable";
            this.CB_inter.UseVisualStyleBackColor = true;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 344);
            this.Controls.Add(this.CB_inter);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.TB_addcategory);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_addcategory;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.CheckBox CB_inter;
    }
}