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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pb_Logo = new PictureBox();
            btn_Entrar = new Button();
            btn_Sair = new Button();
            lbl_Titulo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pb_Logo
            // 
            pb_Logo.BackColor = Color.DarkBlue;
            pb_Logo.Image = Properties.Resources.Captura_de_tela_2026_06_18_195956;
            pb_Logo.Location = new Point(28, 46);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(373, 354);
            pb_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Logo.TabIndex = 0;
            pb_Logo.TabStop = false;
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
            btn_Entrar.Click += btn_Entrar_Click;
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
            btn_Sair.Click += btn_Sair_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Titulo.ForeColor = SystemColors.HotTrack;
            lbl_Titulo.Location = new Point(407, 84);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(359, 70);
            lbl_Titulo.TabIndex = 3;
            lbl_Titulo.Text = "Sistema de Controle \r\n       de times\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_Entrar);
            panel1.Controls.Add(btn_Sair);
            panel1.Location = new Point(-1, 329);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 123);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(12, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 12);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 450);
            Controls.Add(panel2);
            Controls.Add(lbl_Titulo);
            Controls.Add(pb_Logo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_Logo;
        private Button btn_Entrar;
        private Button btn_Sair;
        private Label lbl_Titulo;
        private Panel panel1;
        private Panel panel2;
    }
}
