using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_DataStructuren.SLL
{
    class SLLNode<T>
    {
        public SLLNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public SLLNode<T> Next { get; internal set; }

        public override string ToString()
        {
            return Value.ToString() + (Next != null ? "-" + Next.ToString() : "");
        }
    }
}
