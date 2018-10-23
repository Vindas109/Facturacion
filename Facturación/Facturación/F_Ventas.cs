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
    public partial class F_Ventas : Form
    {


        public F_Ventas()
        {
            InitializeComponent();
        }

        int Monto_Pagar = 0;
        int contador1;
        int contador2;
        int contador3;
        int contador4;
        int contador5;
        int contador6;
        int contador7;
        int contador8;
        int contador9;
        int contador10;





        private void button7_Click(object sender, EventArgs e)
        {
            F_Ventas Form = new F_Ventas();
            this.Hide();

            F_Pago Form4 = new F_Pago(Monto_Pagar);
            Form4.Show();

        }


       /* ---------------------------------------------------------------------------------------------------------------- */


        private void button1_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 1250;
            contador1++;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Monto_Pagar += 3000;
            contador2++;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 1350;
            contador3++;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 2250;
            contador4++;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 1550;
            contador5++;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 3250;
            contador6++;
        }

      /*  ----------------------------------------------------------------------------------------------------------------------------------*/


        private void button9_Click(object sender, EventArgs e)
        {
            if (contador1 != 0)
            {
                textBox1.Clear();
                string aux = textBox1.Text;
                textBox1.Text = aux + contador1 + " Combo 1 \r\n ";
            }
            if (contador2 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador2 + " Combo 2 \r\n ";
            }
            if (contador3 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador3 + " Combo 3 \r\n ";
            }
            if (contador4 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador4 + " Combo 4 \r\n ";
            }
            if (contador5 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador5 + " Combo 5 \r\n ";
            }
            if (contador6 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador6 + " Combo 6 \r\n ";
            }
            if (contador7 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador7 + " Papas \r\n ";
            }
            if (contador8 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador8 + " Frescos \r\n ";
            }
            if (contador9 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador9 + " Muslo \r\n ";
            }
            if (contador10 >= 1)
            {
                string aux = textBox1.Text;
                textBox1.Text = aux + contador10 + " Pechuga \r\n ";
            }





        }

        private void button10_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 1000;
            contador7++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 1000;
            contador8++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 1000;
            contador9++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Monto_Pagar += 1000;
            contador10++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            F_Ventas Form = new F_Ventas();
            this.Hide();

            VeriModText1 Form2 = new VeriModText1();
            Form2.Show();

        }

       
    }
}
