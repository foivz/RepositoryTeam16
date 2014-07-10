using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace AplikacijaPI
{
    class Baza
    {
        private static Baza instance;
        private string connectionString;
        private SqlConnection connection;

        public static Baza Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Baza();
                }
                return instance;
            }
        }

        public string ConnectionString
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }
        public SqlConnection Connection
        {
            get { return connection; }
            private set { connection = value; }
        }

        private Baza()
        {

            ConnectionString = @"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=T16_DB;Persist Security Info=True;User ID=T16_User;Password=wj27R43x";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        ~Baza()
        {
            //Connection.Close();
            Connection = null;
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}