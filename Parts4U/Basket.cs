using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts4U
{
    public partial class Basket : Form
    {
        /// <summary>
        /// displays the chosen products from baskeetList
        /// adds the prices
        /// updates salesList and inserts sale to the 'runnung' salesdisplay in Form1
        /// </summary>


        private readonly Form1 form1;
        public Basket(Form1 form)
        {
            InitializeComponent();

            form1 = form;

            Sales sales = new Sales();
            sales.DisplayBasketItems(lbBasketItems, tbSum);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            var basketItems = Sales.basketList;

            if (basketItems.Count != 0)
            {
                foreach (var item in basketItems)
                {
                    sales.AddSales(item.Key);

                    // making sure 2 sales don't have the same dateime value
                    Thread.Sleep(10);

                    // subtracting item from stock
                    var amount = StockAdministration.StockList[item.Key];
                    StockAdministration.StockList[item.Key] = amount - 1;
                }

                //Updating saleslist and stockgrid in mainform
                form1.RefreshSalesList();
                form1.RefreshGrid();

                Sales.basketList.Clear();
                basketItems.Clear();

                MessageBox.Show("Købet er gennemført");
                Close();
            }
            else
            {
                Close();
            }
        }
    }
}
