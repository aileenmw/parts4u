using Newtonsoft.Json;
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
    public partial class Status : Form
    {
        /// <summary>
        /// status of days sales in ordered descending by amount of sales per product
        /// </summary>
        public Status()
        {
            InitializeComponent();
            AddSalesToGrid();
        }

        private void AddSalesToGrid()
        {
            DataTable dt = new DataTable();
            //create some columns for the datatable
            DataColumn dc = new DataColumn("Product.no.");
            DataColumn dc2 = new DataColumn("Product");
            DataColumn dc3 = new DataColumn("Daily Sales");
            //add the columns to the datatable
            dt.Columns.Add(dc);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);

            var salesDescending = Sales.salesPerProduct().OrderByDescending(x => x.Value);

            foreach (var sale in salesDescending)
            {
                XMLHelper xmlHelp = new XMLHelper();
                var product = xmlHelp.GetProductDataByName(sale.Key);
                var itemNmnb = product["itemNumber"];

                //create a new row based on the existing "row model"
                DataRow dr = dt.NewRow();
                dr["Product.no."] = sale.Key;
                dr["Product"] = itemNmnb;
                dr["Daily Sales"] =sale.Value;
                dt.Rows.Add(dr);
            }

            dgvStatus.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}