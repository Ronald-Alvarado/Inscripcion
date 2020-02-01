using Inscripcion.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inscripcion.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public object Estudiante { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-RLIPRAX\SQLEXPRESS; Database = Inscripcion; trusted_Connection = true");
            
        }
    }
}
