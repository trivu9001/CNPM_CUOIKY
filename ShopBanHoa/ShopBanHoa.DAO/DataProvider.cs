
using System;
using System.Data.SqlClient;

namespace ShopBanHoa.DAO
{
    public class DataProvider
    {
        private const string cnStr = "Data Source=LAPTOP-8S40BDMV\\SQLExpress;Initial Catalog=QUANLYCUAHANGBANHOA;Integrated Security=True";
        private SqlConnection cn;

        public DataProvider()
        {
            cn = new SqlConnection(cnStr);
        }
        public void Connect()
        {
            cn.Open();
        }

        public void Disconnect()
        {
            cn.Close();
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            return cmd.ExecuteReader();
        }

        internal void ExecuteQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
        }
    }
}
