namespace FinalProjectBonSucre
{
    partial class AddCustomerForm
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
            lblName = new Label();
            lblEmailAddress = new Label();
            lblDateOfBirth = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtDateOfBirth = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(61, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(202, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Name (Fullname):";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(96, 136);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(167, 32);
            lblEmailAddress.TabIndex = 1;
            lblEmailAddress.Text = "Email Address:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(108, 216);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(155, 32);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "Date of birth:";
            // 
            // txtName
            // 
            txtName.Location = new Point(305, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 39);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(305, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 39);
            txtEmail.TabIndex = 4;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(305, 213);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(276, 39);
            txtDateOfBirth.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(189, 310);
            button1.Name = "button1";
            button1.Size = new Size(256, 126);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 508);
            Controls.Add(button1);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblName);
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmailAddress;
        private Label lblDateOfBirth;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtDateOfBirth;
        private Button button1;
    }
}