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
    public partial class FomrSplash : Form
    {
        public FomrSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel2.Width += 3;
            if (panel2.Width >= 700)
            {
                timer1.Start();
                Form f2 = new Log();
                f2.Show();
                this.Close();
            }
        }
    }
}
