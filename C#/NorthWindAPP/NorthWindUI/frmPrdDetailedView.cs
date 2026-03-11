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
    public partial class frmPrdDetailedView : Form
    {
        public frmPrdDetailedView()
        {
            InitializeComponent();
        }
        BindingNavigator PrdBindingNavigator;
        private void frmPrdDetailedView_Load(object sender, EventArgs e)
        {
            ProductList Prds = ProductManager.SelectALLProducts();
            prdBindingSource = new(Prds, "");

            prdBindingSource.AddingNew += (sender, e) => e.NewObject = new Product() { ProductName = "",  State = EntitySate.Added, UnitPrice = 10 };


            PrdBindingNavigator = new BindingNavigator(prdBindingSource);

            PrdBindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(PrdBindingNavigator);

            lblProductID.DataBindings.Add("Text", prdBindingSource, "ProductID");
            txtProductName.DataBindings.Add("Text", prdBindingSource, "ProductName");
            numUnitPrice.DataBindings.Add("Value", prdBindingSource, "UnitPrice");

        }
    }
}
