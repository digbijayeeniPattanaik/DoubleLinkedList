using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.AddLast(5);
            doubleLinkedList.AddLast(6);
            doubleLinkedList.AddLast(7);
            doubleLinkedList.AddLast(8);
            doubleLinkedList.AddLast(9);
            doubleLinkedList.ReadAll();
            doubleLinkedList.ReadReverse();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
