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
    public partial class F_Veri : Form
    {
        public F_Veri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Veri Form = new F_Veri();
            this.Hide();

            F_IDCliente Form4 = new F_IDCliente();
            Form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             F_Veri Form = new F_Veri();
            this.Hide();

            F_Ventas Form4 = new F_Ventas();
            Form4.Show();
        }
    }
}
