using Heap;
using System;
using Xunit;

namespace HeapTest
{
    public class HeapTest
    {
        [Fact]
        public void HeapfyTest()
        {
            int[] arreglo = { 2, 5, 6, 4, 20, 12 };
            Program.Heapify(arreglo);
            Assert.Equal(20, arreglo[0]);
        }
	}
}
