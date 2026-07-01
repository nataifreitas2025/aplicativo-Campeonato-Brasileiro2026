using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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

        private async void btn_Consultar_Click(object sender, EventArgs e)
        {
            string serie = cb_Serie.Text;

            switch (serie)
            {
                case "Série A":
                    await SerieA();
                    break;

                case "Série B":
                    await SerieB();
                    break;

                case "Série C":
                    await SerieC();
                    break;

                case "Série D":
                    await SerieD();
                    break;

                default:
                    MessageBox.Show("Selecione a Série.");
                    break;

             }
        }

        private async Task SerieD()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_D;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieDModel>>(jsonString);

                        dgv_Consultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieC()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_C;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieCModel>>(jsonString);

                        dgv_Consultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieB()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_B;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieBModel>>(jsonString);

                        dgv_Consultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieA()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_A;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieAModel>>(jsonString);

                        dgv_Consultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
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
