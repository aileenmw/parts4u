using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Parts4U
{
    
    public partial class StockAdministration : Form
    {
        /// <summary>
        /// handles creation and deletion of products and adding of products to stock
        /// </summary>
        List<Product> productList = Product.ProductDictionay().SelectMany(x => x.Value).ToList();
        public StockAdministration()
        {
            InitializeComponent();
            UIHelper.FillStockGridWithList(productList.Select(o => o.Name).ToList(), dgvEditProducts);
            UIHelper.FillStockGrid(StockList, dgvStockRefill);

            // Producttype dropdown
            var types = ProductType.GetProductTypes();
            foreach (string type in types)
            {
                cbProductTypes.Items.Add(type);
            }
        }

        public static Dictionary<string, int> StockList = new Dictionary<string, int>();

        // populates/updates Dictionary StockList with products
        // for testing purposes the initial stock amount per product is set to 80 
        public void FillStockList()
        {
            if (File.Exists(XMLPath.XMLStock))
            {
                XDocument xml = XDocument.Load(XMLPath.XMLStock);
                int intCheck;
                foreach (XElement product in xml.Descendants("product"))
                {
                    string name = product.Element("name").Value;
                    string amountString = product.Element("amount").Value;
                    int amount = int.TryParse(amountString, out intCheck) ? Int32.Parse(amountString) : 0;
                    StockList.Add(name, amount);
                }
            }
            else
            {
                // Creates XML file and sets an initial amount of products in stock
                SaveToXML.initialAmountOfProducts(80);
                if (File.Exists(XMLPath.XMLStock))
                {
                    XDocument xml = XDocument.Load(XMLPath.XMLStock);
                    int intCheck;
                    foreach (XElement product in xml.Descendants("product"))
                    {
                        string name = product.Element("name").Value;
                        string amountString = product.Element("amount").Value;
                        int amount = int.TryParse(amountString, out intCheck) ? Int32.Parse(amountString) : 0;
                        StockList.Add(name, amount);
                    }
                }
            }
        }

        // Adds new product to ProductList<Product> and to XMLProducts
         public void CreateProduct()
        {
            string productType = cbProductTypes.Text;
            string name = tbName.Text;
            string type = tbType.Text;
            string description = rtbDescription.Text;
            string itemNumber = tbNumber.Text;
            string cost = tbPrice.Text;

            int amount = (int)nudNewProductAmount.Value;

            if (string.IsNullOrEmpty(cbProductTypes.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbType.Text) || string.IsNullOrEmpty(rtbDescription.Text) || string.IsNullOrEmpty(tbNumber.Text) || string.IsNullOrEmpty(tbPrice.Text) || amount <= 0)
            {
                MessageBox.Show("Udfyld venligst alle felter");
            }
            else
            {
                if (!Product.GetProductTypes().Contains(productType))
                {
                    MessageBox.Show("Du skal vælge en produkttype fra drop-down listen");
                }
                else if (StockList.ContainsKey(name))
                {
                    MessageBox.Show("Der findes allerede en post med samme navn");
                }
                else
                {
                    // Adding new product to ProductList
                    double doubleCheck;
                    double costDouble = double.TryParse(cost, out doubleCheck) ? Double.Parse(cost) : 0;

                    Product product = new Product
                    {
                        Name = name,
                        Type = type,
                        Description = description,
                        ItemNumber = itemNumber,
                        Cost = costDouble
                    };

                    productList.Add(product);
                    SaveToXML.AddProductToProductXML(product, productType);
                    SaveToXML.AddProductToStockXML(product.Name, amount);

                    // Updating delete and stock gridviews
                     updateStockGrids();
                    // emptying create product input controls
                    cbProductTypes.Text = tbName.Text = tbType.Text = tbNumber.Text = tbPrice.Text = rtbDescription.Text = "";
                     MessageBox.Show("Produktet er oprettet");
                }
            }
        }

        // pick product for stock refill
        private void dgvStockRefill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgvStockRefill.SelectedRows[0].Cells["key"].Value.ToString();
            string amountstr = dgvStockRefill.SelectedRows[0].Cells["value"].Value.ToString();
            int intTest;
            int amount = 0;
            if ( int.TryParse(amountstr, out intTest))
            {
                amount = Int32.Parse(amountstr);
            }
            AddToStock addForm = new AddToStock( name, amount, this);
            addForm.Show();
        }

        // pick product for deletion
        private void dgvEditProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgvEditProducts.CurrentCell.Value.ToString();
            DeleteProduct editProduct = new DeleteProduct(name, this);
            editProduct.Show();
        }

        public void updateStockGrids()
        {
            UIHelper.FillStockGrid(StockList, dgvStockRefill);
            var prodList = Product.ProductDictionay().SelectMany(x => x.Value).ToList();
            UIHelper.FillStockGridWithList(prodList.Select(o => o.Name).ToList(), dgvEditProducts);
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProduct();
        }
    }
}
