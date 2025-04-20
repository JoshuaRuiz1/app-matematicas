using Microsoft.VisualStudio.TestTools.UnitTesting;
using Act3;

namespace OperacionesTests
{
    [TestClass]
    public class OperacionesUnitTest
    {
        [TestMethod]
        public void TestSuma()
        {
            int resultado = Operaciones.Sumar(3, 4);
            Assert.AreEqual(7, resultado);
        }

        [TestMethod]
        public void TestResta()
        {
            int resultado = Operaciones.Restar(10, 4);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            int resultado = Operaciones.Multiplicar(3, 5);
            Assert.AreEqual(15, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            int resultado = Operaciones.Dividir(10, 2);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionPorCero()
        {
            Operaciones.Dividir(10, 0);
        }
    }
}

