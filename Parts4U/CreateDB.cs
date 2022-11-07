using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts4U
{
    class CreateDB
    {
       public static string db = "db_parts4u";


        // creates database from sql file if it doesn't exist
        public static void createDB()
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();
            if (isConnected("BaseConnection") != false)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["BaseConnection"].ConnectionString;


                using (MySqlConnection conn = new MySqlConnection(mainconn))
                {
                    using (MySqlCommand comm = new MySqlCommand())
                    {
                        comm.Connection = conn;
                        conn.Open();

                        string query = "CREATE DATABASE IF NOT EXISTS " + db;
                        comm.Connection = conn;
                        comm.CommandText = query;
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Databasen er oprettet");

                    }
                }
            }
            else
            {
                MessageBox.Show("Databasen kunne ikke oprettes.\nDer lader til at være problemer med forbindelsen til serveren");
            }
            mutex.ReleaseMutex();
        }

        // creates tables from sql file if it doesn't exist
        public static void createTables()
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;

                
               bool creatingTables = false;
                using (MySqlConnection conn = new MySqlConnection(mainconn))
                {
                    using (MySqlCommand comm = new MySqlCommand())
                    {
                        conn.Open();
                        string queryTableExists = "SHOW TABLES FROM " + db + " LIKE 'products'";
                        comm.Connection = conn;
                        comm.CommandText = queryTableExists;

                        MySqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Tabellerne var allerede oprettet i databasen");
                        }
                        else
                        {
                            creatingTables = true;
                        }
                    }
                }
                using (MySqlConnection conn = new MySqlConnection(mainconn))
                {
                    if (creatingTables == true)
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            string sqlFile = XMLPath.ProjectPath + "db_parts4U.sql";
                            FileInfo file = new FileInfo(sqlFile);
                            string query = file.OpenText().ReadToEnd();
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tabellerne er blevet oprettet i databasen");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tabellerne er ikke blevet oprettet");
            }
        }


        // check connection to server
        public static bool isConnected(string connection)
        {
            bool con = false;
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(mainconn))
                {
                    conn.Open();
                    con = true;
                    conn.Close();
                }
            }
            catch
            {
                // MessageBox.Show("Der er ingen forbindelse til localhost serveren.");
            }
            return con;
        }
    }
}
