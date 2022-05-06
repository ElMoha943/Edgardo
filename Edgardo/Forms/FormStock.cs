using Edgardo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edgardo.Forms
{
    public partial class FormStock : Form
    {
        CD_Producto cdp = new CD_Producto();
        DataTable dt = new DataTable();
        public FormStock()
        {
            InitializeComponent();
            dt = cdp.Mostrar();
            dgvProducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cdp.Insertar(textboxId.Texts,textboxNombre.Texts,Convert.ToDecimal(textboxPrecio.Texts));
            textboxId.Texts = textboxNombre.Texts = textboxPrecio.Texts = " ";
            updategrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow r in dgvProducts.SelectedRows)
                    cdp.Eliminar(r.Cells[0].Value.ToString());
                
                MessageBox.Show("Se eliminaron " + dgvProducts.SelectedRows.Count + " productos");
                updategrid();
            }
            else MessageBox.Show("Debe seleccionar una fila para eliminar");
        }
        public void updategrid()
        {
            dt.Clear();
            dt = cdp.Mostrar();
            dgvProducts.Update();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {

        }
    }
}

