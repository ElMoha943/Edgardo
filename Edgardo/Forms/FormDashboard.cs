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
        CD_Dashboard dboard = new CD_Dashboard();
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

            int i = 0;
            foreach (KeyValuePair<string, int> kvp in dboard.GetTopProducts())
            {
                chartTopProducts.Series[0].Points.AddY(kvp.Value);
                chartTopProducts.Series[0].Points[i].LegendText = kvp.Key;
                i++;
            }

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
            labelTotalProviders.Text = dboard.NumProveedores.ToString();
            labelCountSales.Text = dboard.NumVentas.ToString();
            labelCountIncome.Text = "$ " + dboard.Ingresos.ToString();
            labelCountProfit.Text = "$ "+ dboard.Ganancias.ToString();
        }
    }
}
