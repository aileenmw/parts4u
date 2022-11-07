using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts4U
{
    public partial class Statistics : Form
    {
        /// <summary>
        /// fetching sales for a certain product in a chosen timespan today
        /// </summary>
        XMLHelper xmlHelper = new XMLHelper();
        public Statistics()
        {
            InitializeComponent();

            foreach (string type in ProductType.GetProductTypes())
            {
                cbPickType.Items.Add(type);
            }
            setIntervalPicker();
        }

        // picing product
        private void cbPickType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProductNumber.Items.Clear();
            List<string> names = xmlHelper.GetProductValuesByProductType(cbPickType.SelectedItem.ToString(), "name");
            foreach (string name in names)
            {
                var data = xmlHelper.GetProductDataByName(name);
                cbProductNumber.Items.Add(data["itemNumber"]);
            }
        }

        // setting interval
        public void setIntervalPicker()
        {
            DateTime start = DateTime.Today;
            for (int i = 0; i < 48; i++)
            {
                cbStartTime.Items.Add(start.AddMinutes(30 * i).ToString("HH:mm"));
            }

            DateTime end = DateTime.Today.AddMinutes(30);
            for (int i = 0; i < 48; i++)
            {
                cbEndTime.Items.Add(end.AddMinutes(30 * i).ToString("HH:mm"));
            }
        }


        /// dictionary of sales in interval
        public static Dictionary<DateTime, string> SalesInInterval(DateTime start, DateTime end)
        {
            Dictionary<DateTime, string> sales = new Dictionary<DateTime, string>();
            foreach (var item in Sales.salesList)
            {
                DateTime saleTime = item.Key;

                if (saleTime > start && saleTime < end)
                {
                    sales.Add(item.Key, item.Value);
                }
            }

            return sales;
        }

        // getting dates, name and itemnumber for sales in interval and displaying them in listbox
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;

                if (cbStartTime.SelectedItem != null && cbEndTime.SelectedItem != null)
                {
                    DateTime start = DateTime.Parse(cbStartTime.SelectedItem.ToString());
                    DateTime end = DateTime.Parse(cbEndTime.SelectedItem.ToString());

                    if (end < start)
                    {
                        MessageBox.Show("End time must be after start time");
                    }
                    else if (cbProductNumber.SelectedItem != null)
                    {
                        lbIntervalSales.Items.Clear();
                        var intervalSales = SalesInInterval(start, end);
                        if (intervalSales.Count == 0)
                        {
                            lbIntervalSales.Items.Add("No sales in this timespan");
                        }
                        foreach (var sales in intervalSales)
                        {
                            var data = xmlHelper.GetProductDataByName(sales.Value);

                            if (data["itemNumber"] == cbProductNumber.SelectedItem.ToString())
                            {
                                lbIntervalSales.Items.Add(sales.Key + ": " + sales.Value);

                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vælg produkt og interval for at se oversigt");
            }
        }

    }
}
