using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SlanjeObavijesti
{
    public class BazaPodataka
    {
        private static BazaPodataka instance;
        public static BazaPodataka Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BazaPodataka();
                }
                return instance;
            }
        }

        private BazaPodataka()
        {

        }


        private string connectionString = @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = PI2244_DB; User=PI2244_User; Password=)^t|!eQv";
        private SqlConnection connection { get; set; }

        public void Connect()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Disconnect()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public IDataReader GetDataReader(string upit)
        {
            SqlCommand command = new SqlCommand(upit, connection);
            return command.ExecuteReader();
        }

        public object GetValue(string upit)
        {
            SqlCommand command = new SqlCommand(upit, connection);
            return command.ExecuteScalar();
        }

        public int ExecuteCommand(string upit)
        {
            SqlCommand command = new SqlCommand(upit, connection);
            return command.ExecuteNonQuery();
        }
    }
}
