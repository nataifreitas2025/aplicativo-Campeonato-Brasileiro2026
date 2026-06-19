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
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(341, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(359, 70);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Sistema de Controle \r\n       de times\r\n";
            lblTitulo.Click += lblTitulo_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(409, 357);
            label1.Name = "label1";
            label1.Size = new Size(244, 70);
            label1.TabIndex = 6;
            label1.Text = "Tela Principal\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MidnightBlue;
            label2.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(172, 54);
            label2.TabIndex = 7;
            label2.Text = "Campeonato \r\nBrasileiro";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(52, 171);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 8;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(52, 246);
            button2.Name = "button2";
            button2.Size = new Size(120, 43);
            button2.TabIndex = 9;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}