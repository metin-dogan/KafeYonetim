using System.Data;
using System.Data.SqlClient;

namespace KafeYonetim
{
    class Fonksiyon
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=LAPTOP-FSHH81C8\\SQLEXPRESS06;Initial Catalog=KafeYonetim;Integrated Security=True";
            return conn;
        }

        public DataSet getData(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

        public void setData(SqlCommand cmd)
        {
            using (SqlConnection conn = GetConnection())
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
