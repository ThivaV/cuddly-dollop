using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Basic
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
    }
}
