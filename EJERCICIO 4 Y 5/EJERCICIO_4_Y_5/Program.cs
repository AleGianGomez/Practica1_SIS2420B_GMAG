using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EJERCICIO_4_Y_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mascota_Adoptada> ListaMascotasAdoptadas = new List<Mascota_Adoptada>();
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Wara",
                Pago_Mascota = 350,
                Nombre_Mascota = "Puky",
                Edad = 5,
                Raza = "Bichón Maltés",
                Sexo = "Femenino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Paola",
                Pago_Mascota = 550,
                Nombre_Mascota = "Canela",
                Edad = 3,
                Raza = "Chiwawa",
                Sexo = "Femenino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Alejandro",
                Pago_Mascota = 650,
                Nombre_Mascota = "Toma",
                Edad = 1,
                Raza = "Pastor Aleman",
                Sexo = "Masculino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Mauricio",
                Pago_Mascota = 850,
                Nombre_Mascota = "Oscar",
                Edad = 8,
                Raza = "Pug",
                Sexo = "Masculino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Julia",
                Pago_Mascota = 650,
                Nombre_Mascota = "Layla",
                Edad = 2,
                Raza = "Pekinés",
                Sexo = "Femenino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Lola",
                Pago_Mascota = 550,
                Nombre_Mascota = "Rosita",
                Edad = 1,
                Raza = "Chiwawa",
                Sexo = "Femenino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Jose",
                Pago_Mascota = 250,
                Nombre_Mascota = "Toby",
                Edad = 2,
                Raza = "Husky",
                Sexo = "Masculino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Daniel",
                Pago_Mascota = 300,
                Nombre_Mascota = "Estrella",
                Edad = 7,
                Raza = "Chiwawa",
                Sexo = "Femenino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "David",
                Pago_Mascota = 320,
                Nombre_Mascota = "Hachi",
                Edad = 7,
                Raza = "Golden",
                Sexo = "Femenino"
            });
            ListaMascotasAdoptadas.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "Maria",
                Pago_Mascota = 430,
                Nombre_Mascota = "Zeus",
                Edad = 3,
                Raza = "Golden",
                Sexo = "Masculino"
            });
            MostrarMascota(ListaMascotasAdoptadas);
            Double PromedioEdad = Prom_Mascota(ListaMascotasAdoptadas);
            Console.WriteLine("{0}",PromedioEdad.ToString("##.##"));
            Double PromedioPago = Prom_Pago(ListaMascotasAdoptadas);
            Console.WriteLine("{0}", PromedioPago.ToString("##.##"));
            var Chiwawa = Raza_Chiwawa(ListaMascotasAdoptadas);
            Console.WriteLine("\n---RAZA CHIWAWA Y FEMENINO---\n");
            foreach (Mascota_Adoptada x in Chiwawa)
            {
                Console.WriteLine(x.ToString());
            }
            var EdadMascota = Edad_Mascota(ListaMascotasAdoptadas);
            Console.WriteLine("\n---EDAD MENOR A 2 AÑOS---\n");
            foreach (Mascota_Adoptada x in EdadMascota)
            {
                Console.WriteLine(x.ToString());
            }
            Console.ReadKey();
        }
        ///LINQ para mostrar las mascotas que tienen la edad menor a 2 años
        private static IEnumerable<Mascota_Adoptada> Edad_Mascota(List<Mascota_Adoptada> listaMascotasAdoptadas)
        {
            return (from x in listaMascotasAdoptadas
                    where x.Edad < 2
                    select x);
        }
        ///LINQ para mostrar las mascotas que son de raza Chiwawa y de sexo Femenino
        private static IEnumerable<Mascota_Adoptada> Raza_Chiwawa(List<Mascota_Adoptada> listaMascotasAdoptadas)
        {
            return (from x in listaMascotasAdoptadas
                    where x.Raza == "Chiwawa" && x.Sexo == "Femenino"
                    select x);
        }
        ///LAMBDA para sacar el promedio del pago de las mascotas
        private static double Prom_Pago(List<Mascota_Adoptada> listaMascotasAdoptadas)
        {
            Console.WriteLine("\n---PROMEDIO DEL PAGO DE LAS MASCOTAS---\n");
            decimal promedio = listaMascotasAdoptadas.Average(x => x.Pago_Mascota);
            return (double)promedio;
        }

        ///LAMBDA para sacar el promedio de la edad de las mascotas
        private static double Prom_Mascota(List<Mascota_Adoptada> listaMascotasAdoptadas)
        {
            Console.WriteLine("\n---PROMEDIO EDAD DE LAS MASCOTAS---\n");
            double promedio = listaMascotasAdoptadas.Average(x => x.Edad);
            return promedio;
        }

        private static void MostrarMascota(List<Mascota_Adoptada> listaMascotasAdoptadas)
        {
            Console.WriteLine("---LISTA DE MASCOTAS ADOPTADAS---");
            foreach (Mascota_Adoptada item in listaMascotasAdoptadas)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
//GOMEZ MAGNE ALEJANDRO GIANFRANCO
//SIS 2420 "B"
