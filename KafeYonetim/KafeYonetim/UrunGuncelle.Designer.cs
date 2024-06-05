namespace KafeYonetim
{
    partial class UrunGuncelle
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            btnExit = new PictureBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtFiyat = new TextBox();
            txtUrunAra = new TextBox();
            txtUrunAdi = new TextBox();
            btnGuncelle = new Button();
            txtKategori = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 20F, FontStyle.Bold);
            label2.Location = new Point(122, 9);
            label2.Name = "label2";
            label2.Size = new Size(235, 41);
            label2.TabIndex = 17;
            label2.Text = "ÜRÜN GÜNCELLEME";
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Image = Properties.Resources.pngegg__1_;
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(51, 49);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 28;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text Semibold", 12.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(12, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 204);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 17F, FontStyle.Bold);
            label5.Location = new Point(446, 39);
            label5.Name = "label5";
            label5.Size = new Size(92, 35);
            label5.TabIndex = 33;
            label5.Text = "Ürün Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 17F, FontStyle.Bold);
            label6.Location = new Point(81, 494);
            label6.Name = "label6";
            label6.Size = new Size(92, 35);
            label6.TabIndex = 34;
            label6.Text = "Ürün Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 17F, FontStyle.Bold);
            label7.Location = new Point(442, 379);
            label7.Name = "label7";
            label7.Size = new Size(56, 35);
            label7.TabIndex = 35;
            label7.Text = "Fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 17F, FontStyle.Bold);
            label8.Location = new Point(81, 381);
            label8.Name = "label8";
            label8.Size = new Size(92, 35);
            label8.TabIndex = 36;
            label8.Text = "Kategori";
            // 
            // txtFiyat
            // 
            txtFiyat.BackColor = Color.SkyBlue;
            txtFiyat.BorderStyle = BorderStyle.None;
            txtFiyat.Font = new Font("SWRomnt", 10.7999992F, FontStyle.Bold);
            txtFiyat.Location = new Point(345, 417);
            txtFiyat.Multiline = true;
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(239, 43);
            txtFiyat.TabIndex = 39;
            // 
            // txtUrunAra
            // 
            txtUrunAra.BackColor = Color.SkyBlue;
            txtUrunAra.BorderStyle = BorderStyle.None;
            txtUrunAra.Font = new Font("SWRomnt", 10.7999992F, FontStyle.Bold);
            txtUrunAra.Location = new Point(345, 77);
            txtUrunAra.Multiline = true;
            txtUrunAra.Name = "txtUrunAra";
            txtUrunAra.Size = new Size(239, 54);
            txtUrunAra.TabIndex = 40;
            txtUrunAra.TextChanged += txtUrunAra_TextChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.SkyBlue;
            txtUrunAdi.BorderStyle = BorderStyle.None;
            txtUrunAdi.Font = new Font("SWRomnt", 10.7999992F, FontStyle.Bold);
            txtUrunAdi.Location = new Point(12, 532);
            txtUrunAdi.Multiline = true;
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(239, 43);
            txtUrunAdi.TabIndex = 41;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.CornflowerBlue;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuncelle.Location = new Point(344, 511);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(239, 64);
            btnGuncelle.TabIndex = 42;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKategori
            // 
            txtKategori.BackColor = Color.SkyBlue;
            txtKategori.BorderStyle = BorderStyle.None;
            txtKategori.Font = new Font("SWRomnt", 10.7999992F, FontStyle.Bold);
            txtKategori.Location = new Point(12, 419);
            txtKategori.Multiline = true;
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(239, 43);
            txtKategori.TabIndex = 43;
            // 
            // UrunGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(606, 599);
            ControlBox = false;
            Controls.Add(txtKategori);
            Controls.Add(btnGuncelle);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtUrunAra);
            Controls.Add(txtFiyat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UrunGuncelle";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UrunGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox btnExit;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFiyat;
        private TextBox txtUrunAra;
        private TextBox txtUrunAdi;
        private Button btnGuncelle;
        private TextBox txtKategori;
    }
}