using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inscripcion.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int PersonaId { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Cedula { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Balance { get; set; }


        public Estudiantes()
        {
            PersonaId = 0;
            Nombre = String.Empty;
            Apellido = String.Empty;
            Telefono = String.Empty;
            Cedula = String.Empty;
            Direccion = String.Empty;
            FechaNacimiento = DateTime.Now;
            Balance = 0;
        }
    }
}
