using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGeneric
{
    public class LList<T>
    {
        public class Node<T>
        {
            public T Value;
            public Node<T> Next;
        }

        private Node<T> _head;

        public void AddFirst(Node<T> node)
        {
            node.Next = _head;
            _head = node;
        }

        public override string ToString()
        {
            Node<T> current = _head;
            string result = "";

            while (current != null)
            {
                result += current.Value.ToString();
                current = current.Next;
            }

            return result;
        }

        public int Count()
        {
            Node<T> current = _head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
    }
}
