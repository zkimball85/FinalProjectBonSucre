namespace FinalProjectBonSucre
{
    partial class ReviewForm
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
            lstReviews = new ListBox();
            lblCustomerName = new Label();
            lblDessertName = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // lstReviews
            // 
            lstReviews.FormattingEnabled = true;
            lstReviews.Location = new Point(28, 112);
            lstReviews.Name = "lstReviews";
            lstReviews.Size = new Size(728, 260);
            lstReviews.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(28, 42);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(193, 32);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblDessertName
            // 
            lblDessertName.AutoSize = true;
            lblDessertName.Location = new Point(324, 42);
            lblDessertName.Name = "lblDessertName";
            lblDessertName.Size = new Size(169, 32);
            lblDessertName.TabIndex = 2;
            lblDessertName.Text = "Dessert Name:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(633, 42);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(78, 32);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score:";
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 426);
            Controls.Add(lblScore);
            Controls.Add(lblDessertName);
            Controls.Add(lblCustomerName);
            Controls.Add(lstReviews);
            Name = "ReviewForm";
            Text = "ReviewForm";
            Load += ReviewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstReviews;
        private Label lblCustomerName;
        private Label lblDessertName;
        private Label lblScore;
    }
}