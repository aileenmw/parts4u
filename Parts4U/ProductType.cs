using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Parts4U
{
    public class ProductType
    {
       // fetches productTypes with Linq query from xml file and creates a list
        public static List<string> GetProductTypes()
        {
            XDocument scan = XDocument.Load(XMLPath.XMLProducts);

            List<string> types = new List<string>();
            foreach (XElement element in scan.Descendants("productType"))
            {
                string type = element.Attribute("title").Value;
                types.Add(type);
            }
            return types;
        }
    }
}
