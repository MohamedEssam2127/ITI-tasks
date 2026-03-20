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

        HotelContext Context = new HotelContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var acc1 = Context.Frontends.AsNoTracking().FirstOrDefault(u => u.Username == username && u.Password == password);

            if (acc1 != null)
            {
                MessageBox.Show("Welcome  Front ");
            }
            else
            {
                var acc2 = Context.Kitchens.AsNoTracking().FirstOrDefault(u => u.Username == username && u.Password == password);

                if (acc2 != null)
                {

                    Kitchen kitchenForm = new Kitchen();

                    
                    kitchenForm.FormClosed += (s, args) => Application.Exit();

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
