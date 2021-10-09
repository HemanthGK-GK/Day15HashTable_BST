using System;

namespace UC2BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(30);
            binaryTree.Add(70);
            binaryTree.Add(22);
            binaryTree.Add(40);
            binaryTree.Add(60);
            binaryTree.Add(95);
            binaryTree.Add(11);
            binaryTree.Add(65);
            binaryTree.Add(3);
            binaryTree.Add(16);
            binaryTree.Add(63);
            binaryTree.Add(67);

            binaryTree.TravarseInorder(binaryTree.Root);
        }

    }
}
