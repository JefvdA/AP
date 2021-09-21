using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_DataStructuren.DLL
{
    class DLLNode<T> : SLL.SLLNode<T>
    {
        public DLLNode(T value) : base(value) { }

        private DLLNode<T> next;

        public DLLNode<T> Next
        {
            get { return next; }
            internal set
            {
                next = value;
                if (value != null && !ReferenceEquals(value.Prev, this))
                    value.Prev = this;
            }
        }

        private DLLNode<T> prev;

        public DLLNode<T> Prev
        {
            get { return prev; }
            internal set
            {
                prev = value;
                if (value != null && !ReferenceEquals(value.Next, this))
                    value.Next = this;
            }
        }

        public override string ToString()
        {
            return Value.ToString() + (Next != null ? "-" + Next.ToString() : "");
        }
    }
}
