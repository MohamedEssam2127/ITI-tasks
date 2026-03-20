namespace UI
{
    partial class Login
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            lblUser = new Label();
            lblPass = new Label();
            btnLicense = new Button();
            pnlTopBorder = new Panel();
            btnClose = new Button();
            pnlTopBorder.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(50, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 34);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(50, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 34);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semilight", 22F);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(0, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 60);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Hotel System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 10F);
            lblUser.ForeColor = Color.FromArgb(44, 62, 80);
            lblUser.Location = new Point(50, 125);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(100, 23);
            lblUser.TabIndex = 5;
            lblUser.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.Font = new Font("Segoe UI", 10F);
            lblPass.ForeColor = Color.FromArgb(44, 62, 80);
            lblPass.Location = new Point(50, 205);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(100, 23);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password";
            // 
            // btnLicense
            // 
            btnLicense.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLicense.BackColor = Color.FromArgb(52, 152, 219);
            btnLicense.Cursor = Cursors.Hand;
            btnLicense.FlatAppearance.BorderSize = 0;
            btnLicense.FlatStyle = FlatStyle.Flat;
            btnLicense.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnLicense.ForeColor = Color.White;
            btnLicense.Location = new Point(310, 410);
            btnLicense.Name = "btnLicense";
            btnLicense.Size = new Size(80, 30);
            btnLicense.TabIndex = 0;
            btnLicense.Text = "LICENSE";
            btnLicense.UseVisualStyleBackColor = false;
            btnLicense.Click += btnLicense_Click;
            // 
            // pnlTopBorder
            // 
            pnlTopBorder.BackColor = Color.FromArgb(52, 152, 219);
            pnlTopBorder.Controls.Add(btnClose);
            pnlTopBorder.Dock = DockStyle.Top;
            pnlTopBorder.Location = new Point(0, 0);
            pnlTopBorder.Name = "pnlTopBorder";
            pnlTopBorder.Size = new Size(400, 30);
            pnlTopBorder.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(365, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            // 
            // Login
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 450);
            Controls.Add(btnLicense);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(lblUser);
            Controls.Add(lblTitle);
            Controls.Add(pnlTopBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pnlTopBorder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblTitle;
        private Label lblUser;
        private Label lblPass;
        private Button btnLicense;
        private Panel pnlTopBorder;
        private Button btnClose;

        #endregion
    }
}