using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Parts4U
{
    public partial class AddToStock : Form
    {
        /// <summary>
        /// Adds amount to the amount stocklist for a certain product
        /// Updates the stock list in the stockadministratin form
        /// </summary>
        /// 
        string ProdName;
        int Amount;
        private readonly StockAdministration StockAdm;
        public AddToStock(string name, int amount, StockAdministration stockAdm)
        {
            InitializeComponent();

            this.ProdName = name;
            this.Amount = amount;
            StockAdm = stockAdm;

            lblName.Text = ProdName;
            lblAmount.Text = Amount.ToString();
        }

        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            int addition = (int)nudAddAmount.Value;

            StockAdministration.StockList[ProdName] = Amount + addition;
            StockAdm.updateStockGrids();
            MessageBox.Show("Antallet er opdateret");
            Close();
        }
    }
}
