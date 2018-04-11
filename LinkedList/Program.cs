using System;

namespace Node {
    class Node {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    class Node2 {
        public int Value { get; set; }
        public Node2 Next { get; set; }
        public Node2 Previous { get; set; }
    }

    class Program {
        static void Main (string[] args) {
            //Single Linked List
            Node first = new Node { Value = 1 };
            Node second = new Node { Value = 2 };
            first.Next = second;
            PrintList (first);

            //Double Linked List
            Node2 first2 = new Node2 { Value = 1 };
            Node2 second2 = new Node2 { Value = 2 };
            first2.Next = second2;
            second2.Previous = first2;
            PrintList (first);
        }
        
        static void PrintList (Node node) {
            while (node != null) {
                Console.WriteLine (node.Value);
                node = node.Next;
            }
        }
    }
}