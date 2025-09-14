using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapChuan
{
    internal class connetcdata
    {
        public SqlConnection conn;
        public void connect()
        {
            string strCon = @"Data Source=.;Initial Catalog=QUANLYCAPHE;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                conn = new SqlConnection(strCon);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }
        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public Boolean exeSql(string cmd)
        {
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
