namespace DoublyLinkList
{

    public class Node
    {
        public int val { get; set; }
        public Node?next { get; set; }
        public Node? prev { get; set; }
        public Node(int val) 
        {
            this.val = val;
            next = null;
            prev = null;
        }
    }
    public class DoublyLinkList
    {
        public Node? head;
        public Node? tail;

        public void addFirst(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                // if the list is Empty then set head to new node(list)
                head = newNode;
                // head.prev point to itself because it is the only element:
                tail = newNode;


            }
            else
            {
                newNode.next = head;
                head.prev=newNode;
                head=newNode;
               

            }

        }

        public void addLast(int val)
        {
            Node newNode= new Node(val);
            if (head == null)
            {
                head = newNode;
                tail=newNode;
                
            }
            tail.next = newNode;
            newNode.prev = tail;
            tail=newNode;

        }
        public void removeFirst()
        {
            if(head == null)
                return;
            // If list has only one node:
            if (head == tail)
            {
                head = null;
                tail = null;
            }

            Node pointer = head;
            head = head.next;
            head.prev = null;

        }

        public void removeLast()
        {
            if (head == null)
                return;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            // point at tail . previous means it is pointing to second last node:
            Node pointer = tail.prev;
            // update tail to secondlast node:
            tail = pointer;
            // now empty tail.next
            tail.next = null;
           
        }

        public void  PrintValue()
        {
            if (head == null)
            {
                Console.WriteLine("The List is Empty");
                return;
            }
            Node? pointer = head;
          
            while (pointer != null)
            {
                Console.Write(pointer.val+" "+"<->");
                pointer = pointer.next;
            }
            Console.WriteLine("null");
        }
        static void Main(string[] args)
        {
            DoublyLinkList list= new DoublyLinkList();
            list.addFirst(1);
            list.addFirst(2);
            list.addFirst(3);
            list.addFirst(4);
            list.addLast(5);
            list.removeFirst();
            list.removeLast();
            list.PrintValue();
           
            Console.ReadLine();

        }
    }
}