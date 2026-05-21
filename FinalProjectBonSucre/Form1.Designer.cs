namespace FinalProjectBonSucre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpNewReview = new GroupBox();
            lblSelectCustomer = new Label();
            cmbCustomer = new ComboBox();
            lblSelectDessert = new Label();
            cmbDessert = new ComboBox();
            lblReviewScore = new Label();
            txtScore = new TextBox();
            btnAddReview = new Button();
            btnAddNewCustomerForm = new Button();
            btnAddNewDessertForm = new Button();
            grpNewReview.SuspendLayout();
            SuspendLayout();
            // 
            // grpNewReview
            // 
            grpNewReview.BackColor = SystemColors.Control;
            grpNewReview.Controls.Add(btnAddReview);
            grpNewReview.Controls.Add(txtScore);
            grpNewReview.Controls.Add(lblReviewScore);
            grpNewReview.Controls.Add(cmbDessert);
            grpNewReview.Controls.Add(lblSelectDessert);
            grpNewReview.Controls.Add(cmbCustomer);
            grpNewReview.Controls.Add(lblSelectCustomer);
            grpNewReview.Location = new Point(41, 40);
            grpNewReview.Name = "grpNewReview";
            grpNewReview.Size = new Size(618, 594);
            grpNewReview.TabIndex = 0;
            grpNewReview.TabStop = false;
            grpNewReview.Text = "New Review";
            // 
            // lblSelectCustomer
            // 
            lblSelectCustomer.AutoSize = true;
            lblSelectCustomer.Location = new Point(46, 66);
            lblSelectCustomer.Name = "lblSelectCustomer";
            lblSelectCustomer.Size = new Size(193, 32);
            lblSelectCustomer.TabIndex = 0;
            lblSelectCustomer.Text = "Select Customer:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(316, 63);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(242, 40);
            cmbCustomer.TabIndex = 1;
            // 
            // lblSelectDessert
            // 
            lblSelectDessert.AutoSize = true;
            lblSelectDessert.Location = new Point(70, 176);
            lblSelectDessert.Name = "lblSelectDessert";
            lblSelectDessert.Size = new Size(169, 32);
            lblSelectDessert.TabIndex = 2;
            lblSelectDessert.Text = "Select Dessert:";
            // 
            // cmbDessert
            // 
            cmbDessert.FormattingEnabled = true;
            cmbDessert.Location = new Point(316, 173);
            cmbDessert.Name = "cmbDessert";
            cmbDessert.Size = new Size(242, 40);
            cmbDessert.TabIndex = 3;
            // 
            // lblReviewScore
            // 
            lblReviewScore.AutoSize = true;
            lblReviewScore.Location = new Point(80, 292);
            lblReviewScore.Name = "lblReviewScore";
            lblReviewScore.Size = new Size(159, 32);
            lblReviewScore.TabIndex = 4;
            lblReviewScore.Text = "Review Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(316, 289);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(242, 39);
            txtScore.TabIndex = 5;
            // 
            // btnAddReview
            // 
            btnAddReview.BackColor = SystemColors.GradientInactiveCaption;
            btnAddReview.Font = new Font("Segoe UI", 12F);
            btnAddReview.ForeColor = Color.White;
            btnAddReview.Location = new Point(172, 406);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(244, 108);
            btnAddReview.TabIndex = 6;
            btnAddReview.Text = "Submit";
            btnAddReview.UseVisualStyleBackColor = false;
            // 
            // btnAddNewCustomerForm
            // 
            btnAddNewCustomerForm.BackColor = Color.Green;
            btnAddNewCustomerForm.Font = new Font("Segoe UI", 12F);
            btnAddNewCustomerForm.ForeColor = Color.White;
            btnAddNewCustomerForm.Location = new Point(705, 98);
            btnAddNewCustomerForm.Name = "btnAddNewCustomerForm";
            btnAddNewCustomerForm.Size = new Size(308, 150);
            btnAddNewCustomerForm.TabIndex = 1;
            btnAddNewCustomerForm.Text = "Add New Customer";
            btnAddNewCustomerForm.UseVisualStyleBackColor = false;
            // 
            // btnAddNewDessertForm
            // 
            btnAddNewDessertForm.BackColor = Color.Green;
            btnAddNewDessertForm.Font = new Font("Segoe UI", 12F);
            btnAddNewDessertForm.ForeColor = Color.White;
            btnAddNewDessertForm.Location = new Point(705, 406);
            btnAddNewDessertForm.Name = "btnAddNewDessertForm";
            btnAddNewDessertForm.Size = new Size(308, 148);
            btnAddNewDessertForm.TabIndex = 2;
            btnAddNewDessertForm.Text = "Add New Dessert";
            btnAddNewDessertForm.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 690);
            Controls.Add(btnAddNewDessertForm);
            Controls.Add(btnAddNewCustomerForm);
            Controls.Add(grpNewReview);
            Name = "Form1";
            Text = "Bon Sucre";
            Load += Form1_Load;
            grpNewReview.ResumeLayout(false);
            grpNewReview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNewReview;
        private Button btnAddReview;
        private TextBox txtScore;
        private Label lblReviewScore;
        private ComboBox cmbDessert;
        private Label lblSelectDessert;
        private ComboBox cmbCustomer;
        private Label lblSelectCustomer;
        private Button btnAddNewCustomerForm;
        private Button btnAddNewDessertForm;
    }
}
