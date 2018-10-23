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
    public partial class F_Mante : Form
    {
        public F_Mante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Mante Form = new F_Mante();
            this.Hide();

            F_Admin Form4 = new F_Admin();
            Form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String buscar = this.textBox1.Text; 

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String accion = this.comboBox2.Text;
            String objeto = this.comboBox1.Text; 

            if (accion.Equals(" ") || objeto.Equals(" "))
            {
                MessageBox.Show(" Por favor selecione las opciones que indican lo que desea realizar. ");
            }
            else
            {
                if (accion.Equals("Añadir") && objeto.Equals("Usuario"))
                {
                    F_Mante Form = new F_Mante();
                    this.Hide();

                    F_InUsu Form4 = new F_InUsu();
                    Form4.Show();
                }
                else
                {
                    if (accion.Equals("Añadir") && objeto.Equals("Producto"))
                    {
                        F_Mante Form = new F_Mante();
                        this.Hide();

                        Form10 Form5 = new Form10();
                        Form5.Show();
                    } else
                    {
                        if (accion.Equals("Añadir") && objeto.Equals("Cliente"))
                        {
                            MessageBox.Show("Por favor vaya a Inicio Cliente");
                        }else
                        {
                            if (accion.Equals("Añadir") && objeto.Equals("Caja"))
                            {
                                F_Mante Form = new F_Mante();
                                this.Hide();

                                F_Caja Form5 = new F_Caja();
                                Form5.Show();
                            }
                            else
                            {
                                if (accion.Equals("Añadir") && objeto.Equals("Combo"))
                                {
                                    F_Mante Form = new F_Mante();
                                    this.Hide();

                                    INCombo Form5 = new INCombo();
                                    Form5.Show();
                                }
                                else
                                {
                                    if (accion.Equals("Añadir") && objeto.Equals("Termino Pago"))
                                    {
                                      
                                    }
                                    else
                                    {
                                        if (accion.Equals("Añadir") && objeto.Equals("Tipo Pago"))
                                        {
                                           
                                        }
                                        else
                                        {
                                            //------------------------------------------------------------------------------------------
                                            if (accion.Equals("Eliminar") && objeto.Equals("Usuario"))
                                            {
                                               // string query = "DELETE FROM Usuario WHERE codigo = @Cod_Usuario " ;
                                               // conexion.open();
                                               // SqlCommand comando = new SqlCommand (query,conexion);
                                               // comando.Parameters.AddWhithValue("@Cod_Usuario, TextBox1.Text");
                                               // comando.ExecuteMonQuery();
                                               // conexion.close();
                                               // MessageBox.Show("Usuario eliminado con éxito");
                                            }
                                            else
                                                if (accion.Equals("Eliminar") && objeto.Equals("Producto"))
                                                {
                                                // string query = "DELETE FROM Producto WHERE codigo = @Cod_Pruducto " ;
                                                // conexion.open();
                                                // SqlCommand comando = new SqlCommand (query,conexion);
                                                // comando.Parameters.AddWhithValue("@Cod_Producto, TextBox1.Text");
                                                // comando.ExecuteMonQuery();
                                                // conexion.close();
                                                // MessageBox.Show("Producto eliminado con éxito");
                                            }
                                            else
                                                {
                                                    if (accion.Equals("Eliminar") && objeto.Equals("Cliente"))
                                                    {
                                                    // string query = "DELETE FROM Clientes WHERE codigo = @Cod_Ciente " ;
                                                    // conexion.open();
                                                    // SqlCommand comando = new SqlCommand (query,conexion);
                                                    // comando.Parameters.AddWhithValue("@Cod_Cliente, TextBox1.Text");
                                                    // comando.ExecuteMonQuery();
                                                    // conexion.close();
                                                    // MessageBox.Show("Cliente eliminado con éxito");
                                                }
                                                else
                                                    {
                                                        if (accion.Equals("Eliminar") && objeto.Equals("Caja"))
                                                        {
                                                        // string query = "DELETE FROM Cajas WHERE codigo = @Cod_Caja " ;
                                                        // conexion.open();
                                                        // SqlCommand comando = new SqlCommand (query,conexion);
                                                        // comando.Parameters.AddWhithValue("@Cod_Caja, TextBox1.Text");
                                                        // comando.ExecuteMonQuery();
                                                        // conexion.close();
                                                        // MessageBox.Show("Caja eliminada con éxito");
                                                    }
                                                    else
                                                        {
                                                            if (accion.Equals("Eliminar") && objeto.Equals("Combo"))
                                                            {
                                                            // string query = "DELETE FROM Combo WHERE codigo = @Cod_Combo " ;
                                                            // conexion.open();
                                                            // SqlCommand comando = new SqlCommand (query,conexion);
                                                            // comando.Parameters.AddWhithValue("@Cod_Combo, TextBox1.Text");
                                                            // comando.ExecuteMonQuery();
                                                            // conexion.close();
                                                            // MessageBox.Show("Combo eliminado con éxito");
                                                        }
                                                        else
                                                            {
                                                                if (accion.Equals("Eliminar") && objeto.Equals("Termino Pago"))
                                                                {
                                                                // string query = "DELETE FROM TerminosPago WHERE codigo = @Codigo_Termino " ;
                                                                // conexion.open();
                                                                // SqlCommand comando = new SqlCommand (query,conexion);
                                                                // comando.Parameters.AddWhithValue("@Codigo_Termino, TextBox1.Text");
                                                                // comando.ExecuteMonQuery();
                                                                // conexion.close();
                                                                // MessageBox.Show("Termino de pago eliminado con éxito");
                                                            }
                                                            else
                                                                {
                                                                    if (accion.Equals("Eliminar") && objeto.Equals("Tipo Pago"))
                                                                    {
                                                                    // string query = "DELETE FROM TipoPago WHERE codigo = @Codigo_Tipo " ;
                                                                    // conexion.open();
                                                                    // SqlCommand comando = new SqlCommand (query,conexion);
                                                                    // comando.Parameters.AddWhithValue("@Codigo_Tipo, TextBox1.Text");
                                                                    // comando.ExecuteMonQuery();
                                                                    // conexion.close();
                                                                    // MessageBox.Show("Tipo de pago eliminado con éxito");
                                                                }
                                                                else
                                                                    {
                                                                        //-----------------------------------------------------------------------
                                                                        if (accion.Equals("Modificar") && objeto.Equals("Usuario"))
                                                                        {
                                                                           
                                                                        }
                                                                        else
                                                                        {
                                                                            if (accion.Equals("Modificar") && objeto.Equals("Producto"))
                                                                            {
                                                                               
                                                                            }
                                                                            else
                                                                            {
                                                                                if (accion.Equals("Modificar") && objeto.Equals("Cliente"))
                                                                                {
                                                                                   
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (accion.Equals("Modificar") && objeto.Equals("Caja"))
                                                                                    {
                                                                                       
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (accion.Equals("Modificar") && objeto.Equals("Combo"))
                                                                                        {
                                                                                           
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (accion.Equals("Modificar") && objeto.Equals("Termino Pago"))
                                                                                            {
                                                                                               
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (accion.Equals("Modificar") && objeto.Equals("Tipo Pago"))
                                                                                                {
                                                                                                   
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    MessageBox.Show(" Por favor selecione las opciones que indican lo que desea realizar.");
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }

                    }

                }
            }



        }
    }

