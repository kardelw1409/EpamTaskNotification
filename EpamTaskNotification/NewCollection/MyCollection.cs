using System;
using System.Collections;
using System.Collections.Generic;


namespace EpamTaskNotification.NewCollection
{
    public class MyCollection<T> : IEnumerable<T>
    {

        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        private Node<T> CurrentNode { get; set; }
        public int Count { get; set; }

        public MyCollection()
        {
            First = Last = null;
            Count = 0;
        }

        public void Add(T value)
        {
            if (Count == 0)
            {
                Node<T> node = new Node<T>(value);
                First = node;
                Last = node;
                CurrentNode = node;
                Count++;
            }
            else
            {
                Node<T> node = new Node<T>(value);
                node.Prev = Last;
                Last.Next = node;
                Last = node;
                Count++;
            }
        }

        public void AddFirst(T value)
        {
            if (Count == 0)
            {
                Node<T> node = new Node<T>(value);
                First = node;
                Last = node;
                CurrentNode = node;
                Count++;
            }
            else
            {
                Node<T> node = new Node<T>(value);
                node.Next = First;
                First.Prev = node;
                First = node;
                Count++;
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                Node<T> node = Last.Prev;
                Last.Prev = null;
                node.Next = null;
                Last = node;
                Count--;
            }

        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Node<T> node = First.Next;
                First.Next = null;
                node.Prev = null;
                First = node;
                CurrentNode = First;
                Count--;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            int position = 0;
            while (true)
            {
                if (position == Count)
                {
                    position = 0;
                    CurrentNode = First;
                    yield break;
                }
                yield return CurrentNode.Value;
                position++;
                CurrentNode = CurrentNode.Next;

            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

    }
}
