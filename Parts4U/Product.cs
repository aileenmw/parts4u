using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Parts4U
{
    public class Product : ProductType
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string ItemNumber { get; set; }
        public double Cost { get; set; }


        // Dictionary with pruductType as keys and a lists of products as values matching the xml file with products
        public static Dictionary<string, List<Product>> ProductDictionay()
        {
            XMLHelper xmlHelp = new XMLHelper();
            Dictionary<string, List<Product>> productDic = new Dictionary<string, List<Product>>();
            XDocument xml = XDocument.Load(XMLPath.XMLProducts);

            List<Product> productList = new List<Product>();

            foreach (string type in GetProductTypes())
            {

            IEnumerable<Product> products = from product in xml.Element("productListing").Descendants("product")
                                            where product.Parent.Attribute("title").Value == type
                                            select new Product
                                            {
                                                Name =  product.Element("name").Value,
                                                Type = product.Element("type").Value,
                                                Description =  xmlHelp.RemoveWhitelines(product.Element("description").Value),
                                                ItemNumber = product.Element("itemNumber").Value,
                                                Cost = Convert.ToDouble(product.Element("cost").Value)
                                            };

                productList= products.ToList();

                productDic.Add(type, productList);
            }
            return productDic;
        }
    }
}                   