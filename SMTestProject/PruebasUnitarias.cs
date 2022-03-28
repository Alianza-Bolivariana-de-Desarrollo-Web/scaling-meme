using Microsoft.VisualStudio.TestTools.UnitTesting;
using clui.scaling_meme;
using System;

namespace SMTestProject
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void SCFuncionesValidar_01()
        {
            string fechaEntrada = "01/01/2022";
            bool estadoRetorno = SCFunciones.ValidarFecha(fechaEntrada, "es");
            Assert.IsTrue(estadoRetorno);
        }
        [TestMethod]
        public void SCFuncionesValidar_02()
        {
            string fechaEntrada = "01-01/2022";
            bool estadoRetorno = SCFunciones.ValidarFecha(fechaEntrada, "es");
            Assert.IsFalse(estadoRetorno);
        }
        [TestMethod]
        public void SCFuncionesValidar_03()
        {
            string fechaEntrada = "01/01/2022";
            bool estadoRetorno = SCFunciones.ValidarFecha(fechaEntrada, "en");
            Assert.IsFalse(estadoRetorno);
        }
        [TestMethod]
        public void SCFuncionesDiferenciaFechaACDC_04()
        {
            DateTime fechaAC = new DateTime(1000, 01, 01);
            DateTime fechaDC = new DateTime(1000, 01, 01);
            int[] diferencia = SCFunciones.DiferenciaFechaAC(fechaAC, fechaDC);
            int resultadoEsperado = 2000;
            int resultadoObtenido = diferencia[0];
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
        [TestMethod]
        public void NDFunciones_01()
        {
            string fechaEntrada = "a";
            bool estadoRetorno = SCFunciones.ValidarFecha(fechaEntrada, "en");
            Assert.IsFalse(estadoRetorno);
        }
    }
}
