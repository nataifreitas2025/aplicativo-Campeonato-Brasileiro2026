namespace CampeonatoBrasileiro2026
{
    partial class frmTelaAtualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaAtualizar));
            pictureBox2 = new PictureBox();
            lbl_Atualizar = new Label();
            lbl_serie1 = new Label();
            cb_SerieAtualizar = new ComboBox();
            btn_Inserir = new Button();
            btn_Atualizar = new Button();
            btn_Apagar = new Button();
            lbl_Nome = new Label();
            txt_Nome = new TextBox();
            lbl_Pontos = new Label();
            txt_Pontos = new TextBox();
            lbl_Posicao = new Label();
            lbl_Jogos = new Label();
            lbl_Saldo = new Label();
            lbl_Vitorias = new Label();
            lbl_Empate = new Label();
            lbl_Derrota = new Label();
            lbl_Gols = new Label();
            lbl_Contra = new Label();
            txt_Posicao = new TextBox();
            txt_Jogos = new TextBox();
            txt_Saldo = new TextBox();
            txt_Vitorias = new TextBox();
            txt_Empate = new TextBox();
            txt_Derrota = new TextBox();
            txt_Gols = new TextBox();
            txt_Contra = new TextBox();
            dgv_Atualizar = new DataGridView();
            btn_Consultar = new Button();
            txt_PesquisarNome = new TextBox();
            txt_PesquisarPosicao = new TextBox();
            lbl_PesquisarNome = new Label();
            lbl_PesquisarPosicao = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Atualizar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 451);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lbl_Atualizar
            // 
            lbl_Atualizar.AutoSize = true;
            lbl_Atualizar.BackColor = Color.MidnightBlue;
            lbl_Atualizar.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Atualizar.ForeColor = SystemColors.ButtonHighlight;
            lbl_Atualizar.Location = new Point(43, 60);
            lbl_Atualizar.Name = "lbl_Atualizar";
            lbl_Atualizar.Size = new Size(136, 54);
            lbl_Atualizar.TabIndex = 9;
            lbl_Atualizar.Text = "Atualizar\r\n  Times\r\n";
            // 
            // lbl_serie1
            // 
            lbl_serie1.AutoSize = true;
            lbl_serie1.BackColor = Color.MidnightBlue;
            lbl_serie1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_serie1.ForeColor = Color.Transparent;
            lbl_serie1.Location = new Point(43, 149);
            lbl_serie1.Name = "lbl_serie1";
            lbl_serie1.Size = new Size(71, 22);
            lbl_serie1.TabIndex = 10;
            lbl_serie1.Text = "Serie:";
            // 
            // cb_SerieAtualizar
            // 
            cb_SerieAtualizar.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_SerieAtualizar.FormattingEnabled = true;
            cb_SerieAtualizar.Items.AddRange(new object[] { "Selecionar...", "Série A", "Série B", "Série C", "Série D" });
            cb_SerieAtualizar.Location = new Point(43, 174);
            cb_SerieAtualizar.Name = "cb_SerieAtualizar";
            cb_SerieAtualizar.Size = new Size(121, 23);
            cb_SerieAtualizar.TabIndex = 11;
            cb_SerieAtualizar.SelectedIndexChanged += cb_SerieAtualizar_SelectedValueChanged;
            cb_SerieAtualizar.SelectedValueChanged += cb_SerieAtualizar_SelectedValueChanged;
            // 
            // btn_Inserir
            // 
            btn_Inserir.BackColor = Color.LimeGreen;
            btn_Inserir.FlatStyle = FlatStyle.Popup;
            btn_Inserir.Location = new Point(43, 219);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(121, 35);
            btn_Inserir.TabIndex = 12;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.BackColor = Color.Yellow;
            btn_Atualizar.FlatStyle = FlatStyle.Popup;
            btn_Atualizar.Location = new Point(43, 269);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(121, 35);
            btn_Atualizar.TabIndex = 13;
            btn_Atualizar.Text = "Atualizar";
            btn_Atualizar.UseVisualStyleBackColor = false;
            btn_Atualizar.Click += btn_Atualizar_Click;
            // 
            // btn_Apagar
            // 
            btn_Apagar.BackColor = Color.Crimson;
            btn_Apagar.FlatStyle = FlatStyle.Popup;
            btn_Apagar.Location = new Point(43, 373);
            btn_Apagar.Name = "btn_Apagar";
            btn_Apagar.Size = new Size(121, 35);
            btn_Apagar.TabIndex = 14;
            btn_Apagar.Text = "Apagar";
            btn_Apagar.UseVisualStyleBackColor = false;
            btn_Apagar.Click += btn_Apagar_Click;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.BackColor = Color.Transparent;
            lbl_Nome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nome.Location = new Point(432, 20);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(73, 15);
            lbl_Nome.TabIndex = 16;
            lbl_Nome.Text = "Nome Time:";
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(432, 38);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(152, 23);
            txt_Nome.TabIndex = 17;
            // 
            // lbl_Pontos
            // 
            lbl_Pontos.AutoSize = true;
            lbl_Pontos.BackColor = Color.Transparent;
            lbl_Pontos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Pontos.Location = new Point(639, 20);
            lbl_Pontos.Name = "lbl_Pontos";
            lbl_Pontos.Size = new Size(81, 15);
            lbl_Pontos.TabIndex = 18;
            lbl_Pontos.Text = "Pontos Clube:";
            // 
            // txt_Pontos
            // 
            txt_Pontos.Location = new Point(639, 38);
            txt_Pontos.Name = "txt_Pontos";
            txt_Pontos.Size = new Size(152, 23);
            txt_Pontos.TabIndex = 19;
            // 
            // lbl_Posicao
            // 
            lbl_Posicao.AutoSize = true;
            lbl_Posicao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Posicao.Location = new Point(431, 80);
            lbl_Posicao.Name = "lbl_Posicao";
            lbl_Posicao.Size = new Size(93, 17);
            lbl_Posicao.TabIndex = 20;
            lbl_Posicao.Text = "Posição Clube:";
            // 
            // lbl_Jogos
            // 
            lbl_Jogos.AutoSize = true;
            lbl_Jogos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Jogos.Location = new Point(637, 80);
            lbl_Jogos.Name = "lbl_Jogos";
            lbl_Jogos.Size = new Size(83, 17);
            lbl_Jogos.TabIndex = 21;
            lbl_Jogos.Text = "Jogos Clube:";
            // 
            // lbl_Saldo
            // 
            lbl_Saldo.AutoSize = true;
            lbl_Saldo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Saldo.Location = new Point(432, 139);
            lbl_Saldo.Name = "lbl_Saldo";
            lbl_Saldo.Size = new Size(74, 17);
            lbl_Saldo.TabIndex = 22;
            lbl_Saldo.Text = "Saldo Gols:";
            // 
            // lbl_Vitorias
            // 
            lbl_Vitorias.AutoSize = true;
            lbl_Vitorias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Vitorias.Location = new Point(637, 139);
            lbl_Vitorias.Name = "lbl_Vitorias";
            lbl_Vitorias.Size = new Size(92, 17);
            lbl_Vitorias.TabIndex = 23;
            lbl_Vitorias.Text = "Vitorias Clube:";
            // 
            // lbl_Empate
            // 
            lbl_Empate.AutoSize = true;
            lbl_Empate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Empate.Location = new Point(432, 199);
            lbl_Empate.Name = "lbl_Empate";
            lbl_Empate.Size = new Size(92, 17);
            lbl_Empate.TabIndex = 24;
            lbl_Empate.Text = "Empate Clube:";
            // 
            // lbl_Derrota
            // 
            lbl_Derrota.AutoSize = true;
            lbl_Derrota.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Derrota.Location = new Point(636, 199);
            lbl_Derrota.Name = "lbl_Derrota";
            lbl_Derrota.Size = new Size(93, 17);
            lbl_Derrota.TabIndex = 25;
            lbl_Derrota.Text = "Derrota Clube:";
            // 
            // lbl_Gols
            // 
            lbl_Gols.AutoSize = true;
            lbl_Gols.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gols.Location = new Point(431, 254);
            lbl_Gols.Name = "lbl_Gols";
            lbl_Gols.Size = new Size(98, 17);
            lbl_Gols.TabIndex = 26;
            lbl_Gols.Text = "Gols Pro Clube:";
            // 
            // lbl_Contra
            // 
            lbl_Contra.AutoSize = true;
            lbl_Contra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Contra.Location = new Point(636, 254);
            lbl_Contra.Name = "lbl_Contra";
            lbl_Contra.Size = new Size(117, 17);
            lbl_Contra.TabIndex = 27;
            lbl_Contra.Text = "Gols Contra Clube:";
            // 
            // txt_Posicao
            // 
            txt_Posicao.Location = new Point(431, 100);
            txt_Posicao.Name = "txt_Posicao";
            txt_Posicao.Size = new Size(152, 23);
            txt_Posicao.TabIndex = 28;
            // 
            // txt_Jogos
            // 
            txt_Jogos.Location = new Point(637, 100);
            txt_Jogos.Name = "txt_Jogos";
            txt_Jogos.Size = new Size(152, 23);
            txt_Jogos.TabIndex = 29;
            // 
            // txt_Saldo
            // 
            txt_Saldo.Location = new Point(432, 159);
            txt_Saldo.Name = "txt_Saldo";
            txt_Saldo.Size = new Size(152, 23);
            txt_Saldo.TabIndex = 30;
            // 
            // txt_Vitorias
            // 
            txt_Vitorias.Location = new Point(637, 159);
            txt_Vitorias.Name = "txt_Vitorias";
            txt_Vitorias.Size = new Size(152, 23);
            txt_Vitorias.TabIndex = 31;
            // 
            // txt_Empate
            // 
            txt_Empate.Location = new Point(431, 218);
            txt_Empate.Name = "txt_Empate";
            txt_Empate.Size = new Size(152, 23);
            txt_Empate.TabIndex = 32;
            // 
            // txt_Derrota
            // 
            txt_Derrota.Location = new Point(636, 219);
            txt_Derrota.Name = "txt_Derrota";
            txt_Derrota.Size = new Size(152, 23);
            txt_Derrota.TabIndex = 33;
            // 
            // txt_Gols
            // 
            txt_Gols.Location = new Point(431, 274);
            txt_Gols.Name = "txt_Gols";
            txt_Gols.Size = new Size(152, 23);
            txt_Gols.TabIndex = 34;
            // 
            // txt_Contra
            // 
            txt_Contra.Location = new Point(636, 275);
            txt_Contra.Name = "txt_Contra";
            txt_Contra.Size = new Size(152, 23);
            txt_Contra.TabIndex = 35;
            // 
            // dgv_Atualizar
            // 
            dgv_Atualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Atualizar.Location = new Point(227, 321);
            dgv_Atualizar.Name = "dgv_Atualizar";
            dgv_Atualizar.Size = new Size(572, 130);
            dgv_Atualizar.TabIndex = 36;
            dgv_Atualizar.CellClick += dgv_Atualizar_CellClick;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.Honeydew;
            btn_Consultar.FlatStyle = FlatStyle.Popup;
            btn_Consultar.Location = new Point(43, 321);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(121, 35);
            btn_Consultar.TabIndex = 40;
            btn_Consultar.Text = "Consultar Tabela";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // txt_PesquisarNome
            // 
            txt_PesquisarNome.Location = new Point(233, 133);
            txt_PesquisarNome.Name = "txt_PesquisarNome";
            txt_PesquisarNome.Size = new Size(151, 23);
            txt_PesquisarNome.TabIndex = 41;
            txt_PesquisarNome.TextChanged += txt_PesquisarNome_TextChanged;
            // 
            // txt_PesquisarPosicao
            // 
            txt_PesquisarPosicao.Location = new Point(233, 198);
            txt_PesquisarPosicao.Name = "txt_PesquisarPosicao";
            txt_PesquisarPosicao.Size = new Size(149, 23);
            txt_PesquisarPosicao.TabIndex = 42;
            txt_PesquisarPosicao.TextChanged += txt_PesquisarPosicao_TextChanged;
            // 
            // lbl_PesquisarNome
            // 
            lbl_PesquisarNome.AutoSize = true;
            lbl_PesquisarNome.Location = new Point(233, 115);
            lbl_PesquisarNome.Name = "lbl_PesquisarNome";
            lbl_PesquisarNome.Size = new Size(117, 15);
            lbl_PesquisarNome.TabIndex = 43;
            lbl_PesquisarNome.Text = "Pesquisar Por Nome:";
            // 
            // lbl_PesquisarPosicao
            // 
            lbl_PesquisarPosicao.AutoSize = true;
            lbl_PesquisarPosicao.Location = new Point(233, 180);
            lbl_PesquisarPosicao.Name = "lbl_PesquisarPosicao";
            lbl_PesquisarPosicao.Size = new Size(125, 15);
            lbl_PesquisarPosicao.TabIndex = 44;
            lbl_PesquisarPosicao.Text = "Pesquisar por Posição:";
            // 
            // frmTelaAtualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_PesquisarPosicao);
            Controls.Add(lbl_PesquisarNome);
            Controls.Add(txt_PesquisarPosicao);
            Controls.Add(txt_PesquisarNome);
            Controls.Add(btn_Consultar);
            Controls.Add(dgv_Atualizar);
            Controls.Add(txt_Contra);
            Controls.Add(txt_Gols);
            Controls.Add(txt_Derrota);
            Controls.Add(txt_Empate);
            Controls.Add(txt_Vitorias);
            Controls.Add(txt_Saldo);
            Controls.Add(txt_Jogos);
            Controls.Add(txt_Posicao);
            Controls.Add(lbl_Contra);
            Controls.Add(lbl_Gols);
            Controls.Add(lbl_Derrota);
            Controls.Add(lbl_Empate);
            Controls.Add(lbl_Vitorias);
            Controls.Add(lbl_Saldo);
            Controls.Add(lbl_Jogos);
            Controls.Add(lbl_Posicao);
            Controls.Add(txt_Pontos);
            Controls.Add(lbl_Pontos);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Nome);
            Controls.Add(btn_Apagar);
            Controls.Add(btn_Atualizar);
            Controls.Add(btn_Inserir);
            Controls.Add(cb_SerieAtualizar);
            Controls.Add(lbl_serie1);
            Controls.Add(lbl_Atualizar);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTelaAtualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTelaAtualizar";
            Load += frmTelaAtualizar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Atualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lbl_Atualizar;
        private Label lbl_serie1;
        private ComboBox cb_SerieAtualizar;
        private Button btn_Inserir;
        private Button btn_Atualizar;
        private Button btn_Apagar;
        private Label lbl_Nome;
        private TextBox txt_Nome;
        private Label lbl_Pontos;
        private TextBox txt_Pontos;
        private Label lbl_Posicao;
        private Label lbl_Jogos;
        private Label lbl_Saldo;
        private Label lbl_Vitorias;
        private Label lbl_Empate;
        private Label lbl_Derrota;
        private Label lbl_Gols;
        private Label lbl_Contra;
        private TextBox txt_Posicao;
        private TextBox txt_Jogos;
        private TextBox txt_Saldo;
        private TextBox txt_Vitorias;
        private TextBox txt_Empate;
        private TextBox txt_Derrota;
        private TextBox txt_Gols;
        private TextBox txt_Contra;
        private DataGridView dgv_Atualizar;
        private Button btn_Consultar;
        private TextBox txt_PesquisarNome;
        private TextBox txt_PesquisarPosicao;
        private Label lbl_PesquisarNome;
        private Label lbl_PesquisarPosicao;
    }
}