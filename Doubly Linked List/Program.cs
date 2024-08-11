using System;
using System.Runtime.CompilerServices;

namespace Doubly_Linked_List
{
    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }
        public Node(int value) {
        this.value = value;
            next = null;
        }

    }


    public class CircularLinkList
    {
        public Node head;
        // Adding Elemrnt At first

        public void addLast(int value)
        {
            Node newNode= new Node(value);
            Node pointer = head;

            while (pointer.next != head)
            {
               pointer = pointer.next;
            }
            pointer.next = newNode;
            newNode.next = head;

        }

        public void addfirst(int value)
        {
            Node newNode= new Node(value);
            if (head == null) {
            
                head = newNode;
                head.next = head;
            }

            Node pointer = head;
            while (pointer.next != head)
            {
                pointer = pointer.next;
            }

            // add new node next to previous head:
            newNode.next = head;

            // Now added pointer which is the last element pointer of the link list to the new node because now new node is the head
            pointer.next = newNode;
           
            head = newNode;
            
        }

        // Remove Last:

        public void removeLast()
        {
          if(head == null)
            {
                Console.WriteLine("List is Empty");
                return;
          }
          if(head.next == head)
            {
                head.next = null;
            }

            Node pointer = head;
            while(pointer.next.next != head)
            {
                pointer= pointer.next;
            }
            pointer.next.next = null;
            pointer.next = head;
        }

        // Remove First:
        public void removeFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            if (head.next == head)
            {
                head.next = null;
            }

            Node pointer = head;
            while(pointer.next != head)
            {
                pointer= pointer.next;
            }

            pointer.next= head.next;
            head=head.next;
        }

        // Printing circular Link List:
        public void CircularPrint()
        {
           Node pointer= head;

            do
            {
                Console.Write(pointer.value + " " + "->");
                pointer = pointer.next;
            }
            while (pointer!= head);
            Console.Write("head");

        }


        static void Main(string[] args)
        {
            CircularLinkList l= new CircularLinkList();
            l.addfirst(5);
            l.addfirst(6);
            l.addfirst(7);
            l.addfirst(8);
            l.addLast(9);
            l.addLast(10);
            l.removeLast();
            l.removeFirst();
            l.CircularPrint();
            Console.ReadLine();
        }
    }
}
