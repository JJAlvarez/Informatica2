using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reduce;
using System.Linq;

namespace ReduceTest
{
    [TestClass]
    public class ReduceTest
    {
        [TestMethod]
        public void ReduceIntTest()
        {
            //Suma de los valores de un arreglo
            int[] valores = new int[] { 4, 6, 7 };
            int reduce = Program.ReduceInt(valores, 0, (acc, valor) => acc + valor);

            Assert.AreEqual(reduce, 17);
        }

        [TestMethod]
        public void ReduceGenericTest()
        {
            //Suma la cantidad de veces que aparece la letra a en los elementos del arreglo
            string[] valores = new string[] { "hola", "amigo", "saludos a ta" };
            int reduce = Program.Reduce(valores, 0, (acc, valor) => acc + valor.Where(c => c == 'a').Count());

            Assert.AreEqual(reduce, 5);
        }
    }
}
