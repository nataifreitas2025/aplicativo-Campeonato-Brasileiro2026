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
    public partial class frmTelaAtualizar : Form
    {
        private static readonly HttpClient client = new HttpClient();

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

        private async void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_Atualizar.CurrentRow == null)
            {
                MessageBox.Show("Selecione um clube na tabela para atualizar.");
                return;
            }


            int id = Convert.ToInt32(dgv_Atualizar.CurrentRow.Cells[0].Value);

            string rota = "";
            switch (cb_SerieAtualizar.Text)
            {
                case "Série A":
                    rota = $"http://127.0.0.1:5000/Serie_A/{id}";
                    break;
                case "Série B":
                    rota = $"http://127.0.0.1:5000/Serie_B/{id}";
                    break;
                case "Série C":
                    rota = $"http://127.0.0.1:5000/Serie_C/{id}";
                    break;
                case "Série D":
                    rota = $"http://127.0.0.1:5000/Serie_D/{id}";
                    break;
                default:
                    MessageBox.Show("Selecione uma série.");
                    return;
            }

            if (!int.TryParse(txt_Pontos.Text, out int pontos) ||
                !int.TryParse(txt_Posicao.Text, out int posicao) ||
                !int.TryParse(txt_Jogos.Text, out int jogos) ||
                !int.TryParse(txt_Saldo.Text, out int saldo) ||
                !int.TryParse(txt_Vitorias.Text, out int vitorias) ||
                !int.TryParse(txt_Empate.Text, out int empates) ||
                !int.TryParse(txt_Derrota.Text, out int derrotas) ||
                !int.TryParse(txt_Gols.Text, out int golsPro) ||
                !int.TryParse(txt_Contra.Text, out int golsContra))
            {
                MessageBox.Show("Verifique se todos os campos numéricos estão preenchidos corretamente.");
                return;
            }

            var clube = new
            {
                NomeClube = txt_Nome.Text,
                PontosClube = pontos,
                PossicaoClube = posicao,
                JogosClube = jogos,
                SaldoGols = saldo,
                VitoriasClube = vitorias,
                EmpateClube = empates,
                DerrotaClube = derrotas,
                GolsProClube = golsPro,
                GolsContraClube = golsContra
            };

            try
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(clube);
                StringContent conteudo = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(rota, conteudo);

                if (response.IsSuccessStatusCode) // 204 também é IsSuccessStatusCode = true
                {
                    MessageBox.Show("Clube atualizado com sucesso!");
                    switch (cb_SerieAtualizar.Text)
                    {
                        case "Série A": await SerieA(); break;
                        case "Série B": await SerieB(); break;
                        case "Série C": await SerieC(); break;
                        case "Série D": await SerieD(); break;
                    }
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void cb_SerieAtualizar_SelectedValueChanged(object sender, EventArgs e)
        {
            string serie = cb_SerieAtualizar.Text;

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

                        dgv_Atualizar.DataSource = dados;
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

                        dgv_Atualizar.DataSource = dados;
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

                        dgv_Atualizar.DataSource = dados;
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

                        dgv_Atualizar.DataSource = dados;
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

        private void dgv_Atualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgv_Atualizar.Rows[e.RowIndex];

                txt_Nome.Text = linha.Cells["NomeClube"].Value.ToString();
                txt_Pontos.Text = linha.Cells["PontosClube"].Value.ToString();
                txt_Jogos.Text = linha.Cells["JogosClube"].Value.ToString();
                txt_Posicao.Text = linha.Cells["PossicaoClube"].Value.ToString();
                txt_Saldo.Text = linha.Cells["SaldoGols"].Value.ToString();
                txt_Vitorias.Text = linha.Cells["VitoriasClube"].Value.ToString();
                txt_Empate.Text = linha.Cells["EmpateClube"].Value.ToString();
                txt_Derrota.Text = linha.Cells["DerrotaClube"].Value.ToString();
                txt_Gols.Text = linha.Cells["golsProClube"].Value.ToString();
                txt_Contra.Text = linha.Cells["GolsContraClube"].Value.ToString();
            }
        }

        private async void btn_Inserir_Click(object sender, EventArgs e)
        {
            var clube = new
            {

                NomeClube = txt_Nome.Text,
                PontosClube = int.Parse(txt_Pontos.Text),
                PossicaoClube = int.Parse(txt_Posicao.Text),
                JogosClube = int.Parse(txt_Jogos.Text),
                SaldoGols = int.Parse(txt_Saldo.Text),
                VitoriasClube = int.Parse(txt_Vitorias.Text),
                EmpateClube = int.Parse(txt_Empate.Text),
                DerrotaClube = int.Parse(txt_Derrota.Text),
                GolsProClube = int.Parse(txt_Gols.Text),
                GolsContraClube = int.Parse(txt_Contra.Text),


                SerieClube = cb_SerieAtualizar.Text
            };

            string json = JsonConvert.SerializeObject(clube);

            string rota = "";

            switch (cb_SerieAtualizar.Text)
            {
                case "Série A":
                    rota = "http://127.0.0.1:5000/Serie_A";
                    break;

                case "Série B":
                    rota = "http://127.0.0.1:5000/Serie_B";
                    break;

                case "Série C":
                    rota = "http://127.0.0.1:5000/Serie_C";
                    break;

                case "Série D":
                    rota = "http://127.0.0.1:5000/Serie_D";
                    break;

                default:
                    MessageBox.Show("Selecione uma série.");
                    return;
            }

            using (HttpClient client = new HttpClient())
            {
                var conteudo = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage resposta = await client.PostAsync(
                rota,
                conteudo
                );

                string retorno = await resposta.Content.ReadAsStringAsync();

                if (resposta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Clube cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o clube.");
                }
            }

        }

        private async void btn_Apagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente excluir este clube?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string rota = "";

            switch (cb_SerieAtualizar.Text)
            {
                case "Série A":
                    rota = "http://127.0.0.1:5000/Serie_A";
                    break;

                case "Série B":
                    rota = "http://127.0.0.1:5000/Serie_B";
                    break;

                case "Série C":
                    rota = "http://127.0.0.1:5000/Serie_C";
                    break;

                case "Série D":
                    rota = "http://127.0.0.1:5000/Serie_D";
                    break;

                default:
                    MessageBox.Show("Selecione uma série.");
                    return;
            }

            using (HttpClient client = new HttpClient())
            {

                int id = Convert.ToInt32(dgv_Atualizar.CurrentRow.Cells[0].Value);

                HttpResponseMessage response = await client.DeleteAsync($"{rota}/{id}");


                try
                {

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Clube excluído com sucesso!");

                        switch (cb_SerieAtualizar.Text)
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
                        }
                    }
                    else
                    {
                        MessageBox.Show(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void frmTelaAtualizar_Load(object sender, EventArgs e)
        {

        }

        private async void txt_PesquisarNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txt_PesquisarNome.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                switch (cb_SerieAtualizar.Text)
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
                }
                return;
            }

            string apiUrl = "";

            switch (cb_SerieAtualizar.Text)
            {
                case "Série A":
                    apiUrl = ApiRotasController.PesquisarSerie_A + nome;
                    break;

                case "Série B":
                    apiUrl = ApiRotasController.PesquisarSerie_B + nome;
                    break;

                case "Série C":
                    apiUrl = ApiRotasController.PesquisarSerie_C + nome;
                    break;

                case "Série D":
                    apiUrl = ApiRotasController.PesquisarSerie_D + nome;
                    break;

                default:
                    return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();

                        switch (cb_SerieAtualizar.Text)
                        {
                            case "Série A":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieAModel>>(json);
                                break;

                            case "Série B":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieBModel>>(json);
                                break;

                            case "Série C":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieCModel>>(json);
                                break;

                            case "Série D":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieDModel>>(json);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void txt_PesquisarPosicao_TextChanged(object sender, EventArgs e)
        {
            string posicao = txt_PesquisarPosicao.Text.Trim();

            if (string.IsNullOrEmpty(posicao))
            {
                switch (cb_SerieAtualizar.Text)
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
                }
                return;
            }

            string apiUrl = "";

            switch (cb_SerieAtualizar.Text)
            {
                case "Série A":
                    apiUrl = ApiRotasController.PesquisarPosicao_A + posicao;
                    break;

                case "Série B":
                    apiUrl = ApiRotasController.PesquisarPosicao_B + posicao;
                    break;

                case "Série C":
                    apiUrl = ApiRotasController.PesquisarPosicao_C + posicao;
                    break;

                case "Série D":
                    apiUrl = ApiRotasController.PesquisarPosicao_D + posicao;
                    break;

                default:
                    return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();

                        switch (cb_SerieAtualizar.Text)
                        {
                            case "Série A":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieAModel>>(json);
                                break;

                            case "Série B":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieBModel>>(json);
                                break;

                            case "Série C":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieCModel>>(json);
                                break;

                            case "Série D":
                                dgv_Atualizar.DataSource = JsonConvert.DeserializeObject<List<ConsultarSerieDModel>>(json);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

        
    
