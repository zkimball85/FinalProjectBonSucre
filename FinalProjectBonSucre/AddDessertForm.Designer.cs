namespace FinalProjectBonSucre
{
    partial class AddDessertForm
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
            btnSaveDessert = new Button();
            lblDessertName = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // btnSaveDessert
            // 
            btnSaveDessert.BackColor = Color.Green;
            btnSaveDessert.Font = new Font("Segoe UI", 12F);
            btnSaveDessert.ForeColor = Color.White;
            btnSaveDessert.Location = new Point(121, 294);
            btnSaveDessert.Name = "btnSaveDessert";
            btnSaveDessert.Size = new Size(252, 128);
            btnSaveDessert.TabIndex = 0;
            btnSaveDessert.Text = "Save";
            btnSaveDessert.UseVisualStyleBackColor = false;
            btnSaveDessert.Click += btnSaveDessert_Click;
            // 
            // lblDessertName
            // 
            lblDessertName.AutoSize = true;
            lblDessertName.Location = new Point(38, 36);
            lblDessertName.Name = "lblDessertName";
            lblDessertName.Size = new Size(165, 32);
            lblDessertName.TabIndex = 1;
            lblDessertName.Text = "Dessert name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(133, 122);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 32);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(88, 202);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(115, 32);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(219, 119);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Pastry", "Cake", "Ice Cream", "Candy" });
            cmbCategory.Location = new Point(219, 199);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(242, 40);
            cmbCategory.TabIndex = 6;
            // 
            // AddDessertForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 478);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblDessertName);
            Controls.Add(btnSaveDessert);
            Name = "AddDessertForm";
            Text = "AddDessertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveDessert;
        private Label lblDessertName;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox txtName;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
    }
}