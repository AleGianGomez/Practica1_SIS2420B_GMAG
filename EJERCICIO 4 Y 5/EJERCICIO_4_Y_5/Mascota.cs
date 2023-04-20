using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_Y_5
{
    internal class Mascota
    {
        public String Nombre_Mascota { get; set; }
        public int Edad { get; set; }
        public String Raza { get; set; }
        public String Sexo { get; set; }
        public override string ToString()
        {
            return $"Nombre: {Nombre_Mascota} | Edad: {Edad} | Raza: {Raza} | Sexo: {Sexo}";
        }
    }
}
