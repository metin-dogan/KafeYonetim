using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using System;
using System.Collections;
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
    public partial class UrunSilme : Form
    {
        private int selectedRowIndex = -1;

        Fonksiyon fn = new Fonksiyon();
        String query;

        public UrunSilme()
        {
            InitializeComponent();
        }

        private void UrunSilme_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = " select * from Urunler ";
            DataSet dataSet = fn.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);

                    selectedRowIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            query = " select * from Urunler where UrunAdi like '" + txtUrunAra.Text + "%'";
            DataSet dataSet = fn.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Ana_menu ana_Menu = new Ana_menu();
            ana_Menu.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedRowIndex = e.RowIndex;
            }
        }
    }
}
