using System;
using Xunit;

namespace BinTreeTests
{
    public class BinTreeTests
    {
        [Fact]
        public void TestSuma()
        {
            IBinTree sut = new BinaryTree(
                5,
                new BinaryTree(4),
                new BinaryTree(
                    9,
                    new BinaryTree(8),
                    null
                )
            );

            Assert.Equal(26, sut.Sumar());
        }

        [Fact]
        public void TestInsert()
        {
            IBinTree sut = new BinaryTree(8);
            sut.Insert(10);
            sut.Insert(15);
            sut.Insert(26);
            sut.Insert(3);
            sut.Insert(11);
            sut.Insert(99);
            sut.Insert(7);

            int[] result = sut.ToArray();

            for (int i = 0; i < result.Length - 1; i++)
            {
                Assert.True(result[i] <= result[i + 1]);
            }
        }
    }
}
