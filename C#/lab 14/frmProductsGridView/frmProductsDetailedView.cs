using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frmProductsGridView
{
    public partial class frmProductsDetailedView : Form
    {
        public frmProductsDetailedView()
        {
            InitializeComponent();
            this.Load += frmProductsDetailedView_Load;
        }

        EmployeeList emps;
        List<Employee> deletedEmps = new();
        BindingSource binSource = new BindingSource();
        BindingNavigator nav;

        private void frmProductsDetailedView_Load(object sender, EventArgs e)
        {
            emps = EmployeeManager.SelectALLEmployees();
            binSource.DataSource = emps;

            nav = new BindingNavigator(true);
            nav.BindingSource = binSource;
            nav.Dock = DockStyle.Top;
            this.Controls.Add(nav);
            nav.BringToFront();

            ToolStripButton btnSave = new ToolStripButton("Save All");
            btnSave.Click += (s, ev) => SaveData();
            nav.Items.Add(new ToolStripSeparator());
            nav.Items.Add(btnSave);

            IdValue.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            numJobLevel.DataBindings.Clear();
            txtJobId.DataBindings.Clear();

            IdValue.DataBindings.Add("Text", binSource, "EmpID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFirstName.DataBindings.Add("Text", binSource, "FName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLastName.DataBindings.Add("Text", binSource, "LName", true, DataSourceUpdateMode.OnPropertyChanged);
            numJobLevel.DataBindings.Add("Value", binSource, "JobLevel", true, DataSourceUpdateMode.OnPropertyChanged);
            txtJobId.DataBindings.Add("Text", binSource, "JobID", true, DataSourceUpdateMode.OnPropertyChanged);

            nav.DeleteItem.MouseDown += (s, ev) =>
            {
                if (binSource.Current is Employee emp)
                {
                    emp.State = EntitySate.Deleted;
                    deletedEmps.Add(emp);
                }
            };
        }

        private void SaveData()
        {
            this.Validate();
            binSource.EndEdit();

            foreach (var emp in emps)
            {
                if (emp.State == EntitySate.Added)
                {
                    if (EmployeeManager.InsertEmployee(emp)) emp.State = EntitySate.UnChanged;
                }
                else if (emp.State == EntitySate.Modified)
                {
                    if (EmployeeManager.UpdateEmployee(emp)) emp.State = EntitySate.UnChanged;
                }
            }

            foreach (var emp in deletedEmps)
            {
                EmployeeManager.DeleteEmployee(emp.EmpID);
            }

            deletedEmps.Clear();
            MessageBox.Show("Changes Saved to Database");
        }

        private void btnPrev_Click(object sender, EventArgs e) => binSource.MovePrevious();

        private void btnNext_Click(object sender, EventArgs e) => binSource.MoveNext();
    }
}