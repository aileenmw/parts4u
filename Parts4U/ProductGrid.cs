using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts4U
{
    public partial class ProductGrid : Form
    {
        /// <summary>
        /// products from each type are displayed in datagridviews
        /// click on label displays chosen type
        /// </summary>
        
        private static readonly string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;
        List<Product> products = new List<Product>();
        public ProductGrid()
        {
            InitializeComponent();
            FillGrid();
        }

        public void FillGrid()
        {
           
            foreach (var type in ProductType.GetProductTypes())
            {

                List<Product> ProductList = new List<Product>();
                IEnumerable<object> productList = Product.ProductDictionay().Where(x => x.Key == type).SelectMany(x => x.Value);
                // convert iEnumarable to List<Product>
                ProductList = productList.Cast<Product>().ToList();

                switch (type)
                {

                    case "Bil produkter":
                        dgvCar.DataSource = ProductList;
                        dgvCar.Rows[0].HeaderCell.Value =  type;
                        break;

                    case "Motorcykel produkter":
                        dgvMotorbike.DataSource = ProductList;
                        dgvMotorbike.Rows[1].HeaderCell.Value = type;
                        break;
                    case "Cykel produkter":
                        dgvBike.DataSource = ProductList;
                        dgvBike.Rows[2].HeaderCell.Value = type;
                        break;
                }
            }
        }

        private void lblCar_Click(object sender, EventArgs e)
        {
            if (dgvMotorbike.Visible == true)
            {
                dgvMotorbike.Visible = false;
            }
            if (dgvBike.Visible == true)
            {
                dgvBike.Visible = false;
            }
            dgvCar.Visible = true;
        }

        private void lblMotorbike_Click(object sender, EventArgs e)
        {
            if (dgvCar.Visible == true)
            {
                dgvCar.Visible = false;
            }
            if (dgvBike.Visible == true)
            {
                dgvBike.Visible = false;
            }
            dgvMotorbike.Visible = true;
        }


        private void lblBike_Click(object sender, EventArgs e)
        {
            if (dgvCar.Visible == true)
            {
                dgvCar.Visible = false;
            }
            if (dgvMotorbike.Visible == true)
            {
                dgvMotorbike.Visible = false;
            }
            dgvBike.Visible = true;
        }
    }
}
