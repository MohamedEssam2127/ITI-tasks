using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D13___WinForms
{
    public partial class frmProductsGridView : Form
    {
        public frmProductsGridView()
        {
            InitializeComponent();
        }

        SqlConnection sqlCn;
        SqlDataAdapter sqlDaPrds;

        DataTable dtEmployees = new();
        DataTable dtJobs = new();
        DataTable dtPublishers = new();
        SqlCommandBuilder commandBuilder;



        private void frmProductsGridView_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["pubs"].ConnectionString);

            sqlDaPrds = new SqlDataAdapter("Select * from employee", sqlCn);

             commandBuilder = new SqlCommandBuilder(sqlDaPrds);

            SqlDataAdapter daJobs = new SqlDataAdapter("Select job_id from jobs", sqlCn);
            daJobs.Fill(dtJobs);

            SqlDataAdapter daPubs = new SqlDataAdapter("Select pub_id from publishers", sqlCn);
            daPubs.Fill(dtPublishers);



            sqlDaPrds.Fill(dtEmployees);

            grdViewPrds.AutoGenerateColumns = false;

            grdViewPrds.Columns.AddRange(new DataGridViewColumn[]
            {
                CreateTextCol("emp_id", "Employee ID"),
                CreateTextCol("fname", "First Name"),
                 CreateTextCol("lname", " last Name"),
                CreateTextCol("job_lvl", "Job Level"),
                CreateComboCol("job_id", "Job ID", dtJobs, "job_id", "job_id"),
                CreateComboCol("pub_id", "Pub ID", dtPublishers, "pub_id", "pub_id"),
                CreateTextCol("hire_date", "Hire Date")
            });

            sqlDaPrds.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDaPrds.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDaPrds.DeleteCommand = commandBuilder.GetDeleteCommand();

        }

        private DataGridViewTextBoxColumn CreateTextCol(string dataProp, string header)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataProp,
                HeaderText = header,
              
            };
        }

        private DataGridViewComboBoxColumn CreateComboCol(string dataProp, string header,
            DataTable source, string display, string value)
        {
            return new DataGridViewComboBoxColumn
            {
                DataPropertyName = dataProp,
                HeaderText = header,
                DataSource = source,
                DisplayMember = display,
                ValueMember = value,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtEmployees.Clear();
            sqlDaPrds.Fill(dtEmployees);
            grdViewPrds.DataSource = dtEmployees;
            grdViewPrds.DataSource = dtEmployees;

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                grdViewPrds.EndEdit();

                
                if (dtEmployees.GetChanges() != null)
                {
                    int rowsAffected = sqlDaPrds.Update(dtEmployees);
                    MessageBox.Show($"{rowsAffected} Rows Saved Successfully");
                }
                else
                {
                    MessageBox.Show("No changes detected to save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
