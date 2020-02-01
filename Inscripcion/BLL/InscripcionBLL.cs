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
    public class InscripcionBLL
    {
        public static bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Inscripciones.Add(inscripciones) != null)
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

        public static bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(inscripciones).State = EntityState.Modified;
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
                var eliminar = db.Inscripciones.Find(Id);
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

        public static Inscripciones Buscar(int Id)
        {
            Contexto db = new Contexto();
            Inscripciones inscripciones = new Inscripciones();

            try
            {
                inscripciones = db.Inscripciones.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return inscripciones;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> inscripcion)
        {
            List<Inscripciones> Lista = new List<Inscripciones>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Inscripciones.Where(inscripcion).ToList();
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
