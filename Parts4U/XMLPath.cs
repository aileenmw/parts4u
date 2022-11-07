using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parts4U
{

    static class XMLPath
    {
        /// <summary>
        /// static path for xml files and projectpath
        /// </summary>
        
        //static string startupPath = System.IO.Directory.GetCurrentDirectory();
        static string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
        static string exeDir = Path.GetDirectoryName(exeFile);
        public static string ProjectPath = Path.Combine(exeDir, "..\\..\\");

        private static string _products = ProjectPath + "XMLFiles/XMLProducts.xml";
        private static string _stock = ProjectPath + "XMLFiles/XMLStock.xml";

        public static string XMLProducts
            {
                get { return _products; }
                set { _products = value; }
            }
        public static string XMLStock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
