using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inscripcion.Entidades
{
    public class Estudiante
    {
        [Key]
        public int PersonaId { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Cedula { get; set; }
        public String Direccion { get; set; }
        public String FechaNacimiento { get; set; }
        public int Balance { get; set; }
    }

    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public int PersonaId { get; set; }
        public int Monto { get; set; }
        public int Balence { get; set; }

    }
}
