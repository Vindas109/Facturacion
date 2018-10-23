using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturación
{
    public partial class F_Admin : Form
    {
        public F_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Admin Form = new F_Admin();
            this.Hide();

            F_Mante Form2 = new F_Mante();
            Form2.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Admin Form = new F_Admin();
            this.Hide();

            F_IDCliente Form4 = new F_IDCliente();
            Form4.Show();
        }
    }
}
