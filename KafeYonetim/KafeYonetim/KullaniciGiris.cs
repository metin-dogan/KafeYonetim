using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KafeYonetim
{
    public partial class Form1 : Form
    {
        private SqlConnection connection; 

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=LAPTOP-FSHH81C8\\SQLEXPRESS06;Initial Catalog=KafeYonetim;Integrated Security=True");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (DogrulaKullanici(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriþ baþarýlý!");
                Ana_menu anaMenuForm = new Ana_menu();
                anaMenuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!");
            }
        }

        private bool DogrulaKullanici(string kullaniciAdi, string sifre)
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND KullaniciSifre = @KullaniciSifre";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@KullaniciSifre", sifre);

                int kullaniciSayisi = (int)cmd.ExecuteScalar();

                connection.Close();

                return kullaniciSayisi > 0;
            }
        }
    }
}
