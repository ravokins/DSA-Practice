namespace QueueLL
{

    public class Node
    {
        public int val { get; set; }
        public Node? next { get; set; }
        public Node(int val)
        {

            this.val = val;
            next = null;
           
        }
    }
    public class QueueLL
    {
        public Node? front;
        public Node? back;

        public bool isEmpty()
        {
            return front == null;
        }
      // we don't need is full because it will only get full when whole computer memory get exausted

        public void enqueue(int val)
        {
            Node newNode = new Node(val);

            // if front and back both are null means the queue is empty 
            if (back == null)
            {
                front = back = newNode;
            }
            else
            {
                back.next = newNode;
                back = newNode;
            }
         

        }

        public void dequeue() { 
        
            if(isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
          
             Console.WriteLine("Deque value: "+ front.val);
            // Remove front element:
            front=front.next;
             
            if (front == null)
            {
                // If front is null after dequeuing, it means the queue is now empty, so back should also be null
                back = null;
            }
        }
        public void Print()
        {
            Node pointer = front;
            while (pointer != null)
            {
                Console.Write(pointer.val+ " ");
                pointer = pointer.next;
            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
               QueueLL queueLL = new QueueLL();
               queueLL.enqueue(1);
               queueLL.enqueue(2);
               queueLL.enqueue(3); 
               queueLL.enqueue(4);
               queueLL.Print();
               queueLL.dequeue();
            queueLL.Print();
            queueLL.dequeue();
            queueLL.Print();
            queueLL.dequeue();
            queueLL.Print();
            queueLL.dequeue();
            queueLL.Print();
            queueLL.dequeue();
            queueLL.Print();
        }
        }
    
}
