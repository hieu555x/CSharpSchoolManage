using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Spader.DAO
{
    class DataProvider
    {
        private string connectionString = new ConnectionString().connectString("database.txt");

        public DataTable ExcuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection(new ConnectionString().Decrypt(connectionString));
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            conn.Close();
            return data;
        }

        public void ExcuteNoQuery(string query)
        {
            SqlConnection conn = new SqlConnection(new ConnectionString().Decrypt(connectionString));
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
