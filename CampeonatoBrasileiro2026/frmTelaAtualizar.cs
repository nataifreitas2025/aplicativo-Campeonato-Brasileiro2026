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
    public partial class frmTelaAtualizar : Form
    {
        public frmTelaAtualizar()
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
    }
}
