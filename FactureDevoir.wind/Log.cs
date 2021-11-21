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
    public partial class Log : Form
    {
        private bool exitApp = true;
        public Log()
        {
            InitializeComponent();
            txtEmail.Text = "admin@gmail.com";
            txtpassword.Text = "administrator";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin@gmail.com" && txtpassword.Text == "administrator")
            {
                MessageBox.Show("Welcome", "wel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var form = new InforrmationClient();
                form.Show();
                exitApp = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Champ pas valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Log_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exitApp)
                Application.Exit();
        }
    }
}
