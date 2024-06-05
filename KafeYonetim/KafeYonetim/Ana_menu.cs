using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeYonetim
{
    public partial class Ana_menu : Form
    {
        Fonksiyon fn = new Fonksiyon();
        String query;
        int tane, ucret;
        int toplam = 0;

        public Ana_menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkleme urunEkleForm = new UrunEkleme();
            urunEkleForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkleme urunEkleForm = new UrunEkleme();
            urunEkleForm.Show();
            this.Hide();
        }

        private void cmbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Kategori = cmbxKategori.Text;
            query = "SELECT UrunAdi FROM Urunler WHERE Kategori = '" + Kategori + "'";
            GosterUrunListe(query);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtArama.Text.ToLower();
            query = "SELECT UrunAdi FROM Urunler WHERE UrunAdi LIKE '%" + searchQuery + "%'";
            GosterUrunListe(query);
        }

        private void GosterUrunListe(String query)
        {
            lstbxUrunListe.Items.Clear();
            DataSet dataSet = fn.getData(query);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                lstbxUrunListe.Items.Add(dataSet.Tables[0].Rows[i]["UrunAdi"].ToString());
            }
        }

        private void lstbxUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdet.ResetText();
            txtToplam.Clear();

            String text = lstbxUrunListe.GetItemText(lstbxUrunListe.SelectedItem);
            txtUrunAdi.Text = text;
            query = "select Fiyat from Urunler where UrunAdi = '" + text + "'";
            DataSet dataSet = fn.getData(query);
            try
            {
                txtFiyat.Text = dataSet.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void lblArti_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdet.Text))
            {
                int adet = int.Parse(txtAdet.Text);
                adet++;
                txtAdet.Text = adet.ToString();
            }
        }

        private void lblEksi_MouseClick(object sender, MouseEventArgs e)
        {
            int adet = int.Parse(txtAdet.Text);
            if (adet > 0)
            {
                adet--;
                txtAdet.Text = adet.ToString();
            }
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdet.Text) && !string.IsNullOrEmpty(txtFiyat.Text))
            {
                if (Int32.TryParse(txtAdet.Text, out tane) && Int32.TryParse(txtFiyat.Text, out ucret))
                {
                    if (tane >= 0)
                    {
                        txtToplam.Text = (tane * ucret).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Adet değeri negatif olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdet.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir tamsayı değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToplam.Text))
            {
                if (Int32.TryParse(txtToplam.Text, out int toplam))
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = txtUrunAdi.Text;
                    dataGridView1.Rows[n].Cells[1].Value = txtFiyat.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txtAdet.Text;
                    dataGridView1.Rows[n].Cells[3].Value = toplam.ToString();

                    this.toplam += toplam;
                    lblToplam.Text = this.toplam.ToString() + " TL";
                }
                else
                {
                    MessageBox.Show("Geçerli bir tamsayı değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    if (selectedRow != null && selectedRow.Cells[3].Value != null)
                    {
                        int silinecekToplam = Convert.ToInt32(selectedRow.Cells[3].Value);
                        dataGridView1.Rows.RemoveAt(selectedRow.Index);
                        toplam -= silinecekToplam;
                        lblToplam.Text = toplam.ToString() + " TL";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunGuncelle urunGuncelle = new UrunGuncelle();
            urunGuncelle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunSilme urunSil = new UrunSilme();
            urunSil.Show();
            this.Hide();
        }
    }
}
