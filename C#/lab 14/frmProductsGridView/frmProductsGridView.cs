using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;
using System.Diagnostics;

namespace frmProductsGridView
{
    public partial class frmProductsGridView : Form
    {
        public frmProductsGridView()
        {
            InitializeComponent();
            grdViewPrds.UserDeletingRow += grdViewPrds_UserDeletingRow;
        }

        EmployeeList emps;
        BindingSource binSource = new BindingSource();
        List<Employee> deletedEmps = new();
        private void frmProductsGridView_Load(object sender, EventArgs e)
        {
            emps = EmployeeManager.SelectALLEmployees();
            binSource.DataSource = emps;
            grdViewPrds.DataSource = binSource;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)

        {
            emps = EmployeeManager.SelectALLEmployees();
            binSource.DataSource = emps;
            grdViewPrds.DataSource = binSource;
        }
        private void grdViewPrds_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is Employee emp)
            {
                emp.State = EntitySate.Deleted;
                deletedEmps.Add(emp);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdViewPrds.EndEdit();
            binSource.EndEdit();

            foreach (var emp in emps)
            {
                if (emp.State == EntitySate.Added)
                {
                    if (EmployeeManager.InsertEmployee(emp))
                    {

                        emp.State = EntitySate.UnChanged;
                    }
                }
                else if (emp.State == EntitySate.Modified)
                {
                    if (EmployeeManager.UpdateEmployee(emp))
                    {
                        Trace.WriteLine($"Emp Update  {emp}");
                        emp.State = EntitySate.UnChanged;
                    }
                }
                           }

            foreach (var emp in deletedEmps)
            {
                if (emp.State == EntitySate.Deleted)
                {
                    if (EmployeeManager.DeleteEmployee(emp.EmpID))
                    {
                        
                    }
                }
            }

            deletedEmps.Clear(); 
            //Trace.WriteLine($"Emp Update  {emps[0]}");
            //emps[0].FName = "TEsssst";
            //EmployeeManager.UpdateEmployee(emps[0]);
            //Trace.WriteLine($"Emp Update  {emps[0]}");
            MessageBox.Show("All changes saved to database");
        }

        
    }
}
