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
    public partial class F_Pago : Form
    {
        public F_Pago(int Monto_Pagar)
        {
            InitializeComponent();
            this.Monto_Pagar = Monto_Pagar;

            Lbl_Monto.Text = Convert.ToString(Monto_Pagar); 
            
        }
        int Monto_Pagar;


        private void btn_descuento_Click(object sender, EventArgs e)
        {
            string cod_correcto = "123";
            string cod = this.btn_descuento.Text;


            if (btn_descuento.Equals("") || btn_descuento.Equals(""))
            {
                MessageBox.Show("Error al digitar");
            }


            F_VeriDes Form4 = new F_VeriDes(Monto_Pagar);
            Form4.Show();
            this.Hide();

            
        }

        private void Cobrar_Click(object sender, EventArgs e)
        {
            string aux = textBox1.Text; 
            int dinero = Convert.ToInt32(aux);
            int Resultado = dinero - Monto_Pagar;
            string imprimir = Convert.ToString(Resultado);
            Cambio.Text = imprimir;
        }

       
    }
    }

