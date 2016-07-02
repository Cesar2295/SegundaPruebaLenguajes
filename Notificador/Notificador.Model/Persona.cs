using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificador.Model
{
    public class Persona
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        public string CorreoElectronico { get; set; }
    }
}
