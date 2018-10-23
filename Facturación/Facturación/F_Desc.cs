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
    public partial class F_Desc : Form
    {
        public F_Desc(int Monto_Pagar)
        {
            InitializeComponent();
            this.Monto_Pagar = Monto_Pagar; 
        }

        int resultado; 
         int Monto_Pagar; 

        private void button1_Click(object sender, EventArgs e)
        {

            String auxi = textBox1.Text;
            int descuento = Convert.ToInt32(auxi); 
            resultado = Monto_Pagar - ((descuento * Monto_Pagar) / 100);
            F_Pago Form4 = new F_Pago(resultado);
            Form4.Show();
            this.Hide(); 

        }
    }
}
