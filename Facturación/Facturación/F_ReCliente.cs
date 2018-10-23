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
    public partial class F_ReCliente : Form
    {
        public F_ReCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_ReCliente Form = new F_ReCliente();
            this.Hide();

            F_IDCliente Form4 = new F_IDCliente();
            Form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String IDCliente = this.textBox1.Text;
            String Nombre = this.textBox2.Text;
            String Numero = this.textBox3.Text;
            String Correo = this.textBox4.Text; 

        if (IDCliente.Equals("")||Nombre.Equals("")||Numero.Equals("")|| Correo.Equals(""))
            {
                MessageBox.Show("Error al digitar");
            }

            F_ReCliente Form = new F_ReCliente();
            this.Hide();

            F_Veri Form4 = new F_Veri();
            Form4.Show();
        }
    }
}
