using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    internal class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public LinkedList()
        {
        }

        public void StackOverFlow(int counter = 0)
        {
            counter++;
            Console.WriteLine($"Stack item : {counter++}");
            StackOverFlow(counter);
        }

        public void Append(object value)
        {
            Node newNode = new Node()
            {
                Value = value,
                Next = null
            };

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node nextNode = Head.Next;

                while(nextNode != null)
                {
                    if (nextNode.Next == null) break;
                    nextNode = nextNode.Next;
                }

                if (nextNode == null)
                {
                    nextNode = newNode;
                }
                else
                {
                    nextNode.Next = newNode;
                }

                Head.Next = nextNode;
            }
            Tail = newNode;

        }

        public void ShowAll()
        {
            Node nextItem = Head;
            while (nextItem != null)
            {
                Console.WriteLine($"Value : {nextItem.Value} and next node {nextItem.Next}");
                nextItem = nextItem.Next;
            }
        }
    }

    internal class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }
    }
}
