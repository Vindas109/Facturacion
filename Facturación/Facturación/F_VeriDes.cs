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
    public partial class F_VeriDes : Form
    {
        public F_VeriDes( int Monto_Pagar)
        {
            InitializeComponent();
            this.Monto_Pagar = Monto_Pagar; 

        }
        int Monto_Pagar;
       
        private void button1_Click(object sender, EventArgs e)
        {
            string cod_correcto = "123";
            string cod = this.textBox1.Text;

            if (cod == cod_correcto)
            {
                F_Desc Form4 = new F_Desc(Monto_Pagar);
                Form4.Show();
                this.Hide();
            }
            else if (cod != cod_correcto)
            {
                MessageBox.Show("Código incorrecto");
            }

        }
    }
}
