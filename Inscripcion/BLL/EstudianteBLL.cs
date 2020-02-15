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
        public static bool Guardar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Estudiantes.Add(estudiantes) != null)
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

        public static bool Modificar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(estudiantes).State = EntityState.Modified;
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

        public static Estudiantes Buscar(int Id)
        {
            Contexto db = new Contexto();
            Estudiantes estudiantes = new Estudiantes();

            try
            {
                estudiantes = db.Estudiantes.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiantes;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> Estudiantes)
        {
            List<Estudiantes> Lista = new List<Estudiantes>();
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
