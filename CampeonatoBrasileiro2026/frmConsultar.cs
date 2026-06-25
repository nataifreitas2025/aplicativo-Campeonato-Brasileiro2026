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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
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

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            frmPrincipal NovaJanela = new frmPrincipal();
            NovaJanela.FormClosed += (s, args) => Application.Exit();
            NovaJanela.Show();
            this.Hide();
        }
    }
}
