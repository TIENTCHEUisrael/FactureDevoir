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
    public partial class View2 : Form
    {
        private bool exitApp = true;
        public static int l1;
        public static string l2;
        public static double l3;
        public static int l4;
        public static int l5;
        public static int l6;
        public View2()
        {
            InitializeComponent();
            Correspondance2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Correspondance1();
            var form = new InformationFacture();
            form.Show();
            exitApp = false;
            this.Close();
        }
        private void Correspondance2()
        {
            label1.Text = InformationFacture.l1.ToString();
            label2.Text = InformationFacture.l2.ToString();
            label3.Text = InformationFacture.l3.ToString();
            label4.Text = InformationFacture.l4.ToString();
            label5.Text = InformationFacture.l5.ToString();
            label6.Text = InformationFacture.l6.ToString();
        }
        private void Correspondance1()
        {
            l1 = int.Parse(label1.Text);
            l2 = label2.Text;
            l3 = double.Parse(label3.Text);
            l4 = int.Parse(label4.Text);
            l5 = int.Parse(label5.Text);
            l6 = int.Parse(label1.Text);
        }

        private void View2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exitApp)
                Application.Exit();
        }
    }
}
