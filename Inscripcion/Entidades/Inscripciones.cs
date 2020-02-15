using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inscripcion.Entidades
{
    public class Inscripciones
    {
            [Key]
            public int InscripcionId { get; set; }
            public DateTime Fecha { get; set; }
            public int PersonaId { get; set; }
            public int Monto { get; set; }
            public int Balance { get; set; }

            public Inscripciones()
            {
                InscripcionId = 0;
                Fecha = DateTime.Now;
                PersonaId = 0;
                Monto = 0;
                Balance = 0;
            }
    }
}
