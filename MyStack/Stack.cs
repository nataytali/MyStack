using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Stack<T>
    {
        private Node<T> Top;
        public void Push(T data)
        {
            Node<T> tempNode = new Node<T>();
            tempNode.Data = data;
            tempNode.Next = Top;
            Top = tempNode;
        }
        public T Pop()
        {
            if (Top == null) 
                throw new InvalidOperationException("The stack is empty"); ;
            Node<T> pooped = Top;
            Top = Top.Next;
            pooped.Next = null;
            return pooped.Data;

        }
        public object Peek()
        {
            if (Top == null)
                throw new InvalidOperationException("The stack is empty");
            
            return Top.Data;
        }
    }
}
