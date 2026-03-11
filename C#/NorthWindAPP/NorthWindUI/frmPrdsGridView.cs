using BLL.EntityLists;
using BLL.EntityManagers;

namespace NorthWindUI
{
    public partial class frmPrdsGridView : Form
    {
        public frmPrdsGridView()
        {
            InitializeComponent();

        }
        ProductList Prds;
        BindingSource PrdBindingSource;
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prds = ProductManager.SelectALLProducts();
            PrdBindingSource = new BindingSource(Prds, "");

            grdViewPrds.DataSource = PrdBindingSource;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
