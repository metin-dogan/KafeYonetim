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
    public partial class UrunGuncelle : Form
    {
        Fonksiyon fn = new Fonksiyon();
        String query;

        public UrunGuncelle()
        {
            InitializeComponent();
        }


        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = " select * from Urunler ";
            DataSet dataSet = fn.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Ana_menu ana_Menu = new Ana_menu();
            ana_Menu.Show();
            this.Close();
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            query = " select * from Urunler where UrunAdi like '" + txtUrunAra.Text + "%'";
            DataSet dataSet = fn.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String UrunAdi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String Kategori = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int Fiyat = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtKategori.Text = Kategori;
            txtFiyat.Text = Fiyat.ToString();
            txtUrunAdi.Text = UrunAdi;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            query = "UPDATE Urunler SET UrunAdi = @UrunAdi, Kategori = @KategoriId, Fiyat = @Fiyat WHERE UrunId = @UrunId";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@KategoriId", txtKategori.Text);
            cmd.Parameters.AddWithValue("@Fiyat", Convert.ToInt32(txtFiyat.Text));
            cmd.Parameters.AddWithValue("@UrunId", id);

            fn.setData(cmd);

            loadData();

            txtFiyat.Clear();
            txtUrunAdi.Clear();
            txtKategori.Clear();
        }


    }
}
