using System;
using System.Collections.Generic;
using System.Text;

namespace UC3BinarySearchValue
{

    class BinaryTree
    {

        public Node Root { get; set; }
        bool result = false;
        public bool Add(int value)
        {
            Node before = null, after = this.Root;
           

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        public bool Search(int value, Node node)
        {
            
            if (node == null)
                return false;

            if(node.Data==value)
            {
                Console.WriteLine(" Element is Found in BST : "+ node.Data);
                result = true;
            }
            else
                Console.WriteLine("element {0} is not found BST", node.Data);

            if (value.CompareTo(node.Data) < 0)
                Search(value, node.LeftNode);

            if (value.CompareTo(node.Data) > 0)
                Search(value, node.RightNode);

            return result;
        }

            public void TravarseInorder(Node Parent)
        {
            if (Parent != null)
            {
                TravarseInorder(Parent.LeftNode);
                Console.Write(Parent.Data + " ");
                TravarseInorder(Parent.RightNode);

            }

        }
    }

}