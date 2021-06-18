using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithms.SLL;

namespace SearchAlgorithms.SearchAlgorithms
{
    public class HashTable<T> where T : IComparable<T>
    {
        public HashTable(int size)
        {
            array = new Node<T>[size];
        }

        private Node<T>[] array;
        public Node<T>[] Array
        {
            get
            {
                Node<T>[] copy = new Node<T>[array.Length];
                array.CopyTo(copy, 0);
                return copy;
            }
        }

        public void AddItem(T text)
        {
            int index = CalcIndex(text);
            Node<T> node = array[index];
            if (node == null)
                array[index] = new Node<T>(text);
            else
            {
                while (node != null)
                {
                    if (node.Value.CompareTo(text) == 0)
                        return;
                    else if (node.Next != null)
                        node = node.Next;
                    else
                    {
                        node.Next = new Node<T>(text);
                        return;
                    }
                }
            }
        }

        public int SearchIndex(T text)
        {
            int index = CalcIndex(text);
            Node<T> node = array[index];
            while(node != null)
            {
                if (node.Value.CompareTo(text) == 0)
                    return index;
                node = node.Next;
            }
            return -1;
        }

        private int CalcIndex(T text)
        {
            return Math.Abs(text.GetHashCode()) % array.Length;
        }
    }
}
