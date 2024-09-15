using System.Collections;
using System.Collections.Generic;

namespace _2LinkedListLooped
{
    public class DoubleLinkedListLooped<T> : IEnumerable<T>
    {
        DoubleNode<T> Head;
        int count;
        public void Add(T Data)
        {
            DoubleNode<T> Node = new DoubleNode<T>(Data);
            if (Head == null)
            {
                Head = Node;
                Head.Previous = Head;
                Head.Next = Node;
            }
            else
            {
                Node.Previous = Head;
                Node.Next = Head;
                Head.Previous.Next = Node;
                Head.Previous = Node;
            }

            count++;
        }

        public bool Remove(T data)
        {
            DoubleNode<T> current = Head;

            DoubleNode<T> removedItem = null;
            if (count == 0) return false;

            // поиск удаляемого узла
            do
            {
                if (current.Value.Equals(data))
                {
                    removedItem = current;
                    break;
                }
                current = current.Next;
            }
            while (current != Head);

            if (removedItem != null)
            {
                // если удаляется единственный элемент списка
                if (count == 1)
                    Head = null;
                else
                {
                    // если удаляется первый элемент
                    if (removedItem == Head)
                    {
                        Head = Head.Next;
                    }
                    removedItem.Previous.Next = removedItem.Next;
                    removedItem.Next.Previous = removedItem.Previous;
                }
                count--;
                return true;
            }
            return false;
        }

        public void Clear()
        {
            Head = null;
            count = 0;
        }

        public int GetCount()
        {
            return count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleNode<T> CurrentNode = Head;
            do
            {
                if (CurrentNode != null)
                {
                    yield return CurrentNode.Next.Value;
                }
                else
                {
                    throw new Exception("Bezdarnost opredeli spisok a potom iterirui KURWA");
                }
            }
            while (CurrentNode != Head);
        }
    }
}