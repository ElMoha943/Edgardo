using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edgardo.Forms;

namespace Edgardo
{
    public partial class FormMain : Form
    {
        private Form ChildForm = new Form();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenChildForm("DashBoard");
        }

        private void OpenChildForm(string type)
        {
            if(ChildForm!= null)
            {
                ChildForm.Close();
            }
            switch (type)
            {
                case "DashBoard":
                    ChildForm = new FormDashboard();
                    break;
                case "Clients":
                    ChildForm = new FormClients();
                    break;
                case "Register":
                    ChildForm = new FormRegister();
                    break;
                case "Stock":
                    ChildForm = new FormStock();
                    break;
                case "Settings":
                    ChildForm = new FormSettings();
                    break;
            }
            ChildForm.TopLevel = false;
            panelChild.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm("DashBoard");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm("Register");
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm("Stock");
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            //OpenChildForm("Clients");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //OpenChildForm("Settings");
        }
    }
}
