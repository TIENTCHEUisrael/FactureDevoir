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
    public partial class InforrmationClient : Form
    {
        private bool exitApp = true;
        public static string l1;
        public static string l2;
        public static string l3;
        public static string l4;
        public static bool l5;
        public static string l6;
        public static string l7;
        public static string l8;
        public static string l9;
        public InforrmationClient()
        {
            InitializeComponent();
        }

        private void InforrmationClient_Load(object sender, EventArgs e)
        {
            maskNumero.Mask = "00 00 00 00 0";
            maskNumero.BeepOnError = true;
            txtNom.Text = "Tientcheu";
            txtPrenom.Text = "israel";
            txtEmail.Text = "tientcheuisrael@gmail.com";
            txtjob.Text = "Aucun";
            txtsociete.Text = "SAS";
            maskNumero.Text = "698524956";
            comboville.Text = "Douala";
            comboBox2.Text = "true";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files(*.jpg; *.png; *.jpeg;.*.gif;)| *.jpg; *.png; *.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "" || txtjob.Text == "" || txtNom.Text == "" || txtPrenom.Text == "" || txtsociete.Text == "" || maskNumero.Text == "" || comboville.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                correspondance();
                var form = new InformationFacture();
                form.Show();
                exitApp = false;
                this.Close();
            }
        }
        private void correspondance()
        {
            l1 = txtNom.Text;
            l2 = txtPrenom.Text;
            l3 = txtEmail.Text;
            l4 = maskNumero.Text;
            l5 = bool.Parse(comboBox2.Text);
            l6 = txtjob.Text;
            l7 = txtsociete.Text;
            l8 = comboville.Text;
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

        private void btnvue_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || maskNumero.Text == "" || comboville.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                correspondance();
                View1 frm2 = new View1(pictureBox2.Image);
                frm2.Show();
                exitApp = false;
                this.Close();
            }
        }
    }
}
