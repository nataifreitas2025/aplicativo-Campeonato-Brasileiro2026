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
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MidnightBlue;
            label2.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(42, 69);
            label2.Name = "label2";
            label2.Size = new Size(138, 54);
            label2.TabIndex = 8;
            label2.Text = "Consultar\r\n   Times\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(32, 200);
            label1.Name = "label1";
            label1.Size = new Size(71, 22);
            label1.TabIndex = 9;
            label1.Text = "Serie:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Selecionar...", "Serie A", "Serie B", "Serie C", "Serie D" });
            comboBox1.Location = new Point(32, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(32, 272);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 11;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(224, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(454, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(346, 451);
            dataGridView1.TabIndex = 13;
            // 
            // frmConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Name = "frmConsultar";
            Text = "frmConsultar";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}