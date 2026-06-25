namespace CampeonatoBrasileiro2026
{
    partial class frmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultar));
            pictureBox2 = new PictureBox();
            lbl_Consultar = new Label();
            lbl_Serie = new Label();
            cb_Serie = new ComboBox();
            btn_Consultar = new Button();
            pb_Consultar = new PictureBox();
            dgv_Consultar = new DataGridView();
            btn_Inicio = new Button();
            btn_Atualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Consultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Consultar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 451);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lbl_Consultar
            // 
            lbl_Consultar.AutoSize = true;
            lbl_Consultar.BackColor = Color.MidnightBlue;
            lbl_Consultar.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Consultar.ForeColor = SystemColors.ButtonHighlight;
            lbl_Consultar.Location = new Point(42, 69);
            lbl_Consultar.Name = "lbl_Consultar";
            lbl_Consultar.Size = new Size(138, 54);
            lbl_Consultar.TabIndex = 8;
            lbl_Consultar.Text = "Consultar\r\n   Times\r\n";
            // 
            // lbl_Serie
            // 
            lbl_Serie.AutoSize = true;
            lbl_Serie.BackColor = Color.MidnightBlue;
            lbl_Serie.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Serie.ForeColor = Color.Transparent;
            lbl_Serie.Location = new Point(32, 200);
            lbl_Serie.Name = "lbl_Serie";
            lbl_Serie.Size = new Size(71, 22);
            lbl_Serie.TabIndex = 9;
            lbl_Serie.Text = "Serie:";
            // 
            // cb_Serie
            // 
            cb_Serie.FormattingEnabled = true;
            cb_Serie.Items.AddRange(new object[] { "Selecionar...", "Série A", "Série B", "Série C", "Série D" });
            cb_Serie.Location = new Point(32, 225);
            cb_Serie.Name = "cb_Serie";
            cb_Serie.Size = new Size(121, 23);
            cb_Serie.TabIndex = 10;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.LimeGreen;
            btn_Consultar.FlatStyle = FlatStyle.Popup;
            btn_Consultar.Location = new Point(32, 272);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(121, 35);
            btn_Consultar.TabIndex = 11;
            btn_Consultar.Text = "Consultar";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // pb_Consultar
            // 
            pb_Consultar.Image = (Image)resources.GetObject("pb_Consultar.Image");
            pb_Consultar.Location = new Point(224, 0);
            pb_Consultar.Name = "pb_Consultar";
            pb_Consultar.Size = new Size(231, 451);
            pb_Consultar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Consultar.TabIndex = 12;
            pb_Consultar.TabStop = false;
            // 
            // dgv_Consultar
            // 
            dgv_Consultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Consultar.Location = new Point(454, 0);
            dgv_Consultar.Name = "dgv_Consultar";
            dgv_Consultar.Size = new Size(346, 451);
            dgv_Consultar.TabIndex = 13;
            // 
            // btn_Inicio
            // 
            btn_Inicio.BackColor = Color.LimeGreen;
            btn_Inicio.FlatStyle = FlatStyle.Popup;
            btn_Inicio.Location = new Point(32, 377);
            btn_Inicio.Name = "btn_Inicio";
            btn_Inicio.Size = new Size(121, 35);
            btn_Inicio.TabIndex = 14;
            btn_Inicio.Text = "Inicio";
            btn_Inicio.UseVisualStyleBackColor = false;
            btn_Inicio.Click += btn_Inicio_Click;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.BackColor = Color.LimeGreen;
            btn_Atualizar.FlatStyle = FlatStyle.Popup;
            btn_Atualizar.Location = new Point(32, 325);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(121, 35);
            btn_Atualizar.TabIndex = 15;
            btn_Atualizar.Text = "Atualizar";
            btn_Atualizar.UseVisualStyleBackColor = false;
            btn_Atualizar.Click += btn_Atualizar_Click;
            // 
            // frmConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Atualizar);
            Controls.Add(btn_Inicio);
            Controls.Add(dgv_Consultar);
            Controls.Add(pb_Consultar);
            Controls.Add(btn_Consultar);
            Controls.Add(cb_Serie);
            Controls.Add(lbl_Serie);
            Controls.Add(lbl_Consultar);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmConsultar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConsultar";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Consultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Consultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lbl_Consultar;
        private Label lbl_Serie;
        private ComboBox cb_Serie;
        private Button btn_Consultar;
        private PictureBox pb_Consultar;
        private DataGridView dgv_Consultar;
        private Button btn_Inicio;
        private Button btn_Atualizar;
    }
}