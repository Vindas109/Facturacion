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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String codigo = this.TxBCodigo.Text;
            String cantidad = this.TxBCantidad.Text;
            String precio = this.TxBPrecio.Text;
            String descripcion = this.TxBDescripcion.Text;
            String nombre = this.TxBNombre.Text;


            if (codigo.Equals("")|| cantidad.Equals("")|| precio.Equals("")||descripcion.Equals("")||nombre.Equals(""))
            {
                MessageBox.Show("Error al digitar");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 Form = new Form10();
            this.Hide();

            F_Mante Form5 = new F_Mante();
            Form5.Show();
        }
    }
    }

