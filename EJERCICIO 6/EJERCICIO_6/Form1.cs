using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Operaciones.Items.Add("Numeros Primos");
            comboBox_Operaciones.Items.Add("Numeros Perfectos");
            comboBox_Operaciones.Items.Add("Serie Fibonacci");
        }
        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            listBox_Numeros.Items.Clear();
            int Numero = Convert.ToInt32(Txt_Numero.Text);
            string Seleccionador = comboBox_Operaciones.Text;
            if(Seleccionador == "Numeros Primos")
            {
                for(int i = 2; i <= Numero; i++)
                {
                    int control = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if(i%j== 0)
                        {
                            control = 1;
                            break;
                        }
                    }
                    if (control == 0)
                    {
                        listBox_Numeros.Items.Add(i);
                    }
                }
            }
            if(Seleccionador == "Numeros Perfectos")
            {
                for (int i = 1; i <= Numero; i++)
                {
                    int Sum = 0;
                    for(int j = 1; j <= i/2;j++)
                    {
                        if(i % j == 0)
                        {
                            Sum += j;
                        }
                    }
                    if (Sum == i)
                    {
                        listBox_Numeros.Items.Add(i);
                    }
                }
            }
            if (Seleccionador == "Serie Fibonacci")
            {
                int a = 0, b = 1, c = 0;
                listBox_Numeros.Items.Add(a);
                listBox_Numeros.Items.Add(b);
                for (int i = 3; a+b < Numero; i++)
                {
                    c = a + b;
                    listBox_Numeros.Items.Add(c);
                    a = b;
                    b = c;
                
                }
            }
        }
    }
}
//GOMEZ MAGNE ALEJANDRO GIANFRANCO
//SIS 2420 "B"
