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
    public partial class VeriModText1 : Form
    {
        public VeriModText1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_correcto = "123";
            string cod = this.textBox1.Text;

            if (cod == cod_correcto)
            {
                VeriModText1 Form = new VeriModText1();
                this.Hide();

                F_Ventas Form2 = new F_Ventas();
                Form2.Show();
                this.textBox1.Enabled = true;

            }
            else if (cod != cod_correcto)
            {
                MessageBox.Show("Código incorrecto");
            }
        }
    }
}
