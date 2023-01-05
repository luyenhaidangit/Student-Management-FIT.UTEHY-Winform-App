using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnect
    {
        public SqlConnection conn;
        public SqlDataAdapter da;
        public DataTable dt;
        public SqlCommand cmd;
        public string stringConn = @"Data Source=LAPTOP-3KE0ADA0\SQLEXPRESS;Initial Catalog=Student_Manager_System_FIT_UTEHY;Integrated Security=True";

        public void OpenConnect()
        {
            conn = new SqlConnection(stringConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnect()
        {
            conn = new SqlConnection(stringConn);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void RunSQL(string sql)
        {
            OpenConnect();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            CloseConnect();
        }

        public DataTable GetData(string sql)
        {
            OpenConnect();
            dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
