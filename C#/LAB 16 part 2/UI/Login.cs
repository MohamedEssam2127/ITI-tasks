using DAL;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnClose.Click += (s, e) => Application.Exit();
        }

        //HotelContext Context = new HotelContext();

        ReservationManagment manager = new ReservationManagment();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var acc1 = manager.Authenticate1(username,password);

            if (acc1 != null)
            {
                Frontend frontForm = new Frontend();
               // frontForm.FormClosed += (s, args) => Application.Exit();

                frontForm.Show();
                this.Hide();
               
            }
            else
            {
                var acc2 = manager.Authenticate2(username, password); 

                if (acc2 != null)
                {

                    Kitchen kitchenForm = new Kitchen();

                    
                   // kitchenForm.FormClosed += (s, args) => Application.Exit();

                    kitchenForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid   Email or password  ");

                }

            }
        }

        private void btnLicense_Click(object sender, EventArgs e)
        {
            License licenseForm = new License();
            licenseForm.ShowDialog(); 
        }
    }
}
