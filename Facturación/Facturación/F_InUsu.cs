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
    public partial class F_InUsu : Form
    {
        public F_InUsu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigo = this.textBox1.Text;
            String nombre = this.textBox2.Text;
            String tipo = this.textBox3.Text;
            String domicilio = this.textBox4.Text;
            String correo = this.textBox5.Text;
            String telefono = this.textBox6.Text;
            String cedula = this.textBox7.Text;
            String codigo_permiso = this.textBox8.Text;

            if (codigo.Equals("")|| nombre.Equals("")|| tipo.Equals("")||domicilio.Equals("")|| correo.Equals("")|| telefono.Equals("")|| cedula.Equals("")||codigo_permiso.Equals(""))
            {
                MessageBox.Show("Error al digitar"); 

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_InUsu Form = new F_InUsu();
            this.Hide();

            F_Mante Form5 = new F_Mante();
            Form5.Show();
        }
    }
}
