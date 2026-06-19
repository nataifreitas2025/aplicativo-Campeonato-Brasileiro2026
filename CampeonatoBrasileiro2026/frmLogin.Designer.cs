namespace CampeonatoBrasileiro2026
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb_img1 = new PictureBox();
            btn_Entrar = new Button();
            btn_Sair = new Button();
            lblTitulo = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pb_img1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pb_img1
            // 
            pb_img1.Image = Properties.Resources.Captura_de_tela_2026_06_18_195956;
            pb_img1.Location = new Point(25, 48);
            pb_img1.Name = "pb_img1";
            pb_img1.Size = new Size(373, 354);
            pb_img1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_img1.TabIndex = 0;
            pb_img1.TabStop = false;
            // 
            // btn_Entrar
            // 
            btn_Entrar.BackColor = Color.Lime;
            btn_Entrar.FlatStyle = FlatStyle.Popup;
            btn_Entrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Entrar.Location = new Point(431, 25);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(113, 46);
            btn_Entrar.TabIndex = 1;
            btn_Entrar.Text = "ENTRAR";
            btn_Entrar.UseVisualStyleBackColor = false;
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = Color.Crimson;
            btn_Sair.FlatStyle = FlatStyle.Popup;
            btn_Sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Sair.Location = new Point(600, 25);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(113, 46);
            btn_Sair.TabIndex = 2;
            btn_Sair.Text = "SAIR";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += button2_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(407, 84);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(359, 70);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Sistema de Controle \r\n       de times\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_Entrar);
            panel1.Controls.Add(btn_Sair);
            panel1.Location = new Point(-1, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 121);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 450);
            Controls.Add(lblTitulo);
            Controls.Add(pb_img1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_img1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_img1;
        private Button btn_Entrar;
        private Button btn_Sair;
        private Label lblTitulo;
        private Panel panel1;
    }
}
