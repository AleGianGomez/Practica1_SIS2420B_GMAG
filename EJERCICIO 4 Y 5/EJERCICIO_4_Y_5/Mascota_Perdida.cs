using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_Y_5
{
    internal class Mascota_Perdida:Mascota
    {
        public String Motivo { get; set; }
        public DateTime Fecha_Perdida { get; set; }
        public override string ToString()
        {
            return $"Motivo de la Perdida: {Motivo} | Fecha de Perdida: {Fecha_Perdida} | Nombre de la Mascota: {Nombre_Mascota} | Edad: {Edad} | Raza: {Raza} | Sexo: {Sexo}";
        }
    }
}
