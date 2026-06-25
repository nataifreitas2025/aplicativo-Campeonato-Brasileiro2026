namespace CampeonatoBrasileiro2026
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pb_Consultar = new PictureBox();
            lbl_Titulo = new Label();
            pictureBox2 = new PictureBox();
            lbl_Tela = new Label();
            lbl_titulo2 = new Label();
            btn_Consultar = new Button();
            btn_Atualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_Consultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pb_Consultar
            // 
            pb_Consultar.Image = (Image)resources.GetObject("pb_Consultar.Image");
            pb_Consultar.Location = new Point(235, 82);
            pb_Consultar.Name = "pb_Consultar";
            pb_Consultar.Size = new Size(571, 260);
            pb_Consultar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Consultar.TabIndex = 0;
            pb_Consultar.TabStop = false;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Titulo.ForeColor = SystemColors.HotTrack;
            lbl_Titulo.Location = new Point(341, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(359, 70);
            lbl_Titulo.TabIndex = 4;
            lbl_Titulo.Text = "Sistema de Controle \r\n       de times\r\n";
            lbl_Titulo.Click += lblTitulo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 451);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lbl_Tela
            // 
            lbl_Tela.AutoSize = true;
            lbl_Tela.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Tela.ForeColor = SystemColors.HotTrack;
            lbl_Tela.Location = new Point(409, 357);
            lbl_Tela.Name = "lbl_Tela";
            lbl_Tela.Size = new Size(244, 70);
            lbl_Tela.TabIndex = 6;
            lbl_Tela.Text = "Tela Principal\r\n\r\n";
            // 
            // lbl_titulo2
            // 
            lbl_titulo2.AutoSize = true;
            lbl_titulo2.BackColor = Color.MidnightBlue;
            lbl_titulo2.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo2.ForeColor = SystemColors.ButtonHighlight;
            lbl_titulo2.Location = new Point(23, 57);
            lbl_titulo2.Name = "lbl_titulo2";
            lbl_titulo2.Size = new Size(172, 54);
            lbl_titulo2.TabIndex = 7;
            lbl_titulo2.Text = "Campeonato \r\nBrasileiro";
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.LimeGreen;
            btn_Consultar.FlatStyle = FlatStyle.Popup;
            btn_Consultar.Location = new Point(52, 171);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(120, 40);
            btn_Consultar.TabIndex = 8;
            btn_Consultar.Text = "Consultar";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.BackColor = Color.Yellow;
            btn_Atualizar.FlatStyle = FlatStyle.Popup;
            btn_Atualizar.Location = new Point(52, 246);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(120, 43);
            btn_Atualizar.TabIndex = 9;
            btn_Atualizar.Text = "Atualizar";
            btn_Atualizar.UseVisualStyleBackColor = false;
            btn_Atualizar.Click += btn_Atualizar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Atualizar);
            Controls.Add(btn_Consultar);
            Controls.Add(lbl_titulo2);
            Controls.Add(lbl_Tela);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_Titulo);
            Controls.Add(pb_Consultar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)pb_Consultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_Consultar;
        private Label lbl_Titulo;
        private PictureBox pictureBox2;
        private Label lbl_Tela;
        private Label lbl_titulo2;
        private Button btn_Consultar;
        private Button btn_Atualizar;
    }
}