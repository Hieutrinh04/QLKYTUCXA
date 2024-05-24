using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTucXa_Version5
{
    internal class function
    {
        protected SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-9R68G2V;Initial Catalog=master;Integrated Security=True";

            return con;
        }

        public DataSet GetData(string query, System.Collections.Generic.Dictionary<string, object> parameters = null)
        {
            SqlConnection con = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            if(parameters != null)
            {
                foreach (var item in parameters)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }

        public void SetData(string query, string msg)
        {
            SqlConnection con = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


    }
}

