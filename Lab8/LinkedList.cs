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
            if(Head == null) //replace head and tail if list is empty
            {
                Head = newNode;
                Tail = newNode;
            }
            else //add exisitng head as next then add node as new head
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }
        public void AddLast(string value)
        {
            Node newNode = new Node(value);
            if (Head == null) //replace head and tail if list is empty
            {
                Head = newNode;
            }
            else //add new node as the tail's next property
            {
                Tail.Next = newNode;
            }
            Tail = newNode; //create new tail
            Count++;
        }
        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next; //replace head with next
                if (Head == null)
                {  
                    Tail = null; 
                }
                Count--;
            }
            else //return message if list is emptry
            {
                Console.WriteLine("The list is empty");
            }
        }
        public void RemoveLast()
        {
            if (Head == null) //return message if list is empty
            {
                Console.WriteLine("The list is empty");
            }
            if (Head.Next == null) //change head to null if only one node
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null) //loop through nodes until the tail is found
                { 
                    current = current.Next;
                }
                current.Next = null; //replace tail
                Tail = current;
            }
            Count--;
        }
        public string GetValue(int index)
        {
            if (index > 0 || index <= Count) //index cannot be less than zero or greater than the count
            {
                Node current = Head;
                for (int i = 0; i < index -1; i++) //adjust index to work with counter
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
        public void PrintList() //added to have print confirmation
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
