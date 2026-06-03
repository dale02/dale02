namespace WinFormsAppPOS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            pnlMaintenance.Visible = true;
            pnlSales.Visible = false;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pnlMaintenance.Visible = false;
            pnlSales.Visible = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProduct pm = new frmProduct();
            pm.Show();
        }
    }
}
