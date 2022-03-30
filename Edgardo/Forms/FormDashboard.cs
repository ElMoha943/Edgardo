using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edgardo
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            chartSales.Series[0].Points.AddXY(DateTime.Today, 100);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("23/03/22"), 200);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("24/03/22"), 250);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("25/03/22"), 150);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("26/03/22"), 50);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("27/03/22"), 100);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("28/03/22"), 150);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("29/03/22"), 170);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("30/03/22"), 300);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("1/04/22"), 250);
            chartSales.Series[0].Points.AddXY(DateTime.Parse("2/04/22"), 350);


            chartTopProducts.PaletteCustomColors = new Color[] { Color.MediumSpringGreen, Color.CornflowerBlue, Color.BlueViolet, Color.DeepPink, Color.Crimson };
            chartTopProducts.Series[0].Points.AddXY("Cocacola",10);
            chartTopProducts.Series[0].Points.AddXY("Alfajor", 5);
            chartTopProducts.Series[0].Points.AddXY("Helado", 15);
            chartTopProducts.Series[0].Points.AddXY("Carbon", 3);
            chartTopProducts.Series[0].Points.AddXY("Chocolate", 20);

            dgvLowStock.Columns.Add("Producto", "Producto");
            dgvLowStock.Columns.Add("Stock", "Stock");
            dgvLowStock.Rows.Add("Cocacola", 20);
            dgvLowStock.Rows.Add("Alfajor", 25);
            dgvLowStock.Rows.Add("Helado", 15);
            dgvLowStock.Rows.Add("Carbon", 27);
            dgvLowStock.Rows.Add("Chocolate", 10);

            dgvLowStock.Columns[1].Width = 50;
        }
    }
}
