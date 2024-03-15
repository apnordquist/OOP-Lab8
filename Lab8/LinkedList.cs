using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class LinkedList
    {
        //Properties
        public int Count { get; set; }
        public Node? Head { get; set; }
        public Node? Tail { get; set; }
        //Methods
        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            if(Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }
        public void AddLast(string value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            Count++;
        }
        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
                if (Head == null)
                {  
                    Tail = null; 
                }
                Count--;
            }
            else
            {
                Console.WriteLine("The list is empty");
            }
        }
        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("The list is empty");
            }
            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null) 
                { 
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
            Count--;
        }
        public string GetValue(int index)
        {
            if (index > 0 || index <= Count) //index cannot be less than zero or greater than the count
            {
                Node current = Head;
                for (int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }
            else
            {
                return "item is outside of list";
            }
        }
        public void PrintList()
        {
            Node current = Head;
            if (current == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
