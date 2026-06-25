namespace CampeonatoBrasileiro2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            frmPrincipal PaginaPrincipal = new frmPrincipal();
            PaginaPrincipal.Show();
            this.Hide();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
