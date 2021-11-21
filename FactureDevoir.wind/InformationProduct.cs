using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureDevoir.wind
{
    public partial class InformationProduct : Form
    {
        private bool exitApp = true;
        public static string L1;
        public static double L2;
        public static int L3;
        public InformationProduct()
        {
            InitializeComponent();
        }
        private void correspondance()
        {
            L1 = txtNom.Text;
            L2 = double.Parse(txtsomme.Text);
            L3 = int.Parse(txtquantite.Text);
        }

        private void btngenerer_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtsomme.Text == "" || txtquantite.Text == "")
            {
                MessageBox.Show(" champ vide!!", " error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                correspondance();
                var form = new previewUser();
                form.Show();
                exitApp = false;
                this.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (exitApp)
                Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new InformationFacture();
            form.Show();
            exitApp = false;
            this.Close();
        }

        private void InformationProduct_Load(object sender, EventArgs e)
        {
            txtNom.Text = "Banane";
            txtquantite.Text = "50";
            txtsomme.Text = "20000";
        }
    }
}
