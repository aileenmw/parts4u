using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Parts4U
{
    public class Sales : Product
    {

        public static bool onlineSaleIsRunning = true;

        public static Dictionary<DateTime, string> salesList = new Dictionary<DateTime, string>();
        public static Dictionary<string, string> basketList = new Dictionary<string, string>();

        /// Displays list of (ongoing) sales
        public void DisplaySales(ListBox lb)
        {
            foreach (KeyValuePair<DateTime, string> sale in salesList)
            {
                UIHelper.AppendToListBox(sale.Key.ToString("HH:mm:ss dd/MM/yy") + ": " +  ShortenString(sale.Value), lb); 
            }
        }

        // Displays sales per product
        public static Dictionary<string, int> salesPerProduct()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string product in StockAdministration.StockList.Keys) 
            {
                int prodSales = productSales(product);
                dic.Add(product, prodSales);
            }
             

            return dic;
        }

        // find the amount of productsales from saleslist
        public static int productSales(string name)
        {
            var products = from product in salesList
                      where product.Value == name
                      select product;

            int sales = products.ToList().Count;
            return sales;
        }

        // Displays list of chosen items in ListBox
        public void DisplayBasketItems(ListBox lb, TextBox tbSum = null)
        {
            if (basketList.Count > 0)
            {
                double priceSum = 0;
                double itemPrice = 0;
                foreach (KeyValuePair<string, string> sale in basketList)
                {
                    UIHelper.AppendToListBox(ShortenString(sale.Key) + ", " + sale.Value, lb);

                    if (Double.TryParse(sale.Value, out itemPrice))
                    {
                        itemPrice = Convert.ToDouble(sale.Value.Replace(".", ","));
                        priceSum += itemPrice;
                    }
                }
                if (tbSum != null)
                {
                  tbSum.Text = "I alt: " + priceSum + " DDK";
                }
            }
            else
            {
                lb.Items.Add("Indkøbskurven er tom");
            }
        }
        
        // Adds time of sale and item name to list of sales
        public void AddSales(string itemName)
        {
            salesList.Add( DateTime.Now, itemName);
        }

        public void AddToBasket(string itemName)
        {
            XMLHelper xmlHelp = new XMLHelper();
            Dictionary<string, string> productData =
                xmlHelp.GetProductDataByName(itemName);

            string price = productData["cost"];

            try
            {
                basketList.Add(itemName, price);
            }
            catch
            {
                MessageBox.Show("This product has already been added");
            }
        }

        // Shortens string down to 100 characters and adds "..." if string is to long for UI
        public string ShortenString( string ToLongString)
        {
            string shortStr = "";
            if (ToLongString.Length > 100)
            {
                shortStr = ToLongString.Substring(0, 100) + "...";
            }
            else
            {
                shortStr = ToLongString;
            }
            return shortStr;
        }
    }
}
