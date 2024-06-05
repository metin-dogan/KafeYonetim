namespace KafeYonetim
{
    partial class Ana_menu
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            btnLogout = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            lblToplam = new Label();
            label2 = new Label();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnSepeteEkle = new Button();
            lblEksi = new Label();
            txtAdet = new TextBox();
            lblArti = new Label();
            txtFiyat = new TextBox();
            txtToplam = new TextBox();
            txtUrunAdi = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            lstbxUrunListe = new ListBox();
            txtArama = new TextBox();
            cmbxKategori = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(291, 658);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg__1_;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            button2.ForeColor = Color.Khaki;
            button2.Location = new Point(56, 369);
            button2.Name = "button2";
            button2.Size = new Size(242, 104);
            button2.TabIndex = 8;
            button2.Text = "ÜRÜN SİL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            button1.ForeColor = Color.Khaki;
            button1.Location = new Point(56, 68);
            button1.Name = "button1";
            button1.Size = new Size(242, 104);
            button1.TabIndex = 7;
            button1.Text = "ÜRÜN EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            button3.ForeColor = Color.Khaki;
            button3.Location = new Point(56, 222);
            button3.Name = "button3";
            button3.Size = new Size(242, 104);
            button3.TabIndex = 9;
            button3.Text = "ÜRÜN GÜNCELLE ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Image = Properties.Resources.log_out;
            btnLogout.Location = new Point(23, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(62, 49);
            btnLogout.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogout.TabIndex = 5;
            btnLogout.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(84, 569);
            label1.Name = "label1";
            label1.Size = new Size(181, 34);
            label1.TabIndex = 6;
            label1.Text = "ÇIKIŞ YAP";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumAquamarine;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblToplam);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lstbxUrunListe);
            panel2.Controls.Add(txtArama);
            panel2.Controls.Add(cmbxKategori);
            panel2.Location = new Point(297, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 658);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 23F, FontStyle.Bold);
            label3.Location = new Point(52, 10);
            label3.Name = "label3";
            label3.Size = new Size(221, 46);
            label3.TabIndex = 54;
            label3.Text = "SİPARİŞ MENÜ";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.BackColor = Color.PaleGreen;
            lblToplam.Font = new Font("Agency FB", 24F, FontStyle.Bold);
            lblToplam.Location = new Point(875, 588);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(86, 50);
            lblToplam.TabIndex = 53;
            lblToplam.Text = "0  TL";
            lblToplam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label2.Location = new Point(684, 594);
            label2.Name = "label2";
            label2.Size = new Size(158, 36);
            label2.TabIndex = 52;
            label2.Text = "Sipariş toplamı";
            // 
            // button6
            // 
            button6.BackColor = Color.Blue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            button6.ForeColor = Color.FloralWhite;
            button6.Location = new Point(385, 588);
            button6.Name = "button6";
            button6.Size = new Size(177, 52);
            button6.TabIndex = 50;
            button6.Text = "SİL";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.RosyBrown;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("SWRomnd", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(255, 255, 128);
            dataGridView1.Location = new Point(328, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 170;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(692, 272);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ürün Adı";
            Column1.MinimumWidth = 4;
            Column1.Name = "Column1";
            Column1.Width = 222;
            // 
            // Column2
            // 
            Column2.HeaderText = "Birim Fiyat";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 155;
            // 
            // Column3
            // 
            Column3.HeaderText = "Adet";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 155;
            // 
            // Column4
            // 
            Column4.HeaderText = "Fiyat";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 158;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SpringGreen;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSepeteEkle);
            panel3.Controls.Add(lblEksi);
            panel3.Controls.Add(txtAdet);
            panel3.Controls.Add(lblArti);
            panel3.Controls.Add(txtFiyat);
            panel3.Controls.Add(txtToplam);
            panel3.Controls.Add(txtUrunAdi);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(328, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(692, 282);
            panel3.TabIndex = 41;
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.BackColor = Color.Blue;
            btnSepeteEkle.FlatAppearance.BorderSize = 0;
            btnSepeteEkle.FlatStyle = FlatStyle.Flat;
            btnSepeteEkle.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            btnSepeteEkle.ForeColor = Color.FloralWhite;
            btnSepeteEkle.Location = new Point(233, 212);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(215, 58);
            btnSepeteEkle.TabIndex = 49;
            btnSepeteEkle.Text = "SEPETE EKLE";
            btnSepeteEkle.UseVisualStyleBackColor = false;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // lblEksi
            // 
            lblEksi.BackColor = Color.FromArgb(255, 128, 128);
            lblEksi.BorderStyle = BorderStyle.FixedSingle;
            lblEksi.Font = new Font("Elephant", 15.2000008F, FontStyle.Bold);
            lblEksi.Location = new Point(232, 163);
            lblEksi.Name = "lblEksi";
            lblEksi.Size = new Size(25, 29);
            lblEksi.TabIndex = 47;
            lblEksi.Text = "-";
            lblEksi.TextAlign = ContentAlignment.MiddleCenter;
            lblEksi.MouseClick += lblEksi_MouseClick;
            // 
            // txtAdet
            // 
            txtAdet.BackColor = Color.SkyBlue;
            txtAdet.BorderStyle = BorderStyle.None;
            txtAdet.Font = new Font("Bahnschrift SemiBold", 14.8F, FontStyle.Bold);
            txtAdet.Location = new Point(45, 143);
            txtAdet.Multiline = true;
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(170, 42);
            txtAdet.TabIndex = 45;
            txtAdet.TextAlign = HorizontalAlignment.Center;
            txtAdet.TextChanged += txtAdet_TextChanged;
            // 
            // lblArti
            // 
            lblArti.BackColor = Color.FromArgb(255, 128, 128);
            lblArti.BorderStyle = BorderStyle.FixedSingle;
            lblArti.Font = new Font("Elephant", 15.2000008F, FontStyle.Bold);
            lblArti.Location = new Point(232, 132);
            lblArti.Name = "lblArti";
            lblArti.Size = new Size(25, 29);
            lblArti.TabIndex = 48;
            lblArti.Text = "+";
            lblArti.TextAlign = ContentAlignment.MiddleCenter;
            lblArti.MouseClick += lblArti_MouseClick;
            // 
            // txtFiyat
            // 
            txtFiyat.BackColor = Color.SkyBlue;
            txtFiyat.BorderStyle = BorderStyle.None;
            txtFiyat.Font = new Font("Bahnschrift SemiBold", 14.8F, FontStyle.Bold);
            txtFiyat.Location = new Point(407, 44);
            txtFiyat.Multiline = true;
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(226, 42);
            txtFiyat.TabIndex = 44;
            txtFiyat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtToplam
            // 
            txtToplam.BackColor = Color.SkyBlue;
            txtToplam.BorderStyle = BorderStyle.None;
            txtToplam.Font = new Font("Bahnschrift SemiBold", 14.8F, FontStyle.Bold);
            txtToplam.Location = new Point(407, 141);
            txtToplam.Multiline = true;
            txtToplam.Name = "txtToplam";
            txtToplam.Size = new Size(226, 42);
            txtToplam.TabIndex = 43;
            txtToplam.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.SkyBlue;
            txtUrunAdi.BorderStyle = BorderStyle.None;
            txtUrunAdi.Font = new Font("Bahnschrift SemiBold", 12.8F, FontStyle.Bold);
            txtUrunAdi.Location = new Point(45, 44);
            txtUrunAdi.Multiline = true;
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(226, 42);
            txtUrunAdi.TabIndex = 42;
            txtUrunAdi.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 16F, FontStyle.Bold);
            label6.Location = new Point(487, 10);
            label6.Name = "label6";
            label6.Size = new Size(60, 34);
            label6.TabIndex = 38;
            label6.Text = "Fiyatı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 16F, FontStyle.Bold);
            label4.Location = new Point(487, 106);
            label4.Name = "label4";
            label4.Size = new Size(74, 34);
            label4.TabIndex = 36;
            label4.Text = "Toplam";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 16F, FontStyle.Bold);
            label7.Location = new Point(121, 106);
            label7.Name = "label7";
            label7.Size = new Size(52, 34);
            label7.TabIndex = 39;
            label7.Text = "Adet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 16F, FontStyle.Bold);
            label5.Location = new Point(113, 10);
            label5.Name = "label5";
            label5.Size = new Size(88, 34);
            label5.TabIndex = 37;
            label5.Text = "Ürün Adı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 16F, FontStyle.Bold);
            label8.Location = new Point(117, 83);
            label8.Name = "label8";
            label8.Size = new Size(86, 34);
            label8.TabIndex = 40;
            label8.Text = "Kategori";
            // 
            // lstbxUrunListe
            // 
            lstbxUrunListe.BackColor = SystemColors.GradientInactiveCaption;
            lstbxUrunListe.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lstbxUrunListe.FormattingEnabled = true;
            lstbxUrunListe.ItemHeight = 25;
            lstbxUrunListe.Location = new Point(30, 255);
            lstbxUrunListe.Name = "lstbxUrunListe";
            lstbxUrunListe.Size = new Size(276, 379);
            lstbxUrunListe.TabIndex = 34;
            lstbxUrunListe.SelectedIndexChanged += lstbxUrunListe_SelectedIndexChanged;
            // 
            // txtArama
            // 
            txtArama.BackColor = Color.SkyBlue;
            txtArama.BorderStyle = BorderStyle.None;
            txtArama.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtArama.Location = new Point(30, 187);
            txtArama.Multiline = true;
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Ara";
            txtArama.Size = new Size(276, 51);
            txtArama.TabIndex = 33;
            txtArama.TextAlign = HorizontalAlignment.Center;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // cmbxKategori
            // 
            cmbxKategori.BackColor = Color.SkyBlue;
            cmbxKategori.FlatStyle = FlatStyle.Flat;
            cmbxKategori.Font = new Font("Sylfaen", 14.2F, FontStyle.Bold);
            cmbxKategori.ForeColor = SystemColors.MenuText;
            cmbxKategori.ImeMode = ImeMode.NoControl;
            cmbxKategori.Items.AddRange(new object[] { "Kahve", "Çikolata", "Pasta", "Çikolatalı Tatlı", "Şerbetli Tatlı", "içecek" });
            cmbxKategori.Location = new Point(30, 125);
            cmbxKategori.Name = "cmbxKategori";
            cmbxKategori.Size = new Size(276, 39);
            cmbxKategori.TabIndex = 32;
            cmbxKategori.SelectedIndexChanged += cmbxKategori_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Ana_menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1347, 674);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ana_menu";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = SystemColors.ControlLight;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btnLogout;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cmbxKategori;
        private TextBox txtArama;
        private ListBox lstbxUrunListe;
        private Panel panel3;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label8;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtUrunAdi;
        private TextBox txtAdet;
        private TextBox txtFiyat;
        private TextBox txtToplam;
        private Label lblEksi;
        private Label lblArti;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button btnSepeteEkle;
        private Label lblToplam;
        private Label label2;
        private Button button6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label3;
    }
}