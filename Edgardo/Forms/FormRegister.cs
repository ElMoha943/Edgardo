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
        List<product> products = new List<product>();
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
                Producto p = db.getProductById(textBoxCodigo.Text);
                labelNombre.Text = p.Name;
                labelCosto.Text = p.Price.ToString();
                dgvTicket.Rows.Add(p.Name, p.Price);
                textBoxCodigo.Texts = "";
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int line = 10;
            e.Graphics.DrawString("ALMACEN EB", new Font("Arial", 64, FontStyle.Regular), Brushes.Black, new Point(120,line));
            line += 90;
            e.Graphics.DrawString("Chile 971 - B° PALMAR", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(180, line));
            line += 50;
            //e.Graphics.DrawString("----------------------------------------------------", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            //line += 40;
            //e.Graphics.DrawString("A CONSUMIDOR FINAL", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            //line += 40;
            e.Graphics.DrawString("----------------------------------------------------", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            line += 40;
            e.Graphics.DrawString("Fecha:", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(560, line));
            line += 50;
            e.Graphics.DrawString("Hora:", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(650, line));
            line += 50;
            e.Graphics.DrawString("NR.T:", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            e.Graphics.DrawString(10.ToString(), new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(710, line));
            line += 40;
            e.Graphics.DrawString("----------------------------------------------------", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            line += 40;
            e.Graphics.DrawString("Prodcuto", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(10, line));
            e.Graphics.DrawString("Cantidad", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(310, line));
            e.Graphics.DrawString("Unidad", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(510, line));
            e.Graphics.DrawString("Total", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(710, line));
            line += 30;
            e.Graphics.DrawString("----------------------------------------------------", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            foreach (product p in products)
            {
                line += 50;
                e.Graphics.DrawString(p.name, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(10, line));
                e.Graphics.DrawString(p.quantity.ToString(), new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(310, line));
                e.Graphics.DrawString("$" + p.price, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(510, line));
                e.Graphics.DrawString("$"+p.price * p.quantity, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(710, line));
            }
            line += 40;
            e.Graphics.DrawString("----------------------------------------------------", new Font("Arial", 32, FontStyle.Regular), Brushes.Black, new Point(10, line));
            line += 40;
            e.Graphics.DrawString("TOTAL: $"+v.Total, new Font("Arial", 48, FontStyle.Regular), Brushes.Black, new Point(10, line));
        }
    }
}
