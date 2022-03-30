using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edgardo.Models;

namespace Edgardo
{
    public partial class FormDashboard : Form
    {
        Dashboard dboard = new Dashboard();
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            //SALES CHART
            foreach(Venta v in dboard.GetSales())
            {
                chartSales.Series[0].Points.AddXY(v.Fecha, v.Total);
            }
            

            //TOP PRODUCTS CHART
            chartTopProducts.PaletteCustomColors = new Color[] { Color.MediumSpringGreen, Color.CornflowerBlue, Color.BlueViolet, Color.DeepPink, Color.Crimson };
            chartTopProducts.Series[0].Points.AddXY("Cocacola",10);
            chartTopProducts.Series[0].Points.AddXY("Alfajor", 5);
            chartTopProducts.Series[0].Points.AddXY("Helado", 15);
            chartTopProducts.Series[0].Points.AddXY("Carbon", 3);
            chartTopProducts.Series[0].Points.AddXY("Chocolate", 20);

            //LOW STOCK GRID
            dgvLowStock.Columns.Add("Producto", "Producto");
            dgvLowStock.Columns.Add("Stock", "Stock");
            dgvLowStock.Columns[1].Width = 50;

            foreach (KeyValuePair<string,int> kvp in dboard.GetUnderStock())
            {
                dgvLowStock.Rows.Add(kvp.Key, kvp.Value);
            }
           
            //COUNT LABELS
            labelTotalClients.Text = dboard.NumClientes.ToString();
            labelTotalProducts.Text = dboard.NumProductos.ToString();
            labelCountSales.Text = dboard.NumVentas.ToString();
            labelCountIncome.Text = "$ " + dboard.Ingresos.ToString();
            labelCountProfit.Text = "$ "+ dboard.Ganancias.ToString();
        }
    }
}
