using System;

namespace BinTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IBinTree bTree = new BinaryTree(
                5,
                new BinaryTree(4),
                new BinaryTree(
                    9,
                    new BinaryTree(8),
                    null
                )
            );

            Console.WriteLine(bTree);
            Console.WriteLine(bTree.Sumar());
        }
    }
}
