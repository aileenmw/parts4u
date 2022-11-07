using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts4U
{
    // saving productlist to database
    class SaveToDB
    {
        public void Products()
        {
            if (isConnected() != false)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;

                string StrQuery = "";

                using (MySqlConnection conn = new MySqlConnection(mainconn))
                {

                    using (MySqlCommand comm = new MySqlCommand())
                    {
                        comm.Connection = conn;
                        conn.Open();
                        for (int i = 0; i < Product.GetProductTypes().Count; i++)
                        {
                            IEnumerable<object> productList = Product.ProductDictionay().Where(x => x.Key == Product.GetProductTypes()[i]).SelectMany(x => x.Value);
                            // convert iEnumarable to List<Product>
                            List<Product> ProductList = new List<Product>();
                            ProductList = productList.Cast<Product>().ToList();

                            Mutex mutex = new Mutex();
                            mutex.WaitOne();
                            foreach (var product in ProductList)
                            {
                                string name = product.Name;
                                string type = product.Type;
                                string description = cleanupString(product.Description);
                                string itemNumber = product.ItemNumber;
                                double cost = Convert.ToDouble(product.Cost);

                                string query = "SELECT * FROM products WHERE Name = '" + name + "'";
                                comm.Connection = conn;
                                comm.CommandText = query;

                                //Converting (Int32)comm.ExecuteScalar() to int to avoid Nullexeption Error
                                int? id = (int?)comm.ExecuteScalar();

                                if (id.HasValue)
                                {
                                   // MessageBox.Show($"Produktet med navnet {name} eksisterer allerede i databasen");
                                }
                                else
                                {
                                    StrQuery = @"INSERT INTO products (Name, Type, Description, ItemNumber, Cost, typeId)  VALUES ("
                                            + "'" + name + "', "
                                            + "'" + type + "', "
                                            + "'" + description + "', "
                                            + "'" + itemNumber + "', "
                                            + cost + ", "
                                            + (i + 1) +
                                           ");";


                                    comm.CommandText = StrQuery;
                                    comm.ExecuteNonQuery();

                                }

                            }
                            mutex.ReleaseMutex();

                        }
                       // MessageBox.Show($"Produkter er opdateret i database");
                    }
                }
            }
            else
            {
                MessageBox.Show("Produkter er ikke opdateret i databasen.\nDer lader til at være problemer med forbindelsen til serveren.");
            }
        }

        //  inesrting and updating DB
        public void StocklistToDB()
        {
            if (isConnected() != false)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;

                using (MySqlConnection conn = new MySqlConnection(mainconn))
                {

                using (MySqlCommand comm = new MySqlCommand())
                {
                    conn.Open();
                        foreach (var stock in StockAdministration.StockList.ToList())
                        {
                            Mutex mutex = new Mutex();
                            mutex.WaitOne();
                            string query = "SELECT id FROM stock WHERE name = '" + stock.Key + "'";

                            comm.Connection = conn;
                            comm.CommandText = query;

                            // Returning the first row with a fit for query
                            int? id = (int?)comm.ExecuteScalar();
                            // if the product exists in stosk, it get updated
                            if (id.HasValue)
                            {
                                string updateQuery = string.Format("UPDATE `stock` SET amount = {0} WHERE name = '{1}'", stock.Value, MySqlHelper.EscapeString(stock.Key));
                                comm.Connection = conn;
                                comm.CommandText = updateQuery;
                                comm.ExecuteNonQuery();
                            }
                            else
                            {
                                // if the product does not exist in stosk, check if product exists in productDB
                                // first match for query returns product id
                                string queryProductId = "SELECT id FROM products  WHERE Name = '" + MySqlHelper.EscapeString(stock.Key) + "'";

                                comm.Connection = conn;
                                comm.CommandText = queryProductId;

                                int? prodId = (int?)comm.ExecuteScalar();
                                //if product exusts it is created in stock
                                if (prodId.HasValue)
                                {
                                    string insertQuery = "INSERT INTO stock(`name`,`amount`,`idProducts`) VALUES('" + stock.Key + "', " + stock.Value + "," + prodId + ")";

                                    comm.Connection = conn;
                                    comm.CommandText = insertQuery;
                                    comm.ExecuteNonQuery();
                                    mutex.ReleaseMutex();
                                }
                                else
                                {
                                    StockAdministration.StockList.Remove(stock.Key);
                                    SaveToXML.SaveStockList();
                                    MessageBox.Show($"PRoduktet {stock.Key} er ikke længere en del af varebestanden");
                                }
                            }
                        }
                        MessageBox.Show("Lagerbestanden er opdateret");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lagerbestanden er ikke opdateret i databasen.\nDer lader til at være problemer med forbindelsen til serveren");
            }
}
        // bulk iiinsertion of sales to DB 
        public static void BulkSalesToDB()
        {
            if (isConnected() != false)
            {

                string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;

            StringBuilder sCommand = new StringBuilder("INSERT INTO sales (sale, time) VALUES ");

            using (MySqlConnection conn = new MySqlConnection(mainconn))
            {
                List<string> Rows = new List<string>();
                var count = Sales.salesList.Count;

               foreach ( var sale in Sales.salesList)
                {
                   Rows.Add(string.Format("('{0}','{1}')", MySqlHelper.EscapeString(sale.Value), sale.Key.ToString("yyyy-MM-dd H:mm:ss")));
                }
                sCommand.Append(string.Join(",", Rows));
                sCommand.Append(";");
                conn.Open();
                using (MySqlCommand myCmd = new MySqlCommand(sCommand.ToString(), conn))
                {
                    myCmd.CommandType = CommandType.Text;
                    myCmd.ExecuteNonQuery();
                }
            }
}
            else
            {
                MessageBox.Show("Salgene er ikke opdateret i databasen.\nDer lader til at være problemer med forbindelsen til serveren");
            }
        }

        // method for removing empty lines with regex and escaping quotes for DB insertion
        public string cleanupString(string str)
        {
            XMLHelper xmlHelp = new XMLHelper();
            str = Regex.Replace(str, @"\s+", " ");
            str = str.Replace("'", "\\'");

            return str;
        }
        public static bool isConnected()
        {
            bool con = false;
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
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
