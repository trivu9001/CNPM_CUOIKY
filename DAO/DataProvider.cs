using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private const string cnStr = "Data Source=ADMIN;Initial Catalog=QUANLYCUAHANGBANHOA;Integrated Security=True";
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
