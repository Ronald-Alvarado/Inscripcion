using Inscripcion.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inscripcion.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-RLIPRAX\SQLEXPRESS; DataBase = InscripcionDb; Trusted_Connection = true");            
        }
    }
}
