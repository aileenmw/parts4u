using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Parts4U
{
    public partial class Form1 : Form
    {
        public static string chosenProduct = "";
        // creates productList from ProductDictionay values (which are lists of products)
        List<Product> productList = Product.ProductDictionay().SelectMany(x => x.Value).ToList();
        public Form1()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);

            if (CreateDB.isConnected("BaseConnection") == false)
            {
                MessageBox.Show("Tjek venligst forbindelsen til localhost serveren. En del funktioner vil ikke virke, når der ikke er forbindelse til serveren.");
            }
            else
            {
                MessageBox.Show("Forbindelsen til serveren er oprettet.");
                CreateDB.createDB();
            }


            if (CreateDB.isConnected("Mysqlconnection") == false)
            {
                MessageBox.Show("Tjek venligst forbindelsen til localhost serveren.");
            }
            else
            {
                MessageBox.Show("Forbindelsen til databasen er oprettet.");
                CreateDB.createTables();
            }

            // Reading stock amounts in to grid from XMLStock file
            StockAdministration stock = new StockAdministration();
            stock.FillStockList();

            // Displaying producttypes in combobox
            productTypesCB();

            // Async thread for onlinesales
            Task.Run(() => { OnlineSales(); });
        }

        //displaying productTypes in combobox
        private void productTypesCB()
        {
            List<string> types = ProductType.GetProductTypes();
            foreach (string type in types)
            {
                cbProducType.Items.Add(type);
            }
        }

        private void btnChooseType_Click(object sender, EventArgs e)
        {
            XMLHelper xmlHelp = new XMLHelper();
            XDocument xml = XDocument.Load(XMLPath.XMLProducts);

            // geting products after type is chosen
            // populating listbox for choice of local sales
            List<string> productList = xmlHelp.GetProductValuesByProductType(cbProducType.Text, "name");
            lbProducts.Items.Clear();
            foreach (string product in productList)
            {
                lbProducts.Items.Add(product);
            }
        }

        /// <summary>
        /// asynchronous process simulating online sales
        /// Linq query to get productNameList
        /// a random key i select a product
        /// check with stocklist, whether the item is in stock
        /// add sale to saleslist
        /// update stock and sales lists and controls
        /// 15 seconds sleep
        /// </summary>
        public void OnlineSales()
        {
            while (Sales.onlineSaleIsRunning == true)
            {
                XMLHelper xmlHelp = new XMLHelper();

                List<string> productNameList = productList.Select(p => p.Name).ToList();

                Random random = new Random();

                int i = random.Next(0, productList.Count);

                if (StockAdministration.StockList.ContainsKey(productNameList[i]))
                {
                    var amount = StockAdministration.StockList[productNameList[i]];

                    if (amount > 0)
                    {
                        StockAdministration.StockList[productNameList[i]] = amount - 1;

                        Sales sales = new Sales();
                        sales.AddSales(productNameList[i]);

                        UIHelper.FillStockGrid(Sales.salesPerProduct(), dgvStockDisplay);

                        var lastSale = Sales.salesList.Values.Last();
                        var lastTime = Sales.salesList.Keys.Last();
                        var timeString = lastTime.ToString("HH:mm:ss dd/MM/yy");

                        UIHelper.AppendToListBox(timeString + ": " + lastSale, lbSales);
                    }
                    else
                    {
                        StockAdministration.StockList[productNameList[i]] = 0;
                        continue;
                    }
                }
                Thread.Sleep(15000);
            }
        }

        // for developing and testing purposes 
        private void btnStopOnlineSales_Click(object sender, EventArgs e)
        {
            string txt;
            if (Sales.onlineSaleIsRunning == true)
            {
                Sales.onlineSaleIsRunning = false;
                txt = "Start onlinesale";
            }
            else
            {
                Sales.onlineSaleIsRunning = true;
                txt = "Stop onlinesale";
                Task.Run(() => { OnlineSales(); });
            }

            btnStopOnlineSales.Text = txt;
        }

        private void btntoProductGrid_Click(object sender, EventArgs e)
        {
            ProductGrid grid = new ProductGrid();
            grid.Show();
        }
        private void btnSalesStatistics_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            s.Show();
        }

        //method to update sales' display and list when items are sold in Basket form
        public void RefreshSalesList()
        {
            Sales sales = new Sales();
            lbSales.Items.Clear();
            sales.DisplaySales(lbSales);
        }

        //method to update sales' display and list when local sale is made
        public void RefreshGrid()
        {
            UIHelper.FillStockGrid(Sales.salesPerProduct(), dgvStockDisplay);
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = lbProducts.Items[lbProducts.SelectedIndex].ToString() ?? "";
            ProductDetails pd = new ProductDetails(name, this);
            pd.Show();
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            //creating connection in order to make control updates possible from basket form
            Basket b = new Basket(this);
            b.Show();
        }
        private void btnStockAdmin_Click(object sender, EventArgs e)
        {
            StockAdministration stockAdmin = new StockAdministration();
            stockAdmin.Show();
        }


        private void btnStatus_Click(object sender, EventArgs e)
        {
            Status sts = new Status();
            sts.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Stop async onlinesales while app is updating before closing
            Sales.onlineSaleIsRunning = false;

            //saving product list to database
            SaveToDB db = new SaveToDB();
            db.Products();

            // Insert and update stock DB
            db.StocklistToDB();
            SaveToDB.BulkSalesToDB();

            //creating  and updating xml files
            SaveToXML.SaveProductListToXml();
            SaveToXML.SaveStockList();
            SaveToXML.CreateSalesXML();

            MessageBox.Show("Den aktuelle salgsdata er opdateret.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Parts4U lukker ned.");
        }
    }
}
