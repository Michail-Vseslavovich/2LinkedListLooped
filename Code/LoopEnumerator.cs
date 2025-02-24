using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2LinkedListLooped.Code
{
    internal class LoopEnumerator<T> : IEnumerator
    {
        private DoubleNode<T> current;
        private DoubleNode<T> head;

        public LoopEnumerator (DoubleNode<T> Node)
        {
            current = Node;
            head = Node;
        }

        public bool MoveNext()
        {
            if (current.Next != head)
            {
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
