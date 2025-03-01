using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLooped.Code
{
    internal class LoopEnumerator<T> : IEnumerator
    {
        private DoubleNode<T> current;
        private DoubleNode<T> head;
        private bool questionNewEnum;

        public LoopEnumerator (DoubleNode<T> Node)
        {
            current = Node;
            head = Node;
            questionNewEnum = true;
        }

        public bool MoveNext()
        {
            if (questionNewEnum)
            {
                questionNewEnum = false;
                return true;
            }
            if (current.Next != head)
            {
                
                current = current.Next;
                return true;
            }
            
            
            return false;
        }

        public object Current
        {
            get
            {
                
                return current.Value;
            }
        }
        public void Reset()
        {
            current = head;

        }
    }
}
