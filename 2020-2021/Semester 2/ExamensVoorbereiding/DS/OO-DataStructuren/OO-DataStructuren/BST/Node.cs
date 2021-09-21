using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_DataStructuren.BST
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
