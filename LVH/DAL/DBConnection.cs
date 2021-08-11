using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVH
{
    class DBConnection
    {
        public SqlConnection GetConnect()
        {
            String connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyThuVienCSharp;Integrated Security=True";
            return new SqlConnection(connString);
        }

        public DataTable GetTable(String sql)
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = GetConnect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void ExecuteNonQuerry(String sql)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void ExecuteNonQueryWithImage(String sql, byte[] image)
        {
                SqlConnection connect = GetConnect();
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@image", image));
                cmd.ExecuteNonQuery();
        }
    }
}
