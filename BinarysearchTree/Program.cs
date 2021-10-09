using System;

namespace BinarysearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(56);
            binaryTree.Add(30);
            binaryTree.Add(70);
            

            binaryTree.TravarsePreorder(binaryTree.Root);
        }
    }
}
