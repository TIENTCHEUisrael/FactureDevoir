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
    public partial class InformationFacture : Form
    {
        private bool exitApp = true;
        public static int l1;
        public static string l2;
        public static double l3;
        public static int l4;
        public static int l5;
        public static int l6;
        public InformationFacture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void correspondance()
        {
            l1 = int.Parse(maskNumero.Text);
            l2 = txtimmat.Text;
            l3 = double.Parse(masknumerotva.Text);
            l4 = int.Parse(maskcode.Text);
            l5 = int.Parse(maskfraiderecouvrement.Text);
            l6 = int.Parse(masktauxderetard.Text);
        }
        private void Correspondance1()
        {
            maskNumero.Text = View2.l1.ToString();
            txtimmat.Text = View2.l2;
            masknumerotva.Text = View2.l3.ToString();
            maskcode.Text = View2.l4.ToString();
            maskfraiderecouvrement.Text = View2.l5.ToString();
            masktauxderetard.Text = View2.l6.ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }

        private void InformationFacture_Load(object sender, EventArgs e)
        {
            
        }

        private void InformationFacture_Load_1(object sender, EventArgs e)
        {

            maskNumero.Text = "001";
            masknumerotva.Text = "10";
            masktauxderetard.Text = "14";
            txtimmat.Text = "CSE0001";
            maskcode.Text = "01";
            maskfraiderecouvrement.Text = "1000";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (maskfraiderecouvrement.Text == "" || maskNumero.Text == "" || maskcode.Text == "" || masknumerotva.Text == "" || masktauxderetard.Text == "" || txtimmat.Text == "")
            {
                MessageBox.Show(" error!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                correspondance();
                View2 frm2 = new View2();
                frm2.Show();
                exitApp = false;
                this.Close();
            }
        }

        private void label13_Click_1(object sender, EventArgs e)
        {
            if (exitApp)
                Application.Exit();
        }
    }
}
