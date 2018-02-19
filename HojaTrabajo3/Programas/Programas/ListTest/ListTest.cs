using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programas;

namespace ListTest
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Test1()
        {
            IList<int> lista = new ArrayList<int>(new int[] { 10, 30 });
            lista.Push(50);
            Assert.AreEqual(lista.Length, 3);
            int last;
            lista.Get(lista.Length - 1, out last);
            Assert.AreEqual(last, 50);
        }

        [TestMethod]
        public void Test2()
        {
            IList<int> lista = new ArrayList<int>(new int[] { 10, 30 });
            Assert.AreEqual(lista.Get(30, out int obj), false);
        }

        [TestMethod]
        public void Test3()
        {
            IList<int> lista = new ArrayList<int>(new int[] { 10, 30 });
            lista.Set(1, 50);
            int obj;
            lista.Get(1, out obj);
            Assert.AreEqual(obj, 50);
        }
    }
}
