using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Genericos;

namespace GenericosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHead()
        {
            int[] valores = new int[] { 4, 6, 7, 3, 9 };
            Assert.AreEqual(Genericos.Genericos.Head(valores), valores[0]);
        }

        [TestMethod]
        public void TestTail()
        {
            int[] valores = new int[] { 4, 6, 7, 3, 9 };

            int[] respuesta = Genericos.Genericos.Tail(valores);
            Assert.AreEqual(respuesta.Length, valores.Length - 1);
            Assert.AreEqual(respuesta[0], valores[1]);
        }

        [TestMethod]
        public void TestZip()
        {
            int[] valores1 = new int[] { 4, 6, 7, 3, 9 };
            string[] valores2 = new string[] { "hola", "como", "estas" };

            Tupla<int, string>[] respuesta = Genericos.Genericos.Zip(valores1, valores2);

            Assert.AreEqual(respuesta.Length, valores2.Length);

            for (int i = 0; i < respuesta.Length; i++)
            {
                Assert.AreEqual(respuesta[i].Primero, valores1[i]);
                Assert.AreEqual(respuesta[i].Segundo, valores2[i]);
            }
        }
    }
}
