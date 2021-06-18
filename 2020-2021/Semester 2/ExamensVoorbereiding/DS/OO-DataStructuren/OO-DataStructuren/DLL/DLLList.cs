using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_DataStructuren.DLL
{
    class DLLList<T>
    {
        public DLLNode<T> First { get; private set; }
        public DLLNode<T> Last { get; private set; }
        public int Length { get; private set; } = 0;

        public bool IsEmpty
        {
            get
            {
                return First == null;
            }
        }

        public DLLNode<T> AddLast(T value)
        {
            DLLNode<T> n = new DLLNode<T>(value);
            if (IsEmpty)
                First = n;
            else
                Last.Next = n;

            Last = n;
            Length++;
            return n;
        }

        public DLLNode<T> AddFirst(T value)
        {
            DLLNode<T> n = new DLLNode<T>(value);
            if (!IsEmpty)
                n.Next = First;
            else
                Last = n;

            First = n;
            Length++;
            return n;
        }

        public DLLNode<T> AddAfter(DLLNode<T> afterNode, T value)
        {
            if (afterNode == null)
                throw new ArgumentException("The afternode can't be null!");
            if (ReferenceEquals(Last, afterNode))
                return AddLast(value);

            DLLNode<T> n = new DLLNode<T>(value);
            n.Next = afterNode.Next;
            afterNode.Next = n;
            Length++;
            return n;
        }

        public DLLNode<T> AddBefore(DLLNode<T> beforeNode, T value)
        {
            if (beforeNode == null)
                throw new ArgumentException("The beforeNode can't be null!");
            if (ReferenceEquals(beforeNode, First))
                return AddFirst(value);

            DLLNode<T> n = new DLLNode<T>(value);
            DLLNode<T> temp = FindPrevious(beforeNode);

            if (temp != null)
            {
                n.Next = temp.Next;
                temp.Next = n;
            }
            else
                throw new Exception("The specified node is not part of this list!");

            Length++;
            return n;
        }

        public DLLNode<T> FindNode(T value)
        {
            DLLNode<T> temp = First;
            while (temp != null)
            {
                if (temp.Value.Equals(value))
                    return temp;
                temp = temp.Next;
            }
            return temp;
        }

        public T RemoveNode(DLLNode<T> node)
        {
            if (node == null)
                throw new ArgumentException("The node specified can't be NULL!");

            if (IsEmpty)
                throw new Exception("The list is empty!");

            if (ReferenceEquals(First, node))
            {
                First = node.Next;
                if (First == null)
                    Last = null;
                Length--;
                return node.Value;
            }

            DLLNode<T> prev = FindPrevious(node);
            if (prev != null)
            {
                prev.Next = node.Next;
                if (prev.Next == null)
                    Last = prev;
                Length--;
                return node.Value;
            }
            throw new Exception("The specified node is not part of this list!");
        }

        public void Clear()
        {
            First = null;
            Last = null;
            Length = 0;
        }

        private DLLNode<T> FindPrevious(DLLNode<T> node)
        {
            DLLNode<T> temp = First;

            if (ReferenceEquals(First, node))
                return null;

            while (temp != null && !ReferenceEquals(temp.Next, node))
                temp = temp.Next;

            return temp;
        }
    }
}
