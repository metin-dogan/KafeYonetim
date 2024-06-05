using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeYonetim
{
    public partial class UrunEkleme : Form
    {
        Fonksiyon fn = new Fonksiyon();
        string query;

        public UrunEkleme()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Ana_menu ana_Menu = new Ana_menu();
            ana_Menu.Show();
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO Urunler (UrunAdi, Kategori, Fiyat) VALUES (@UrunAdi, @Kategori, @Fiyat)";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@Kategori", cmbxKategori.Text);
            cmd.Parameters.AddWithValue("@Fiyat", txtUcret.Text);

            fn.setData(cmd);
            MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();
        }

        public void ClearAll()
        {
            cmbxKategori.SelectedIndex = -1;
            txtUrunAdi.Clear();
            txtUcret.Clear();
        }
    }
}
