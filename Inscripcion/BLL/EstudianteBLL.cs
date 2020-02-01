using Inscripcion.DAL;
using Inscripcion.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace Inscripcion.BLL
{
    public class EstudianteBLL
    {
        public static bool Guardar(Estudiante Estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Estudiantes.Add(Estudiantes) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Estudiante Estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(Estudiantes).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Estudiantes.Find(Id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Estudiante Buscar(int Id)
        {
            Contexto db = new Contexto();
            Estudiante Estudiantes = new Estudiante();

            try
            {
                Estudiantes = db.Estudiantes.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Estudiantes;
        }

        public static List<Estudiante> GetList(Expression<Func<Estudiante, bool>> Estudiantes)
        {
            List<Estudiante> Lista = new List<Estudiante>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Estudiantes.Where(Estudiantes).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Lista;
        }
    }
}
