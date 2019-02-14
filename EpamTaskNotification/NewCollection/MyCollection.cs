using System;
using System.Collections;
using System.Collections.Generic;


namespace EpamTaskNotification.NewCollection
{
    class MyCollection<T> : IEnumerable<T>
    {

        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public Node<T> CurrentNode { get; set; }
        public int Count { get; set; }
        private int position = 0;

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

        public IEnumerator<T> GetEnumerator()
        {

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
