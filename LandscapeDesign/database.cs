using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeDesign
{
    class database
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection()
        {
            string host = "re1ght7x.beget.tech";
            int port = 3306;
            string database = "re1ght7x_land";
            string username = "re1ght7x_land";
            string password = "Landscape11";

            return GetDBConnection(host, port, database, username, password);
        }



        MySqlConnection conn = GetDBConnection();



        public bool Auth(string login, string password)
        {
            bool flag = false;

            string sql = String.Format("SELECT * FROM clients WHERE login = @uL AND password = @uP;");
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
                flag = true;

            conn.Close();

            return flag;
        }


        public bool Create(string login, string password, string name)
        {

            bool flag = false;


            string sql = String.Format("INSERT INTO clients(name,login,password) VALUES (@uName,@uLogin,@uPass)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = name;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;

        }

        public DataTable GetClient(string login)
        {
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM clients WHERE login = @uLogin ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);

            conn.Close();
            return data;
        }

        public bool CreateOrder(string id_user, string title, string size, string price)
        {
            Random rnd = new Random();
            bool flag = false;
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");



            string sql = String.Format("INSERT INTO orders(userId,title,size,price,date) VALUES (@id_user,@title, @size, @price,@date)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id_user", MySqlDbType.VarChar).Value = id_user;
            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            command.Parameters.Add("@size", MySqlDbType.VarChar).Value = size;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;

        }


        public DataTable GetOrders(string id)
        {
            var datenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM orders WHERE userId = @uId");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@datenow", MySqlDbType.VarChar).Value = datenow;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);

            conn.Close();
            return data;
        }




        public ArrayList AllClients()
        {
            ArrayList allclients = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT id,login,name FROM clients order by name");
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
            {
                foreach (DbDataRecord result in sqldr)
                    allclients.Add(result);
                conn.Close();
            }



            return allclients;
        }


        public ArrayList AllOrders()
        {
            ArrayList allclients = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT * FROM orders");
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
            {
                foreach (DbDataRecord result in sqldr)
                    allclients.Add(result);
                conn.Close();
            }



            return allclients;
        }
        public ArrayList AllDesign()
        {
            ArrayList allclients = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT * FROM design");
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
            {
                foreach (DbDataRecord result in sqldr)
                    allclients.Add(result);
                conn.Close();
            }



            return allclients;
        }


    }
}
