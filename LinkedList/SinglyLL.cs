using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SinglyLL
    {
        public class Node 
        {
            public int data;
            public Node? next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }

            /*
             * add new node
             * if next == null, that means its a empty linkedlist or reached the end
             * then create a new node
             * else, recursively again sent to AddToEnd() 
             */
            public void AddToEnd(int data) 
            {
                if (next == null)
                {
                    next = new Node(data);
                }
                else
                {
                    next.AddToEnd(data);
                }
            }

            public void AddSorted(int data) 
            {
                if (next == null) 
                {
                    next = new Node(data);
                }
                else if (data < next.data) 
                {
                    Node temp = new Node(data);
                    temp.next = this.next;
                    this.next = temp;
                }
                else 
                {
                    next.AddSorted(data);
                }
            }

            public void Print()
            {
                Console.Write($"|{data}|=>");
                if (next != null) 
                { 
                    next.Print(); 
                } 
                else 
                { 
                    Console.Write("NULL"); 
                }
            }
        }
    
        public class LinkedList
        {
            public Node? headNode;

            public LinkedList()
            {
                headNode = null;
            }

            public void AddToEnd(int data)
            {
                if (headNode == null) 
                {
                    headNode = new Node(data);
                }
                else 
                {
                    headNode.AddToEnd(data);
                }
            }

            public void AddSorted(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else if (data < headNode.data) 
                {
                    AddToBeginning(data);
                }
                else 
                {
                    headNode.AddSorted(data);
                }
            }

            public void AddToBeginning(int data) 
            {
                if (headNode == null)                
                {
                    headNode= new Node(data);
                }
                else 
                {
                    Node temp = new Node(data);
                    temp.next = headNode;
                    headNode = temp;
                }
            }

            public void Print() 
            {
                if (headNode != null) 
                {
                    headNode.Print();
                }
            }
        }
    }
}
