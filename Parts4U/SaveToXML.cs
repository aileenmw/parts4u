using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Parts4U
{
    class SaveToXML
    {
        // adding new product to database
        public static void AddProductToProductXML(Product product, string productType)
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();

            var doc = XDocument.Load(XMLPath.XMLProducts);

            var newElement = new XElement("product",
                      new XElement("name", product.Name),
                      new XElement("type", product.Type),
                      new XElement("description", product.Description),
                      new XElement("itemNumber", product.ItemNumber),
                      new XElement("cost", product.Cost));

            var productTypeElement = doc.Descendants("productType")
                   .Where(x => (string)x.Attribute("title") == productType)
                   .FirstOrDefault();


            productTypeElement.Add(newElement);

            doc.Save(XMLPath.XMLProducts);
            mutex.ReleaseMutex();
        }


        //Deleting Product from Products.xml
        public static void RemomveFromProductXML(string name)
        {

            XElement xdoc = XElement.Load(XMLPath.XMLProducts);

            var x = (from product in xdoc.Elements("productType").Descendants("product")
                     where product.Element("name").Value == name
                     select product).Single();

            x.Remove();
            xdoc.Save(XMLPath.XMLProducts);

        }

        public static void SaveProductListToXml()
        {
            List<Product> ProductList = new List<Product>();

            String xml_string = @"<productListing>
                                     </productListing>";

            //prepare XDocument
            XDocument xDoc = XDocument.Parse(xml_string);
            XMLHelper xmlHelp = new XMLHelper();

            xDoc.Element("productListing").Add(new XAttribute("title", "Motorudstyr butik"));

            foreach (string type in Product.GetProductTypes())
            {

                IEnumerable<object> productList = Product.ProductDictionay().Where(x => x.Key == type).SelectMany(x => x.Value);
                // convert iEnumarable to List<Product>
                ProductList = productList.Cast<Product>().ToList();


                xDoc.Element("productListing").Add(
                                           new XElement("productType", new XAttribute("title", type),//));

                                  from p in ProductList
                                  select new XElement("product",
                                                new XElement("name", p.Name),
                                                new XElement("type", p.Type),
                                                new XElement("description", p.Description),
                                                new XElement("itemNumber", p.ItemNumber),
                                                new XElement("cost", p.Cost)
                                                )));
            }

            xDoc.Save(XMLPath.XMLProducts);
        }

        //Adding new product to stockList
        public static void AddProductToStockXML(string name, int amount)
        {
            StockAdministration.StockList.Add(name, amount);

            //Adding to stock xml
            var docStock = XDocument.Load(XMLPath.XMLStock);

            var stockElement = new XElement("product",
                      new XElement("name", name),
                      new XElement("amount", amount));

            var stockElements = docStock.Descendants("products").FirstOrDefault();

            stockElements.Add(stockElement);
            docStock.Save(XMLPath.XMLStock);
        }

        // Removing new product to stockList
        public static void RemoveFromStockXml( string name)
        {
            if (File.Exists(XMLPath.XMLStock))
            {
                XElement stockDoc = XElement.Load(XMLPath.XMLStock);
                try
                {
                    var item = (from product in stockDoc.Descendants("product")
                                where product.Element("name").Value == name
                                select product).Single();
                    item.Remove();
                    stockDoc.Save(XMLPath.XMLStock);

                    MessageBox.Show($"Produktet {name} er blevet fjernet fra Lagerlisten");
                }
                catch
                {
                    MessageBox.Show($"Produktet {name} er ikke på Lagerlisten");
                }
            }
            else
            {
                SaveStockList();
            }
                Product.ProductDictionay().Clear();
                Product.ProductDictionay();
                StockAdministration.StockList.Remove(name);
        }


           // Read XMLStock into system -> populate StockList
        public static void SaveStockList()
        {
            String xml_string = @"<products>
                                 </products>";

            //prepare XDocument
            XDocument xDoc = XDocument.Parse(xml_string);
            XMLHelper xmlHelp = new XMLHelper();

            foreach ( var product in StockAdministration.StockList)
            {
                xDoc.Element("products").Add(
                                    new XElement("product",
                                    new XElement("name", product.Key),
                                    new XElement("amount", product.Value)
                                    ));
            }

            xDoc.Save(XMLPath.XMLStock);
        }

        // sales xml is created
        public static void CreateSalesXML()
        {
            String xml_string = @"<sales>
                                 </sales>";

            //prepare xml
            XDocument xDoc = XDocument.Parse(xml_string);

            foreach (var sale in Sales.salesList)
            {
                XMLHelper xmlHelper = new XMLHelper();

                xDoc.Element("sales").Add(
                    new XElement("sale",
                    new XElement("name", sale.Value),
                    new XElement("time", sale.Key)
                    ));
            }

            DateTime date = new DateTime();
            date.ToString("yyyy-MM-dd_HH-mm");
            xDoc.Save(XMLPath.ProjectPath + "SalesXML/XMLSales-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xml");
        }

        // Set initial amount of products automatically - quickFix to get data for testing or when project is initialized
        public static void initialAmountOfProducts(int amount)
        {
            if (!File.Exists(XMLPath.XMLStock))
            {

                String xml_string = @"<products>
                                 </products>";

                //prepare XDocument
                XDocument xDoc = XDocument.Parse(xml_string);
                XMLHelper xmlHelp = new XMLHelper();

                // List of products disconcerning ptoductType
                List<Product> productList = Product.ProductDictionay().SelectMany(x => x.Value).ToList();

                foreach (var name in xmlHelp.GetValuesByNodeName("name"))
                {
                    XMLHelper xmlHelper = new XMLHelper();


                    xDoc.Element("products").Add(
                                        new XElement("product",
                                        new XElement("name", name),
                                        new XElement("amount", amount)
                                        ));
                }

                xDoc.Save(XMLPath.XMLStock);
            }
        }
    }
}
