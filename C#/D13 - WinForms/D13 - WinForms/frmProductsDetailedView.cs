using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace D13___WinForms
{
    public partial class frmProductsDetailedView : Form
    {
        public frmProductsDetailedView()
        {
            InitializeComponent();
            this.Load += frmProductsDetailedView_Load;
        }

        SqlConnection sqlCn;
     
        SqlDataAdapter sqlDaPrds;
        DataTable dtPrds = new();
        DataTable dtJobs = new();
        DataTable dtPubs = new();

        BindingSource prdBindingSource;
        BindingNavigator BindingNavigator;

        private void frmProductsDetailedView_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["pubs"].ConnectionString);

            sqlDaPrds = new SqlDataAdapter("Select * from employee", sqlCn);
            new SqlCommandBuilder(sqlDaPrds);

            SqlDataAdapter daJobs = new SqlDataAdapter("Select job_id from jobs", sqlCn);
            daJobs.Fill(dtJobs);

            SqlDataAdapter daPubs = new SqlDataAdapter("Select pub_id from publishers", sqlCn);
            daPubs.Fill(dtPubs);

            sqlDaPrds.Fill(dtPrds);

            prdBindingSource = new BindingSource(dtPrds, "");

            BindingNavigator = new BindingNavigator(prdBindingSource);
            
            BindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(BindingNavigator);


            ToolStripButton btnSave = new ToolStripButton("Save Changes");
            btnSave.Click += (s, ev) => SaveData();
            BindingNavigator.Items.Add(new ToolStripSeparator());
            BindingNavigator.Items.Add(btnSave);

            this.Controls.Add(BindingNavigator);

            IdValue.DataBindings.Add("Text", prdBindingSource, "emp_id");
            txtFirstName.DataBindings.Add("Text", prdBindingSource, "fname");
            txtLastName.DataBindings.Add("Text", prdBindingSource, "lname");
            numJobLevel.DataBindings.Add("Value", prdBindingSource, "job_lvl", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpHireDate.DataBindings.Add("Value", prdBindingSource, "hire_date", true, DataSourceUpdateMode.OnPropertyChanged);

            cmbJobId.DataSource = dtJobs;
            cmbJobId.DisplayMember = "job_id";
            //cmbJobId.ValueMember = "job_id";
            cmbJobId.DataBindings.Add("SelectedValue", prdBindingSource, "job_id", true, DataSourceUpdateMode.OnPropertyChanged);

            cmbPubId.DataSource = dtPubs;
            cmbPubId.DisplayMember = "pub_id";
            cmbPubId.ValueMember = "pub_id";
            cmbPubId.DataBindings.Add("SelectedValue", prdBindingSource, "pub_id", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveData()
        {
            try
            {
                prdBindingSource.EndEdit();
                sqlDaPrds.Update(dtPrds);
                MessageBox.Show("Changes saved to database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnPrev_Click(object sender, EventArgs e) => prdBindingSource.MovePrevious();

        private void btnNext_Click(object sender, EventArgs e) => prdBindingSource.MoveNext();
    }
}