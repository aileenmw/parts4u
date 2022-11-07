using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Linq;

namespace Parts4U
{
    public class XMLHelper
    {
        /// <summary>
        /// methods with Linq queries for retriving data from xml files with selfexplanatory naming
        /// </summary>
        /// <param name="typeOfProduct"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>

        // public  Tuple< GetNodeValueAndAttribute
        public List<string> GetProductValuesByProductType(string typeOfProduct, string nodeName)
        {
            XDocument xml = XDocument.Load(XMLPath.XMLProducts);

            IEnumerable<string> productNames = from productType in xml.Element("productListing").Descendants("productType")
                                               from names in productType.Descendants(nodeName)
                                               where productType.Attribute("title").Value == typeOfProduct
                                               select names.Value;

           List<string> productList = productNames.ToList();

            return productList;
        }


        public List<string> GetValuesByNodeName(string nodeName)
        {
            XDocument xml = XDocument.Load(XMLPath.XMLProducts);

            List<string> elList = new List<string>();

            foreach (XElement element in xml.Descendants(nodeName))
            {
                string el = element.Value;
                elList.Add(el);
            }
            return elList;
        }

        public Dictionary<string, string> GetProductDataByName(string name)
        {
            XDocument xml = XDocument.Load(XMLPath.XMLProducts);
            var product = (from productData in xml.Element("productListing").Descendants("product")
                           where productData.Element("name").Value == name
                           select new {
                               name = productData.Element("name").Value,
                               type = productData.Element("type").Value,
                               description = productData.Element("description").Value,
                               itemNumber = productData.Element("itemNumber").Value,
                               cost = productData.Element("cost").Value}).Single();


                    string pName = product.name.ToString();
                    string pType = product.type.ToString();
                    string pDescription = RemoveWhitelines(product.description.ToString());
                    string pItemNumber = product.itemNumber.ToString();
                    string pCost = product.cost.ToString();

            Dictionary<string, string> ProdData = new Dictionary<string, string>();
            ProdData.Add("name", pName);
            ProdData.Add("type", pType);
            ProdData.Add("description", pDescription);
            ProdData.Add("itemNumber", pItemNumber);
            ProdData.Add("cost", pCost);

            return ProdData;
        }

        public string RemoveWhitelines(string str)
        {
            str = Regex.Replace(str, @"\s+", " ");
            return str.ToString();
        }
    }
}
