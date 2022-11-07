using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Parts4U
{
    public partial class DeleteProduct : Form
    {
        /// <summary>
        /// removes chosen items frm product and stock lists
        /// updates stock and product xml files
        /// updates product and stock displays in the StockAdminstation form
        /// </summary>
        
        string Name;
        private readonly StockAdministration StockAdm;
        Dictionary<string, List<Product>> productDic = Product.ProductDictionay();
        public DeleteProduct(string name, StockAdministration stockAdm)
        {
            InitializeComponent();

            Name = name;
            StockAdm = stockAdm;
            lblDelete.Text = $"Vil du slette\n {Name} ?";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();

            SaveToXML.RemomveFromProductXML(Name);
            SaveToXML.RemoveFromStockXml(Name);

            if (StockAdministration.StockList.ContainsKey(Name))
            {
                StockAdministration.StockList.Remove(Name);
            }
            
            Product.ProductDictionay().Clear();
            Product.ProductDictionay();
             
            mutex.ReleaseMutex();

            StockAdm.updateStockGrids();
            Close();

        }
    }
}
