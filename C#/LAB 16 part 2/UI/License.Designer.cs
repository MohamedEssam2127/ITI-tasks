namespace UI
{
    partial class License
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblLicenseTitle = new Label();
            txtLicenseText = new TextBox();
            btnBack = new Button();
            pnlTopBorder = new Panel();
            btnClose = new Button();
            pnlTopBorder.SuspendLayout();
            SuspendLayout();

            // pnlTopBorder
            pnlTopBorder.BackColor = Color.FromArgb(52, 152, 219);
            pnlTopBorder.Controls.Add(btnClose);
            pnlTopBorder.Dock = DockStyle.Top;
            pnlTopBorder.Location = new Point(0, 0);
            pnlTopBorder.Name = "pnlTopBorder";
            pnlTopBorder.Size = new Size(484, 30);

            // btnClose (X)
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(449, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 30);
            btnClose.Text = "X";

            // lblLicenseTitle
            lblLicenseTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblLicenseTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblLicenseTitle.Location = new Point(12, 45); // Moved down for the bar
            lblLicenseTitle.Name = "lblLicenseTitle";
            lblLicenseTitle.Size = new Size(460, 40);
            lblLicenseTitle.TabIndex = 10;
            lblLicenseTitle.Text = "Software License Information";
            lblLicenseTitle.TextAlign = ContentAlignment.MiddleCenter;

            // txtLicenseText
            txtLicenseText.BackColor = Color.White;
            txtLicenseText.BorderStyle = BorderStyle.None;
            txtLicenseText.Font = new Font("Segoe UI", 10F);
            txtLicenseText.Location = new Point(30, 100); // Moved down
            txtLicenseText.Multiline = true;
            txtLicenseText.Name = "txtLicenseText";
            txtLicenseText.ReadOnly = true;
            txtLicenseText.ScrollBars = ScrollBars.Vertical;
            txtLicenseText.Size = new Size(420, 220);
            txtLicenseText.TabIndex = 5;
            txtLicenseText.TabStop = false;
            txtLicenseText.Text = "HOTEL MANAGEMENT SYSTEM v1.0\r\n\r\n" +
      "This project implements a hybrid Data Access Layer for maximum efficiency:\r\n\r\n" +
      "- Language: C# (.NET)\r\n" +
      "- UI Framework: Windows Forms (Custom Flat Design)\r\n" +
      "- Database: SQL Server\r\n" +
      "- ORM (CRUD): Entity Framework Core (Insert, Update, Delete)\r\n" +
      "- Performance (Read): Dapper (High-speed SELECT operations)\r\n" +
      "- Architecture: N-Tier (DAL as a Class Library)\r\n" +
      "- Database Management: EF Migrations & Stored Procedures\r\n\r\n" +
      "Developed by: Mohamed Essam";

            // btnBack (Close Button at bottom)
            btnBack.BackColor = Color.FromArgb(52, 152, 219);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(165, 340); // Adjusted
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "CLOSE";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            // Form Configuration
            BackColor = Color.White;
            ClientSize = new Size(484, 410); // Slightly taller
            Controls.Add(pnlTopBorder);
            Controls.Add(lblLicenseTitle);
            Controls.Add(txtLicenseText);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None; // Borderless
            Name = "License";
            StartPosition = FormStartPosition.CenterParent;
            Text = "License Detail";
            pnlTopBorder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblLicenseTitle;
        private TextBox txtLicenseText;
        private Button btnBack;
        private Panel pnlTopBorder;
        private Button btnClose;

        #endregion
    }
}