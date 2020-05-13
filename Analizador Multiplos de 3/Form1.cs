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
                for(int i=0; i<=tBIngNum.Text.Length;i++)
                {
                    int ascii = (int)tBIngNum.Text[i];
                    if (ascii<48 || ascii>57)
                    {
                        labSalida.Text = "Debe ingresar un numero";
                        return;
                    }    

                }
            }

        }
    }
}
