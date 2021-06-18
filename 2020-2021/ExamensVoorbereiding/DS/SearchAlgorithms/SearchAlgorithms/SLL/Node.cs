using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms.SLL
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public Node<T> Next { get; internal set; }

        public override string ToString()
        {
            return Value.ToString() + (Next != null ? "-" + Next.ToString() : "");
        }
    }
}
