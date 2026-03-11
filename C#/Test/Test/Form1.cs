using Microsoft.Data.SqlClient ;
namespace Test
{
    public partial class Form1 : Form
    {

        SqlConnection sqlCn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection("Data source=.;Initial Catalog=Northwind;Integrated Security=true;Encrypt=false;");
            sqlCn.Open();
        }
    }
}
