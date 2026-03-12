using Lab_16.Context;
using Microsoft.EntityFrameworkCore;

namespace Lab_16
{
    public partial class frmProductsGridView : Form
    {
        public frmProductsGridView()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => context.Dispose();
        }
        pubsContext context = new();
        private void frmProductsGridView_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            context.Employees.Load();
            context.Jobs.Load();
            grdViewPrds.DataSource = context.Employees.Local.ToBindingList();
            grdViewPrds.Columns["job"].Visible = false;

            grdViewPrds.Columns["jobId"].Visible = false;

            DataGridViewComboBoxColumn jobColumn = new DataGridViewComboBoxColumn();

            jobColumn.DataPropertyName = "JobId";
            jobColumn.HeaderText = "Job";
            jobColumn.DataSource = context.Jobs.Local.ToBindingList();
            jobColumn.DisplayMember = "JobDesc";
            jobColumn.ValueMember = "JobId";

            grdViewPrds.Columns.Add(jobColumn);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grdViewPrds.EndEdit(); 
            context.SaveChanges();
        }
    }
}
