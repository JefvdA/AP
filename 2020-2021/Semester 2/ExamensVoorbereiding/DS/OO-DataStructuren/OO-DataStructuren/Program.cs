using System;
using OO_DataStructuren.SLL;
using OO_DataStructuren.DLL;
using OO_DataStructuren.BST;
using OO_DataStructuren.TreePrinter;

namespace OO_DataStructuren
{
    class Program
    {
        static void Main(string[] args)
        {
            SLLList<int> list = new SLLList<int>();
            SLLNode<int> node = list.AddFirst(5);
            list.AddLast(11);
            list.AddAfter(node, 22);

            Console.WriteLine(list.Length);
            Console.WriteLine(node.ToString());

            DLLList<int> list2 = new DLLList<int>();
            DLLNode<int> node2 = list2.AddFirst(5);
            list2.AddLast(11);
            list2.AddAfter(node2, 22);

            Console.WriteLine(list2.Length);
            Console.WriteLine(node2.ToString());

            Tree<int> tree = new Tree<int>();
            tree.Insert(10);
            tree.Insert(8);
            tree.Insert(25);
            tree.Insert(3);
            tree.Insert(9);
            tree.Insert(22);
            tree.Insert(27);
            BinaryTreePrinter.Print(tree.Root);
        }
    }
}
