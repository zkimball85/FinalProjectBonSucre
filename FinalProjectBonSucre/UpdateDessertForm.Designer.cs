namespace FinalProjectBonSucre
{
    partial class UpdateDessertForm
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
            lblDessertName = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            btnUpdateDessert = new Button();
            SuspendLayout();
            // 
            // lblDessertName
            // 
            lblDessertName.AutoSize = true;
            lblDessertName.Location = new Point(39, 32);
            lblDessertName.Name = "lblDessertName";
            lblDessertName.Size = new Size(165, 32);
            lblDessertName.TabIndex = 0;
            lblDessertName.Text = "Dessert name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(134, 116);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 32);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(89, 204);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(115, 32);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            lblCategory.Click += lblCategory_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(237, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(237, 113);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(237, 201);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(242, 40);
            cmbCategory.TabIndex = 5;
            // 
            // btnUpdateDessert
            // 
            btnUpdateDessert.BackColor = Color.Yellow;
            btnUpdateDessert.Font = new Font("Segoe UI", 12F);
            btnUpdateDessert.ForeColor = Color.Black;
            btnUpdateDessert.Location = new Point(134, 296);
            btnUpdateDessert.Name = "btnUpdateDessert";
            btnUpdateDessert.Size = new Size(254, 108);
            btnUpdateDessert.TabIndex = 6;
            btnUpdateDessert.Text = "Update";
            btnUpdateDessert.UseVisualStyleBackColor = false;
            // 
            // UpdateDessertForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 454);
            Controls.Add(btnUpdateDessert);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblDessertName);
            Name = "UpdateDessertForm";
            Text = "UpdateDessertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDessertName;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox txtName;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private Button btnUpdateDessert;
    }
}