//My version of generic singly linked list, LList contains both head and tail pointer
//it provides better performance than only head pointer in most circumstances
//will implement:
//AddBefore(Node<T> , Node<T>)*
//AddBefore(Node<T> , T)*
//AddAfter(Node<T>,Node<T>)*
//AddAfter(Node<T>,T)*
//AddFirst(T)*
//AddFirst(Node<T>)*
//AddLast(T)*
//AddLast(Node<T>)*
//Clear*
//Contains(T)*
//Equals*
//First*
//Find*
//FindLast*
//Last*
//Remove(T)*
//Remove(Node<T>)*
//RemoveFirst*
//RemoveLast*
//ToString*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGeneric
{
    public class LListNode<T>
    {
        public T Value;
        public LListNode<T> Next;

        /// <summary>
        /// Default constructor
        /// </summary>
        public LListNode()
        {
        }

        /// <summary>
        /// Constructor with initial value
        /// </summary>
        /// <param name="value"></param>
        public LListNode(T value)
        {
            Value = value;
        }
    }

    public class LList<T>
    {
        private LListNode<T> _head;
        private LListNode<T> _tail;

        /// <summary>
        /// Geter of the first item of the LList
        /// </summary>
        public LListNode<T> First
        {
            get
            {
                if (_head == null)
                    return null;
                else
                    return _head;
            }
            internal set
            {
                _head = value;
            }
        }
        /// <summary>
        /// Geter of the last item
        /// </summary>
        public LListNode<T> Last
        {
            get
            {
                if (_tail == null)
                {
                    return null;
                }
                return _tail;
            }
            internal set
            {
                _tail = value;
            }
        }

        /// <summary>
        /// Add a LList Node to the front
        /// </summary>
        /// <param name="node"></param>
        public void AddFirst(LListNode<T> node)
        {
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }
        }

        /// <summary>
        /// Add value as a node to the front
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(T value)
        {
            var node = new LListNode<T>(value);
            AddFirst(node);
        }

        /// <summary>
        /// Add a node to the rear
        /// </summary>
        /// <param name="node"></param>
        public void AddLast(LListNode<T> node)
        {
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }

        /// <summary>
        /// Add a value as a node to the rear
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            var node = new LListNode<T>(value);
            AddLast(node);
        }

        /// <summary>
        /// Add a node after a specific node
        /// both cannot be null
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newNode"></param>
        public void AddAfter(LListNode<T> node, LListNode<T> newNode)
        {
            if (node == _tail)
            {
                AddLast(newNode);
            }
            else
            {
                newNode.Next = node.Next;
                node.Next = newNode;
            }
        }

        /// <summary>
        /// Add a value as a node after a specific node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddAfter(LListNode<T> node, T value)
        {
            var newNode = new LListNode<T>(value);
            AddAfter(node, newNode);
        }

        /// <summary>
        /// Add a node before specific node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newNode"></param>
        public void AddBefore(LListNode<T> node, LListNode<T> newNode)
        {
            if (node == _head)
            {
                AddFirst(newNode);
                return;
            }
            var current = _head;
            while (current.Next != node)
            {
                current = current.Next;
            }
            newNode.Next = node;
            current.Next = newNode;
        }

        /// <summary>
        /// Add a value as a node before specific node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddBefore(LListNode<T> node, T value)
        {
            var newNode = new LListNode<T>(value);
            AddBefore(node, newNode);
        }


        /// <summary>
        /// Clear this LList
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
        }

        /// <summary>
        /// find the first appearence of specific value and return the node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public LListNode<T> Find(T value)
        {
            var current = _head;

            if (current == null)
                return null;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        /// <summary>
        /// Find the last appearance of a value and return the node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public LListNode<T> FindLast(T value)
        {
            if (_head == null)
                return null;

            var current = _head;
            LListNode<T> buffer = null;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    buffer = current;
                }
                current = current.Next;
            }

            return buffer;
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <returns></returns>
        public bool Equals(LList<T> list)
        {
            if (Object.ReferenceEquals(this.First, list.First))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Remove the object with first appearance of a value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Remove(T value)
        {
            if (_head == null)
                return false;
            var current = _head;
            while (current.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Next.Value, value))
                {
                    current.Next = current.Next.Next;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Remove specific node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Remove(LListNode<T> node)
        {
            if (_head == null)
                return false;

            var current = _head;
            while (current.Next != null)
            {
                if (Object.ReferenceEquals(current.Next, node))
                {
                    if (current.Next == _tail)
                    {
                        _tail = current;
                        current.Next = null;
                    }
                    else
                    {
                        current.Next = current.Next.Next;
                    }
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// remove the head of list
        /// </summary>
        /// <returns></returns>
        public bool RemoveFirst()
        {
            if (_head == null)
                return false;

            if (_head.Next == null)
            {
                _head = null;
                _tail = null;
                return true;
            }

            _head = _head.Next;
            return true;
        }

        /// <summary>
        /// remove the tail of the list
        /// </summary>
        /// <returns></returns>
        public bool RemoveLast()
        {
            if (_head == null)
                return false;

            if (_head.Next == null)
            {
                _head = null;
                _tail = null;
                return true;
            }

            var current = _head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
            _tail = current;
            return true;
        }

        /// <summary>
        /// Return the number of items in the list
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            LListNode<T> current = _head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        /// <summary>
        /// Find out if the list contains an item with some specific value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            if (_head == null)
                return false;

            var current = _head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Override from System.Object, convert the list to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            LListNode<T> current = _head;
            string result = "";

            while (current != null)
            {
                result += current.Value.ToString();
                if(current.Next !=null)
                    result += ",";
                current = current.Next;
            }

            return result;
        }
    }
}
