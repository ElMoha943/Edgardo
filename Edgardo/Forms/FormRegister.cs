using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edgardo.Models;

namespace Edgardo.Forms
{
    public partial class FormRegister : Form
    {
        Dashboard db = new Dashboard();
        BindingList<product> products = new BindingList<product>();
        Venta v = new Venta();
        struct product
        {
            public string name;
            public int quantity;
            public decimal price;
        }

        public FormRegister()
        {
            InitializeComponent();
            dgvTicket.Columns.Add("Producto", "Producto");
            dgvTicket.Columns.Add("Precio", "Precio");

            //TEST
            products.Add(new product
            {
                name = "Test",
                quantity = 12,
                price = (decimal)10.50,
            });
            products.Add(new product
            {
                name = "Test2",
                quantity = 5,
                price = (decimal)3.75,
            });
            v.Total = (decimal)(5 * 3.75 + 12 * 10.5);

            dgvTicket.DataSource = products;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                Producto p;
                try
                {
                    p = db.getProductById(textBoxCodigo.Text);   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                labelNombre.Text = p.Name;
                labelCosto.Text = p.Price.ToString();
                dgvTicket.Rows.Add(p.Name, p.Price);
                textBoxCodigo.Texts = "";
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int line = 10;
            e.Graphics.DrawString("ALMACEN EB", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(8,line));
            line += 30;
            e.Graphics.DrawString("Chile 971 - B° PALMAR", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(24, line));
            line += 10;
            //e.Graphics.DrawString("------------------------------------------------", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(8, line));
            //line += 8;
            //e.Graphics.DrawString("A CONSUMIDOR FINAL", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(8, line));
            //line += 8;
            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            line += 8;
            e.Graphics.DrawString("Fecha:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(125, line));
            line += 10;
            e.Graphics.DrawString("Hora:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(148, line));
            line += 10;
            e.Graphics.DrawString("NR.T:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            e.Graphics.DrawString(10.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(148, line));
            line += 8;
            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            line += 8;
            e.Graphics.DrawString("Prodcuto", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(8, line));
            e.Graphics.DrawString("Cantidad", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(60, line));
            e.Graphics.DrawString("Unidad", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(105, line));
            e.Graphics.DrawString("Total", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(145, line));
            line += 6;
            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            foreach (product p in products)
            {
                line += 10;
                e.Graphics.DrawString(p.name, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(8, line));
                e.Graphics.DrawString(p.quantity.ToString(), new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(70, line));
                e.Graphics.DrawString("$" + p.price, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(105, line));
                e.Graphics.DrawString("$"+p.price * p.quantity, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(145, line));
            }
            line += 6;
            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            line += 8;
            e.Graphics.DrawString("TOTAL: $"+v.Total, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(8, line));
        }
    }
}
