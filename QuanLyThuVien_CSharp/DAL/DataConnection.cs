using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp.DAL
{
    class DataConnection
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=desktop-gcdrl3v\sqlexpress;Initial Catalog=QuanLyThuVienCSharp;Integrated Security=True");
        }
        public DataTable GetTable(string sql)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void ExecuteNonQuery(String sql)
        {
            try
            {
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void ExecuteNonQueryWithImage(String sql, byte[] img)
        {
            try
            {
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@image", img));
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
