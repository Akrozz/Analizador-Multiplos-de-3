using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizador_Multiplos_de_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if(tBIngNum.Text == "")
            {
                labSalida.Text = "Debe ingresar un numero";
                return;
            }
            else
            {
                int aux;

                for(int i=0; i<tBIngNum.Text.Length;i++)
                {
                    aux = tBIngNum.Text.Length;
                    
                    int ascii = (int)tBIngNum.Text[i];
                    if (ascii<48 || ascii>57)
                    {
                        labSalida.Text = "Debe ingresar solo\n números enteros";
                        return;
                    }


                }
                int dec = int.Parse(tBIngNum.Text);
                string binario = enteroBinario(dec);
                bool aceptacion = Automata(binario);
                if (aceptacion)
                    labSalida.Text = "Es multiplo de 3";
                else
                    labSalida.Text = "No es multiplo de 3";
            }

        }
        private string enteroBinario(int a)
        {
            string resto = "";
            string binario = "";

            while ((a >= 2))
            {
                resto = resto + (a % 2).ToString();
                a = a / 2;
            }
            resto = resto + a.ToString();

            for (int i = resto.Length; i >= 1; i += -1)
            {
                binario = binario + resto.Substring(i - 1, 1);
            }

            return binario;

        }
        private bool Automata(string entrada)
        {
            int estado = 2;
            bool ultima = false;
            for (int i=0; i<entrada.Length;i++)
            {

                char aux = entrada[i];
                if (i == entrada.Length-1)
                    ultima = true;


                switch (estado)
                {
                    case 0:
                        {

                            if (aux == '0')
                            {
                                estado = 0;
                            }

                            else
                                estado = 3;


                          }
                                break;
                       
                    case 1:
                        {

                            if (aux == '0')
                            {
                                estado = 3;
                            }

                            else
                                estado = 1;

                          }

                        break;

                    case 2:
                        {


                            if (aux == '0')
                            {
                                estado = 0;
                            }

                            else
                                estado = 3;

                          }

                        break;

                    case 3:
                        {

                            if (aux == '0')
                            {
                                estado = 1;

                            }

                            else
                                estado = 0;

                          }

                        break;
                    default:
                        return false;
                }
                if (ultima && estado == 0)
                    return true;
            }
            return false;

        }

       
    }
}
