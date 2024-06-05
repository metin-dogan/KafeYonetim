namespace KafeYonetim
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = SystemColors.GradientActiveCaption;
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.Font = new Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKullaniciAdi.Location = new Point(69, 177);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "   Kullanıcı adınızı giriniz...";
            txtKullaniciAdi.Size = new Size(309, 51);
            txtKullaniciAdi.TabIndex = 1;
            txtKullaniciAdi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.GradientActiveCaption;
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSifre.ForeColor = SystemColors.WindowText;
            txtSifre.Location = new Point(69, 263);
            txtSifre.MinimumSize = new Size(10, 10);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "   Şifrenizi giriniz...";
            txtSifre.Size = new Size(309, 48);
            txtSifre.TabIndex = 1;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Red;
            btnGiris.FlatAppearance.BorderColor = Color.Red;
            btnGiris.FlatAppearance.BorderSize = 5;
            btnGiris.FlatAppearance.MouseDownBackColor = Color.Red;
            btnGiris.FlatAppearance.MouseOverBackColor = Color.Black;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Arial Rounded MT Bold", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiris.ForeColor = Color.AliceBlue;
            btnGiris.Location = new Point(104, 371);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(227, 88);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vivaldi", 21.2F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(46, 36);
            label1.Name = "label1";
            label1.Size = new Size(365, 43);
            label1.TabIndex = 3;
            label1.Text = "RÜYA  KAFE";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(443, 535);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            ForeColor = SystemColors.ButtonShadow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
    }
}
