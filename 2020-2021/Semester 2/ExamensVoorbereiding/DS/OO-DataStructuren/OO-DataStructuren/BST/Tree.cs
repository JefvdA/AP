using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_DataStructuren.BST
{
    public class Tree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; private set; }

        public Node<T> Insert(T value)
        {
            Node<T> n = new Node<T>(value);
            if (Root == null)
                Root = n;
            else
            {
                Node<T> node = FindNode(Root, value);
                if (node.Value.CompareTo(value) == 0)
                    return node;
                else if (node.Value.CompareTo(value) > 0)
                    node.Left = n;
                else
                    node.Right = n;
            }
            return n;
        }

        public Node<T> FindNode(T value)
        {
            Node<T> node = FindNode(Root, value);
            if (node.Value.CompareTo(value) != 0)
                return null;

            return node;
        }

        public T RemoveNode(T value)
        {
            Root = RemoveNode(Root, value);
            return value;
        }

        public void Clear(T value)
        {
            Root = null;
        }


        private Node<T> RemoveNode(Node<T> root, T value)
        {
            if (root == null)
                return root;

            if(root.Value.CompareTo(value) > 0)
            {
                root.Left = RemoveNode(root.Left, value);
                return root;
            }
            else if(root.Value.CompareTo(value) < 0)
            {
                root.Right = RemoveNode(root.Right, value);
                return root;
            }

            if (root.Left == null)
                return root.Right;
            if (root.Right == null)
                return root.Left;

            T min = FindMinValue(root.Right);
            Node<T> n = RemoveNode(root, min);
            root.Value = min;
            return n;
        }

        private T FindMinValue(Node<T> root)
        {
            if (root == null)
                return default(T);
            if (root.Left != null)
                return FindMinValue(root.Left);
            return root.Value;
        }

        private Node<T> FindNode(Node<T> parent, T value)
        {
            Node<T> temp;

            if (parent == null)
                return parent;

            if (parent.Value.CompareTo(value) == 0)
                temp = parent;
            else if (parent.Value.CompareTo(value) > 0)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);

            return (temp == null ? parent : temp);
        }
    }
}
