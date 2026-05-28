namespace FinalProjectBonSucre
{
    partial class UpdateCustomerForm
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
            btnUpdateCustomer = new Button();
            lblName = new Label();
            lblEmail = new Label();
            lblDateOfBirth = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtDateOfBirth = new TextBox();
            SuspendLayout();
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.Yellow;
            btnUpdateCustomer.Font = new Font("Segoe UI", 12F);
            btnUpdateCustomer.ForeColor = Color.Black;
            btnUpdateCustomer.Location = new Point(125, 302);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(252, 112);
            btnUpdateCustomer.TabIndex = 0;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += BtnUpdateCustomer_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(202, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Name (Fullname):";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(161, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(82, 198);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(155, 32);
            lblDateOfBirth.TabIndex = 3;
            lblDateOfBirth.Text = "Date of birth:";
            // 
            // txtName
            // 
            txtName.Location = new Point(261, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 5;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(261, 195);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(200, 39);
            txtDateOfBirth.TabIndex = 6;
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 484);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(btnUpdateCustomer);
            Name = "UpdateCustomerForm";
            Text = "UpdateCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateCustomer;
        private Label lblName;
        private Label lblEmail;
        private Label lblDateOfBirth;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtDateOfBirth;
    }
}