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
    public partial class F_IDCliente : Form
    {
        public F_IDCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_IDCliente Form = new F_IDCliente();
            this.Hide();

            F_Veri Form4 = new F_Veri();
            Form4.Show();

            String ID = this.textBox1.Text; 

            if (ID.Equals(""))
            {
                MessageBox.Show("Error al digitar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_IDCliente Form = new F_IDCliente();
            this.Hide();

            F_ReCliente Form4 = new F_ReCliente();
            Form4.Show();
        }

        private void F_IDCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
