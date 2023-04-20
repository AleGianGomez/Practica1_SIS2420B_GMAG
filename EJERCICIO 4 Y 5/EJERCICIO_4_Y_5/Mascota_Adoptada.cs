using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_Y_5
{
    internal class Mascota_Adoptada : Mascota
    {
        public String Nombre_Dueño { get; set; }
        public decimal Pago_Mascota { get; set; }
        public DateTime Fecha_Adopcion { get; set; }
        public override string ToString()
        {
            return $"Nombre del Dueño: {Nombre_Dueño} | Pago: {Pago_Mascota} | Nombre de la Mascota: {Nombre_Mascota} | Edad: {Edad} | Raza: {Raza} | Sexo: {Sexo}";
        }
    }
}
