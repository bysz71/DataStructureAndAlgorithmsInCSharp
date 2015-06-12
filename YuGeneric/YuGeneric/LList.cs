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

namespace Yu.DataStructure.Generic
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

            if (_head == _tail)
            {
                if (EqualityComparer<T>.Default.Equals(_head.Value, value))
                {
                    this.Clear();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (EqualityComparer<T>.Default.Equals(_head.Value, value))
            {
                this.RemoveFirst();
                return true;
            }
            else if (EqualityComparer<T>.Default.Equals(_tail.Value, value))
            {
                this.RemoveLast();
                return true;
            }
            else
            {
                var prev = _head;
                while (prev.Next != null)
                {
                    if (EqualityComparer<T>.Default.Equals(prev.Next.Value, value))
                    {
                        prev.Next = prev.Next.Next;
                        return true;
                    }
                    prev = prev.Next;
                }
                return false;
            }
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

            if (_head == _tail && ReferenceEquals(_head, node))
            {
                this.Clear();
                return true;
            }
            else if (ReferenceEquals(_head, node))
            {
                this.RemoveFirst();
                return true;
            }
            else if (ReferenceEquals(_tail,node))
            {
                this.RemoveLast();
                return true;
            }
            else
            {
                var prev = _head;
                while (prev.Next != null)
                {
                    if (ReferenceEquals(prev, node))
                    {
                        prev.Next = prev.Next.Next;
                        return true;
                    }
                    prev = prev.Next;
                }
                return false;
            }
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

            if (_head == _tail)
            {
                _head = null;
                _tail = null;
                return true;
            }

            var prev = _head;
            while (prev.Next != _tail)
            {
                prev = prev.Next;
            }

            prev.Next = null;
            _tail = prev;
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
                if (current.Next != null)
                    result += ",";
                current = current.Next;
            }

            return result;
        }

        /// <summary>
        /// Determine if the list is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (_head == _tail && _head == null)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// concatenate 2 list
        /// list1 now access to the head and tail of new list
        /// list2 pointers keep its original position
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        public static void Concatenate(ref LList<T> list1, ref LList<T> list2)
        {
            if (list1.IsEmpty())
            {
                Console.WriteLine("list1 is empty");
                list1 = list2;
                //list1.First = list2.First;
                //list1.Last = list2.Last;
                Console.WriteLine("list1 now refer to list2");
                return;
            }
            if (!list2.IsEmpty())
            {
                list1.Last.Next = list2.First;
                list1.Last = list2.Last;
            }
        }

        /// <summary>
        /// Reverse a list
        /// Using strategy 1: create a new list and assign origin to this list
        /// </summary>
        /// <param name="list"></param>
        public static void Reverse1(ref LList<T> list)
        {
            if (list.IsEmpty())
                return;

            var temp = new LList<T>();
            var current = list.First;
            while (current != null)
            {
                temp.AddFirst(current.Value);
                current = current.Next;
            }
            list = temp;
        }

        /// <summary>
        /// return the node at "i"th position
        /// return null if empty list or list not long enough
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public LListNode<T> FindByPosition(int i)
        {
            if (_head == null)
            {
                Console.WriteLine("empty list return null");
                return null;
            }
            var current = _head;
            int count = 0;
            while (current != null)
            {
                if (count == i)
                {
                    return current;
                }

                current = current.Next;
                count++;
            }
            Console.WriteLine("index overflow return null");
            return null;
        }

        /// <summary>
        /// Reverse strategy 2
        /// traverse from (first,last) , (first+1,last-1) ... swap each other's value
        /// </summary>
        public static void Reverse2(LList<T> list)
        {
            if (list.IsEmpty())
                return;

            T temp;
            for (int i = 0; i < list.Count() / 2; i++)
            {
                temp = list.FindByPosition(i).Value;
                list.FindByPosition(i).Value = list.FindByPosition(list.Count() - 1 - i).Value;
                list.FindByPosition(list.Count() - 1 - i).Value = temp;
            }
        }

        /// <summary>
        /// reverse strategy 3;
        /// change each node's pointer from "point to next" to "point to prev";
        /// it needs to declare 3 pointers for different purpose;
        /// a "firstHolder" to hold the first item;
        /// a "current" to point to the node whose "Next" needs to redirect;
        /// a "pointerHolder" to point to the node next to the current node, so once current redirect, this node still can be accessed;
        /// see as a "a b c" sliding window slide through the list;
        /// once "b" finishes redirection, whole window slide one node;
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static void Reverse3(LList<T> list)
        {
            if (list.IsEmpty() || list.Count() == 1)
                return;
            var firstHolder = list.First;
            var current = list.First.Next;
            LListNode<T> pointerHolder;
            while (current != null)
            {
                pointerHolder = current.Next;
                current.Next = list.First;
                list.First = current;
                current = pointerHolder;
            }
            firstHolder.Next = null;
            list.Last = firstHolder;
        }

        /// <summary>
        /// Split a list by index
        /// Original list will end at the index
        /// The rest of list will be return as a new list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static LList<T> Split(LList<T> list , int i)
        {
            if (list.IsEmpty() || list.Count() == 1)
                return null;
            LList<T> result = new LList<T>();
            var temp = list.FindByPosition(i);
            if (temp == null)
                return null;
            result.First = temp.Next;
            if (i == list.Count() - 1)
                result.Last = temp.Next;
            else
                result.Last = list.Last;
            temp.Next = null;
            return result;
        }
    }
}
