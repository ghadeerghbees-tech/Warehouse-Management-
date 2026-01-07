namespace Warehouse_Management__
{
    partial class UpdateCategory
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
            this.CB_categories = new System.Windows.Forms.ComboBox();
            this.TB_category = new System.Windows.Forms.TextBox();
            this.but_update = new System.Windows.Forms.Button();
            this.CB_inter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CB_categories
            // 
            this.CB_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_categories.FormattingEnabled = true;
            this.CB_categories.Location = new System.Drawing.Point(180, 125);
            this.CB_categories.Name = "CB_categories";
            this.CB_categories.Size = new System.Drawing.Size(389, 24);
            this.CB_categories.TabIndex = 0;
            // 
            // TB_category
            // 
            this.TB_category.Location = new System.Drawing.Point(180, 171);
            this.TB_category.Name = "TB_category";
            this.TB_category.Size = new System.Drawing.Size(389, 22);
            this.TB_category.TabIndex = 1;
            // 
            // but_update
            // 
            this.but_update.Location = new System.Drawing.Point(305, 278);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(131, 69);
            this.but_update.TabIndex = 2;
            this.but_update.Text = "Update Category";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // CB_inter
            // 
            this.CB_inter.AutoSize = true;
            this.CB_inter.Location = new System.Drawing.Point(275, 199);
            this.CB_inter.Name = "CB_inter";
            this.CB_inter.Size = new System.Drawing.Size(215, 20);
            this.CB_inter.TabIndex = 3;
            this.CB_inter.Text = "Interchangeable and returnable";
            this.CB_inter.UseVisualStyleBackColor = true;
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_inter);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.TB_category);
            this.Controls.Add(this.CB_categories);
            this.Name = "UpdateCategory";
            this.Text = "UpdateCategory";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_categories;
        private System.Windows.Forms.TextBox TB_category;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.CheckBox CB_inter;
    }
}