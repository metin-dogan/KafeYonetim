namespace KafeYonetim
{
    partial class UrunEkleme
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
            button1 = new Button();
            txtUrunAdi = new TextBox();
            txtUcret = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit = new PictureBox();
            cmbxKategori = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(224, 492);
            button1.Name = "button1";
            button1.Size = new Size(188, 76);
            button1.TabIndex = 26;
            button1.Text = "ÜRÜN EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.SkyBlue;
            txtUrunAdi.BorderStyle = BorderStyle.None;
            txtUrunAdi.Font = new Font("SWRomnt", 10.7999992F, FontStyle.Bold);
            txtUrunAdi.Location = new Point(197, 145);
            txtUrunAdi.Multiline = true;
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(239, 54);
            txtUrunAdi.TabIndex = 19;
            // 
            // txtUcret
            // 
            txtUcret.BackColor = Color.SkyBlue;
            txtUcret.BorderStyle = BorderStyle.None;
            txtUcret.Font = new Font("SWRomnt", 13.7999992F, FontStyle.Bold);
            txtUcret.Location = new Point(197, 405);
            txtUcret.Multiline = true;
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(239, 52);
            txtUcret.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            label4.Location = new Point(270, 236);
            label4.Name = "label4";
            label4.Size = new Size(110, 41);
            label4.TabIndex = 17;
            label4.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            label3.Location = new Point(283, 364);
            label3.Name = "label3";
            label3.Size = new Size(80, 41);
            label3.TabIndex = 16;
            label3.Text = "Ücret";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            label2.Location = new Point(269, 100);
            label2.Name = "label2";
            label2.Size = new Size(111, 41);
            label2.TabIndex = 15;
            label2.Text = "Ürün adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Font = new Font("Agency FB", 24F, FontStyle.Bold);
            label1.Location = new Point(282, -77);
            label1.Name = "label1";
            label1.Size = new Size(252, 50);
            label1.TabIndex = 14;
            label1.Text = "Yeni ürün ekleme";
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Image = Properties.Resources.pngegg__1_;
            btnExit.Location = new Point(12, 11);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(61, 62);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 27;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // cmbxKategori
            // 
            cmbxKategori.BackColor = Color.SkyBlue;
            cmbxKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxKategori.FlatStyle = FlatStyle.Flat;
            cmbxKategori.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbxKategori.ForeColor = SystemColors.WindowText;
            cmbxKategori.FormattingEnabled = true;
            cmbxKategori.Items.AddRange(new object[] { "Kahve", "Çikolata", "Pasta", "Çikolatalı Tatlı", "Şerbetli Tatlı", "içecek" });
            cmbxKategori.Location = new Point(197, 279);
            cmbxKategori.Name = "cmbxKategori";
            cmbxKategori.Size = new Size(239, 43);
            cmbxKategori.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 25F, FontStyle.Bold);
            label5.Location = new Point(217, 22);
            label5.Name = "label5";
            label5.Size = new Size(215, 51);
            label5.TabIndex = 29;
            label5.Text = "ÜRÜN EKLEME";
            // 
            // UrunEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(653, 589);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(cmbxKategori);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtUcret);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UrunEkleme";
            Text = "UrunEkleme";
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtUrunAdi;
        private TextBox txtUcret;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox btnExit;
        private ComboBox cmbxKategori;
        private Label label5;
    }
}