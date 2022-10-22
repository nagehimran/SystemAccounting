using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using SystemAccounting;
namespace SystemAccounting
{
    class DBConnect
    {
        public static string connection = "Data Source=SQL5009.Smarterasp.net;Initial Catalog=DB_9B0A2E_Safwa;Persist Security Info=True;User ID=DB_9B0A2E_Safwa_admin;Password=123asd!@#;Pooling=False";
            
        public static SqlConnection conn = new SqlConnection(connection);
        //public static SqlDataReader dr = new SqlDataReader()
        public SqlCommand cmd = new SqlCommand();
        public DBConnect()
        {
            Openconnection();
        }
        void Openconnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
    }
}
