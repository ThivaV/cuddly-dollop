// See https://aka.ms/new-console-template for more information
using System;

namespace LinkedList 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Basic LinkedList implementation
            Console.WriteLine("Basic LinkedList Implementation");
            Basic.Node BasicLLImp = new Basic.Node(4);
            BasicLLImp.next = new Basic.Node(2);
            BasicLLImp.next.next = new Basic.Node(3);
            BasicLLImp.next.next.next = new Basic.Node(4);
            BasicLLImp.Print();
            Console.WriteLine();

            // Singly LinkedList implementation
            Console.WriteLine("Singly LinkedList Implementation");
            SinglyLL.LinkedList list = new SinglyLL.LinkedList();
            list.AddToEnd(1);
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(10);
            list.AddToEnd(-5);
            list.AddToEnd(4);
            list.AddToBeginning(0);
            list.AddToBeginning(-6);
            list.Print();
            Console.WriteLine();

            // Singly Sorted LinkedList implementation
            Console.WriteLine("Singly Sorted LinkedList Implementation");
            SinglyLL.LinkedList sortedList = new SinglyLL.LinkedList();
            sortedList.AddSorted(100);
            sortedList.AddSorted(2);
            sortedList.AddSorted(1);
            sortedList.AddSorted(10);
            sortedList.AddSorted(-5);
            sortedList.AddSorted(4);
            sortedList.AddSorted(1);
            sortedList.AddSorted(0);
            sortedList.AddSorted(-6);
            sortedList.Print();
            Console.WriteLine();
        }
    }
}
