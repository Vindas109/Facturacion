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
    public partial class F_Caja : Form
    {
       
        public F_Caja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String caja = this.textBox2.Text;
            String num = this.textBox3.Text;
            if (num.Equals("")||caja.Equals(""))
            {
                MessageBox.Show("Error al digitar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Caja Form = new F_Caja();
            this.Hide();

            F_Mante Form5 = new F_Mante();
            Form5.Show();
        }
    }
}
