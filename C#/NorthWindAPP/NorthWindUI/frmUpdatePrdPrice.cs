using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NorthWindUI
{
    public partial class frmUpdatePrdPrice : Form
    {
        public frmUpdatePrdPrice()
        {
            InitializeComponent();
        }
        BindingSource PrdBindingSrc;
        ProductList Prds;
        private void frmUpdatePrdPrice_Load(object sender, EventArgs e)
        {
            Prds = ProductManager.SelectALLProducts();
            PrdBindingSrc = new BindingSource(Prds, "");

            lstPrds.DataSource = PrdBindingSrc;
            lstPrds.DisplayMember = "ProductName";
            lstPrds.ValueMember = "ProductID";

            // numPrdPrice.DataBindings.Add("Value", PrdBindingSrc, "UnitPrice");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PrdBindingSrc.EndEdit();
            if (int.TryParse(lstPrds.SelectedValue?.ToString(), out int PrdID))
                this.Text = $"{ProductManager.UpdateProductPrice(PrdID, numPrdPrice.Value)}";
        }

        private void lstPrds_SelectedIndexChanged(object sender, EventArgs e)
        {
            numPrdPrice.Value = (lstPrds.SelectedItem as Product).UnitPrice.Value;
        }
    }
}
