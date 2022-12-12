using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeralble
{
    //make a generic stack class
    class Stack<t>:IEnumerable
    {
        
        private Node<t> top;
        
        public Node<t> Top
        {
            get { return top; }
            set { top = value; }
        }

        public Stack()
        {
            top = null;
        }

        public void Push(t data)
        {
            Node<t> newNode = new Node<t>(data);
            newNode.Next = top;
            top = newNode;
        }
        
        public t Pop()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }
            t data = top.Data;
            top = top.Next;
            return data;
        }
        
        public t Peek()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }
            return top.Data;
        }
        
        public bool IsEmpty()
        {
            return top == null;
        }



        
        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<t> current = top;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
}
    }
}
