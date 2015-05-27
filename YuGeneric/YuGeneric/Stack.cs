using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGeneric
{
    public class Stack<T>
    {
        private StackNode<T> _top;

        public StackNode<T> Top
        {
            get
            {
                return _top;  
            }
            set
            {
                _top = value;
            }
        }

        public void Push(StackNode<T> node)
        {
            if (_top == null)
                _top = node;
            else
            {
                node.Next = _top;
                _top = node;
            }
        }

        public void Push(T value)
        {
            var node = new StackNode<T>(value);
            this.Push(node);
        }

        public void Pop()
        {
            if (_top == null)
                return;
            else
            {
                _top = _top.Next;
            }
        }

        public bool IsEmpty()
        {
            if (_top == null)
                return true;
            else
                return false;
        }
    }

    public class StackNode<T>
    {
        private T _value;
        private StackNode<T> _next;

        public StackNode()
        {
        }

        public StackNode(T value){
            _value = value;
            _next = null;
        }

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public StackNode<T> Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }
    }
}
