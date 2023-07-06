namespace Projeto_LOGIN
{
    public partial class frmLOGIN : Form
    {
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrinc = new frmPrincipal();
            frmPrinc.Show();
        }

        private void frmLOGIN_Load(object sender, EventArgs e)
        {
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
        }
    }
}