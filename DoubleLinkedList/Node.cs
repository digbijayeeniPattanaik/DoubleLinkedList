using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> Next;
        public Node<T> Previous;
    }
}
