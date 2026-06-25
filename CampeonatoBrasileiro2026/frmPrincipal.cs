using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampeonatoBrasileiro2026
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            frmConsultar NovaJanela = new frmConsultar();
            NovaJanela.FormClosed += (s, args) => Application.Exit();
            NovaJanela.Show();
            this.Hide();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            frmTelaAtualizar NovaJanela = new frmTelaAtualizar();
            NovaJanela.FormClosed += (s, args) => Application.Exit();
            NovaJanela.Show();
            this.Hide();
        }
    }
}
