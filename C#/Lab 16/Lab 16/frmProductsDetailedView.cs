using Lab_16.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_16
{
    public partial class frmProductsDetailedView : Form
    {
        public frmProductsDetailedView()
        {
            InitializeComponent();
        }

        
        pubsContext Context = new pubsContext();
        BindingSource binSource = new BindingSource();
        BindingNavigator nav;
        private void frmProductsDetailedView_Load(object sender, EventArgs e)
        {
            Context.Employees.Load();
            Context.Jobs.Load();
            binSource.DataSource = Context.Employees.Local.ToBindingList();

            SetupNavigator();
            SetupBindings();
            SetupJobsCombo();
        }

        void SetupNavigator()
        {
            nav = new BindingNavigator(true);

            nav.BindingSource = binSource;
            nav.Dock = DockStyle.Top;

            this.Controls.Add(nav);
            nav.BringToFront();

            ToolStripButton btnSave = new ToolStripButton("Save");

            btnSave.Click += (s, e) =>
            {
                this.Validate();
                binSource.EndEdit();
                Context.SaveChanges();
                MessageBox.Show("Saved");
            };

            nav.Items.Add(new ToolStripSeparator());
            nav.Items.Add(btnSave);
        }

        void SetupBindings()
        {
            IdValue.DataBindings.Add("Text", binSource, "EmpId");

            txtFirstName.DataBindings.Add("Text", binSource, "Fname");

            txtLastName.DataBindings.Add("Text", binSource, "Lname");

            numJobLevel.DataBindings.Add("Value", binSource, "JobLvl");
        }
        void SetupJobsCombo()
        {
            cmbJobId.DataSource = Context.Jobs.Local.ToBindingList();

            cmbJobId.DisplayMember = "JobDesc";

            cmbJobId.ValueMember = "JobId";

            cmbJobId.DataBindings.Add("SelectedValue", binSource, "JobId");
        }
    }
}
