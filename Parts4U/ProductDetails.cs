using FSharp.Data.Runtime;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Parts4U
{
    public partial class ProductDetails : Form
    {
        /// <summary>
        /// product chosen in Form1 get either sold or saved in basket
        /// 
        /// </summary>
        private readonly Form1 form1;
        public ProductDetails(string name, Form1 form)
        {
            InitializeComponent();
            this.Value = name;
            form1 = form;

            XMLHelper xmlHelp = new XMLHelper();
            var data = xmlHelp.GetProductDataByName(Value);

            foreach (var d in data)
            {
                rtbProductDetails.AppendText(nodeToUI[d.Key] + ": " + d.Value + "\n");
            }
        }
        public string Value { get; set; }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
           lblProductName.Text = Value;
        }

        public static Dictionary<string, string> nodeToUI = new Dictionary<string, string>(){
                {"name", "Produktnavn"},
                {"type", "Type"},
                {"description", "Beskrivelse"},
                {"itemNumber", "Produktnr."},
                {"cost", "Pris"}
        };

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            // Adding to saleslist
            Sales sales = new Sales();
            sales.AddSales(lblProductName.Text);

            //subtracting item from stocklist
            var amount = StockAdministration.StockList[lblProductName.Text];
            StockAdministration.StockList[lblProductName.Text] = amount - 1;

            //Updating saleslist and stockgrid in mainform
            form1.RefreshSalesList();
            form1.RefreshGrid();
            Close();
        }

        // product gets stores in basketlist
        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.AddToBasket(lblProductName.Text);
            Close();
        }
    }
}
