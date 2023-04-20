using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE UN NUMERO: ");
            int Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SERIE 1: ");
            PrimeraSerie(Numero);
            Console.WriteLine();
            Console.WriteLine("SERIE 2: ");
            SegundaSerie(Numero);
            Console.ReadKey();
        }

        private static void SegundaSerie(int Numero)
        {
            for (int i = 1; i <= Numero + 1; i++)
            {
                int Pnum = (int)Math.Pow(2, i);
                Console.Write(Pnum + " ");
            }
        }

        private static void PrimeraSerie(int Numero)
        {
            int Pnum = 1;
            for (int i = 1; i <= Numero; i++)
            {
                Pnum = Pnum * i;
                Console.Write(Pnum + " ");
            }
        }
    }
}
//GOMEZ MAGNE ALEJANDRO GIANFRANCO
//SIS 2420 "B"
