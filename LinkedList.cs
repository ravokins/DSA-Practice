using System;
using System.Drawing;

namespace DSA_Lern_Practice
{
    public class LinkedList
    {
        public Node? head;
       
      
        public class Node
        {
            public string value { get; set; }
            public Node? next { get; set; }


            public Node(string value)
            { this.value = value; 
              next = null;
              

            }
        }

        public void addFirst(string value)
        {
            Node newNode= new Node(value);
            //Making this Node as a head node because we are inserting in first so the first node is now this and head is always on first node:
            newNode.next = head;
            //now we have to make the new node is head because head always in first:
            head = newNode;
        }

        public void addLast(string value)
        {
            Node newNode = new Node(value);
            //To determine if the linked list is currently empty.
            if (head == null)
            {
                //To set the new node as the head of the list
                head = newNode;
            }
            Node pointerNode = head;
            // checks untill the last node is null if null then condition false and get out of loops:
          while (pointerNode.next != null)
            {

                pointerNode = pointerNode.next;
            }
            pointerNode.next = newNode;

            
        }
        
        public void removeFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

             // this will remove head from first and add it to head.next  
             head = head.next;
            
        }
        public void removeLast() {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            if(head.next == null)
            {
                head = null;
                return;
            }
            Node current= head;
            while(current.next.next != null)
            {
                current = current.next;
            }
            current.next= null;
        }
        public void display()
        {
            //initally first node have head:
            Node? currentNode = head;
            
            while (currentNode != null)
            {
                Console.Write(currentNode.value+"->");
                // updating current node to next node to print the data of next node:
                currentNode = currentNode.next;
            }
            // to print the last element is null:
            Console.Write("null");
        }

       
        private static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.addFirst("a");
            list1.addFirst("is");
            list1.addFirst("this");
            list1.addLast("List");
            list1.display();
            list1.removeLast();
            list1.display();
            list1.removeFirst();
            list1.display();

        }
    }

    
}
