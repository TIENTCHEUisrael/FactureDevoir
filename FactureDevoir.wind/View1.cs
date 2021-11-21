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

    public partial class View1 : Form
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
        public View1(Image pic1)
        {
            InitializeComponent();
            pictureBox1.Image = pic1;
            Correspondance2();
        }
        private void Correspondance2()
        {
            label1.Text = InforrmationClient.l1;
            label2.Text = InforrmationClient.l2;
            label3.Text = InforrmationClient.l3;
            label4.Text = InforrmationClient.l4.ToString();
            label5.Text = InforrmationClient.l5.ToString();
            label6.Text = InforrmationClient.l6;
            label7.Text = InforrmationClient.l7;
            label8.Text = InforrmationClient.l8;
        }
        private void Correspondance1()
        {
            l1 = label1.Text;
            l2 = label2.Text;
            l3 = label3.Text;
            l4 = label4.Text;
            l5 = bool.Parse(label5.Text);
            l6 = label1.Text;
            l7 = label7.Text;
            l8 = label8.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Correspondance1();
            var form = new InforrmationClient();
            form.Show();
            exitApp = false;
            this.Close();
        }

        private void View1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exitApp)
                Application.Exit();
        }
    }
}
