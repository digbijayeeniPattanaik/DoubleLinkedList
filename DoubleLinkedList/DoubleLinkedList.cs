using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    public class DoubleLinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public void AddFirst(T item)
        {
            var newItem = new Node<T>();
            newItem.data = item;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.Next = head;
                head = newItem;
            }
        }
        public void AddLast(T item)
        {
            var newItem = new Node<T>();
            newItem.data = item;
            if (head == null)
            {
                head = newItem;
            }
            else
            {
                tail.Next = newItem;
                newItem.Previous = tail;
            }

            tail = newItem;
        }
        public void ReadAll()
        {
            var current = head;
            while (current.Next != null)
            {
                Console.WriteLine(current.data);
                current = current.Next;
            }

            Console.WriteLine(current.data);
        }
        public void ReadReverse()
        {
            var current = tail;
            while (current.Previous != null)
            {
                Console.WriteLine(current.data);
                current = current.Previous;
            }

            Console.WriteLine(current.data);
        }
    }
}
