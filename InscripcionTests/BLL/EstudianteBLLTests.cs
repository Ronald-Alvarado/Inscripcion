using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inscripcion.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Inscripcion.Entidades;

namespace Inscripcion.BLL.Tests
{
    [TestClass()]
    public class EstudianteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Estudiantes estudiantes = new Estudiantes();
            Inscripciones inscripciones = new Inscripciones();

            public int Monto = estudiantes.Balance;

            //    EstudianteBLL.Guardar(estudiantes);

            public int MontoNuevo = estudiantes.Balance + Inscripcion.Monto;

            Assert.isnotequal(Monto,MontoNuevo);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.IsNotEquals();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}