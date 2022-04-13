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
using Edgardo.Datos;
using Edgardo.Models;

namespace Edgardo.Forms
{
    public class product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    public partial class FormRegister : Form
    {
        CD_Producto db = new CD_Producto();
        DataTable busqueda;
        List<product> products = new List<product>();
        public decimal total = 0;

        public FormRegister()
        {
            InitializeComponent();

            //Configuracion del DGV
            dgvTicket.Columns.Add("Producto", "Producto");
            dgvTicket.Columns.Add("Precio", "Precio");
            dgvTicket.DataSource = products;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            Venta v = new Venta
            {
                Fecha = DateTime.Now,
                Total = total
            };

            //Insertar venta en base de datos!

            total = 0;
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool existe = false; //Variablep ara chequear si el producto ya esta en el carrito
            if(e.KeyChar == '\r')
            {
                busqueda = db.Buscar(textBoxCodigo.Text); //Buscamos el producto en la base de datos
                if (busqueda.Rows.Count > 0)
                {
                    Producto p = new Producto //Guardamos los datos de la busqueda en un nuevo objeto
                    {
                        Id = busqueda.Rows[0].ToString(),
                        Name = busqueda.Rows[1].ToString(),
                        Price = Convert.ToDecimal(busqueda.Rows[2].ToString()),
                        Stock = Convert.ToInt32(busqueda.Rows[3].ToString())
                    };

                    //Actualizamos los labels del formulario
                    labelNombre.Text = p.Name;
                    labelCosto.Text = p.Price.ToString();

                    for(int i=0; i<products.Count; i++)
                    {
                        if (products[i].Name == p.Name) //Si el producto esta en el carro, aumentamos su cantidad
                        {
                            products[i].Quantity += 1;
                            existe = true;
                            break;
                        }
                    }

                    if (!existe) products.Add(new product //Si el producto no esta en el carro, lo añadimos
                    {
                        Name = p.Name,
                        Price = p.Price,
                        Quantity = 1
                    });

                    total += p.Price; //Agregamos el precio del producto al total.
                    labelTotal.Text = total.ToString();
                }
                else //Si el producto no existe tiramos un error.
                {
                    MessageBox.Show("Producto no encontrado");
                }
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
                e.Graphics.DrawString(p.Name, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(8, line));
                e.Graphics.DrawString(p.Quantity.ToString(), new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(70, line));
                e.Graphics.DrawString("$" + p.Price, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(105, line));
                e.Graphics.DrawString("$"+p.Price * p.Quantity, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(145, line));
            }
            line += 6;
            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(8, line));
            line += 8;
            e.Graphics.DrawString("TOTAL: $"+total, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(8, line));
        }
    }
}
