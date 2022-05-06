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
    public partial class FormRegister : Form
    {
        CD_Producto cdp = new CD_Producto();
        CD_Venta cdv = new CD_Venta();
        DataTable busqueda = new DataTable();
        BindingList<product> products = new BindingList<product>();
        public decimal total = 0;

        public FormRegister()
        {
            InitializeComponent();

            //Configuracion del DGV
            dgvTicket.DataSource = products;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                //Insertar venta en base de datos!
                cdv.Insertar(DateTime.Now, total, products);

                total = 0;
                products.Clear();

                dgvTicket.Update();
                dgvTicket.Refresh();

                labelNombre.Text = "Producto: ";
                labelCosto.Text = "Costo:";
                labelTotal.Text = "Total: $" + total;
            }
            else
            {
                MessageBox.Show("El carro esta vacio");
            }
        }

        private void addToCart()
        {
            bool existe = false; //Variablep ara chequear si el producto ya esta en el carrito
            busqueda.Clear();
            busqueda = cdp.Buscar(textBoxCodigo.Texts); //Buscamos el producto en la base de datos
            if (busqueda.Rows.Count > 0)
            {
                Producto p = new Producto //Guardamos los datos de la busqueda en un nuevo objeto
                {
                    Id = busqueda.Rows[0][0].ToString(),
                    Name = busqueda.Rows[0][1].ToString(),
                    Price = Convert.ToDecimal(busqueda.Rows[0][2].ToString()),
                    Stock = Convert.ToInt32(busqueda.Rows[0][3].ToString())
                };

                //Actualizamos los labels del formulario
                labelNombre.Text = "Producto: " + p.Name;
                labelCosto.Text = "Costo: $" + p.Price;

                for (int i = 0; i < products.Count; i++)
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
                labelTotal.Text = "Total: $" + total;
            }
            else //Si el producto no existe tiramos un error.
            {
                MessageBox.Show("Producto no encontrado");
            }
            textBoxCodigo.Texts = "";
            dgvTicket.Update();
            dgvTicket.Refresh();
        }

        private void remProduct()
        {
            if (dgvTicket.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvTicket.SelectedRows)
                {
                    total -= ((decimal)r.Cells[1].Value) * (int)r.Cells[2].Value; 
                    labelTotal.Text = "Total: $" + total;
                    products.Remove(products[r.Index]);
                }    
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

        //private void textBoxCodigo_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if(textBoxCodigo.Texts == "Codigo del producto...")
        //    {
        //        textBoxCodigo.Texts = "";
        //    }
        //}

        private void textBoxCodigo_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxCodigo.Texts == "Codigo del producto...")
            {
                textBoxCodigo.Texts = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            remProduct();
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                addToCart();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToCart();
        }
    }

    public class product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
