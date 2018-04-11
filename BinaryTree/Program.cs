using System;

namespace BinaryTree
{
    class Node{
        public int Value {get;set;}
        public Node Left {get;set;}
        public Node Right {get;set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node{Value=2};
            Node left = new Node{Value=1};
            Node right = new Node {Value=3};

            root.Left=left;
            root.Right=right;

            Console.WriteLine("InOrder Traversal");
            InOrderTraversal(root);
            Console.WriteLine("PreOrder Traversal");
            PreOrderTraversal(root);
            Console.WriteLine("PostOrder Traversal");
            PostOrderTraversal(root);
        }

        static void InOrderTraversal(Node root)
        {
            if(root!=null)
            {
                InOrderTraversal(root.Left);
                Console.WriteLine(root.Value);
                InOrderTraversal(root.Right);
            }
        }

        static void PreOrderTraversal(Node root)
        {
            if(root!=null)
            {
                Console.WriteLine(root.Value);
                InOrderTraversal(root.Left);
                InOrderTraversal(root.Right);
            }
        }

        static void PostOrderTraversal(Node root)
        {
            if(root!=null)
            {
                InOrderTraversal(root.Left);
                InOrderTraversal(root.Right);
                Console.WriteLine(root.Value);
            }
        }
    }
}


