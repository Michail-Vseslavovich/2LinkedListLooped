using System;
using System.Collections.Generic;


namespace LinkedListLooped
{
    public class DoubleNode<T>
    {
        public T Value;
        public DoubleNode<T> Previous;
        public DoubleNode<T> Next;
        public DoubleNode(T data)
        {
            Value = data;
        }


    }
}
