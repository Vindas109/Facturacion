using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Facturación
{
    public partial class F_login : Form


    {
        public F_login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAcUs_Click(object sender, EventArgs e)
        {
           /*SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLExpress;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False ; database=facturacion ; integrated security = true");
            conexion.Open();*/

            String caja = this.TBXCUS.Text;
            String usuario = this.textBox1.Text;


            if (caja.Equals("123") && usuario.Equals("12"))
            {
                F_login Form = new F_login();
                this.Hide();

                F_Admin Form12 = new F_Admin();
                Form12.Show();



            }
            else
            {
                if (caja.Equals("124") && usuario.Equals("123"))
                {
                    F_login Form = new F_login();
                    this.Hide();

                    F_IDCliente Form4 = new F_IDCliente();
                    Form4.Show();

                }
                else
                {
                    if (caja.Equals("") || usuario.Equals(""))
                    {
                        MessageBox.Show("Error al digitar");
                    }
                }

            }



        }


        private void TBXCUS_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}