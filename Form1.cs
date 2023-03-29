using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculadora : Form
    {
       
       double resultado;
       double num1, num2;
       String borrar;
        //String num1, num2;
        int opcion;

        public Calculadora()
        {
            InitializeComponent();
        }
        // Asignacion de numeros del 0 al 10
        //------------------------------------------------------------------
       
        private void b1_Click(object sender, EventArgs e)
        {   if(Caja_texto.Text=="0")
            Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text == "0")
                Caja_texto.Text = "";
            Caja_texto.Text = Caja_texto.Text + Convert.ToString(9);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text=="0")
            {
                return;
            }
            else
            {
                Caja_texto.Text = Caja_texto.Text + Convert.ToString(0);
            }
        }

        //validacion del punto
        //--------------------------------------------------------------------------

        private void b_punto_Click(object sender, EventArgs e)
        {
            if (this.Caja_texto.Text.Contains(".")== false)
            {
                this.Caja_texto.Text =this.Caja_texto.Text + ".";
            }
        }
        //--------------boton de suma-----------------------------------------------

        private void b_suma_Click(object sender, EventArgs e)
        {
            Save_num1("+");
            opcion = 1;
        }

        //--------------boton de resta-----------------------------------------------
        private void b_resta_Click(object sender, EventArgs e)
        {
            Save_num1("-");
            opcion = 2;
        }

        //--------------boton de multiplicasion-----------------------------------------------
        private void b_multiplicacion_Click(object sender, EventArgs e)
        {
            Save_num1("x");
            opcion = 3;
        }

        //--------------boton de divicion----------------------------------------------
        private void b_divicion_Click(object sender, EventArgs e)
        {
            Save_num1("/");
            opcion = 4;
        }

        //--------------boton de raiz cuadrada-----------------------------------------------
        private void b_raiz_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Caja_texto.Text);
            resultado = Math.Sqrt(num1);
            Caja_texto.Text = resultado.ToString();

        }

        //--------------boton de reciproco--------------------------------------------------
        private void b_reciproco_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Caja_texto.Text);
            resultado = 1 / num1;
            if (num1 <= 0)
            {
                MessageBox.Show("Error, no es posible la division");
            }
            else
            {
                Caja_texto.Text = resultado.ToString();
            }
        }

        //--------------boton de borara dato por dato-----------------------------------------------
        private void b_borrar_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrar = Caja_texto.Text;
            x = borrar.Length - 1;
            borrar = borrar.Substring(0, x);
            Caja_texto.Text = borrar;

            if (Caja_texto.Text == "")
            {
                Caja_texto.Text = "0";
            }
        }

        //--------------boton de limpiar la pantalla----------------------------------------------
        private void b_limpiar_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = "";
            Caja_texto.Text = "0";
        } 


        //--------------label de la calculadora-----------------------------------------------
        private void Save_num1(string operador)
        {
            //num1 = Caja_texto.Text;
            num1 = double.Parse(Caja_texto.Text);
            op.Text = Caja_texto.Text + operador;
            Caja_texto.Text = "";

        }

        //--------------boton de igual y contiene las posible operaciones a ejecutarse se el eventos que se active------
        private void b_igual_Click(object sender, EventArgs e)
        {
            //num2 = Caja_texto.Text;
            num2 = double.Parse(Caja_texto.Text);
            Caja_texto.Text = "";
            op.Text = "";
            switch (opcion)
            {
                case 1:
                    //operacion de suma
                    resultado = num1 + num2;
                  
                    break;
                case 2:
                  //operacion de resta
                    resultado = num1 - num2; 
                   break;
                case 3:
                    //operacion de multiplicacion
                   resultado = num1 * num2;
                    break;
                case 4:
                    //operacion de de divicion
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                            
                    }
                    break;
            }
            Caja_texto.Text = Convert.ToString(resultado);
        }

        //--------------boton de sobre acerca de la aplicacion-------------------------------------------
        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: Javier Juarez Carrera en la Universidad de la Cañada", "Arcrca de...");
        }

        //----------------------Parte de edicion------------------------------------------------------------

        //----------------------boton de copiar-------------------------------------------------------------
        private void copiar_Click(object sender, EventArgs e)
        {
            Caja_texto.Copy();
        }

        //----------------------boton de pegar-------------------------------------------------------------
        private void pegar_Click(object sender, EventArgs e)
        {
            Caja_texto.Paste();
        }

        //----------------------boton de cortar-------------------------------------------------------------
        private void cortar_Click(object sender, EventArgs e)
        {
            Caja_texto.Cut();
        }

        //----------------------boton de salir-------------------------------------------------------------
        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
