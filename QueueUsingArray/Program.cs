namespace QueueUsingArray
{
    public class Queue
    {
        private int max { get; set; }
        private int front;
        private int back;
        private int[]? arr;

        public Queue(int size)
        {

            this.max = size;
            this.front = 0;
            this.back = -1;
            arr = new int[size];
        }


        public bool isEmpty()
        {
            return front > back; // front is starting at 0 and rare start at -1:
        }
        public bool isFull()
        {
            return back == max - 1;
        }

        public void Enqueue(int val)
        {
            Queue queue = new Queue(val);
            if (isFull())
            {
                Console.WriteLine("Queue is Overflow");
                return;
            }
            back++;
            arr[back] = val;

        }

        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow");
                return;
            }
            Console.WriteLine(arr[front]);
           
        }

        public void printQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow");
                return;
            }
            
            for (int i = front; i <=back; i++)
            {
                Console.WriteLine("Element" + arr[i]);
            }
        }
        public void firstValue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow");
                return;
            }
            
            Console.WriteLine("First Value: "+arr[front]);
        }
        public void lastValue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow");
                return;
            }
            Console.WriteLine("First Value: " + arr[back]);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Queue queue = new Queue(10);
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.lastValue();
                queue.firstValue();
                queue.printQueue();
            }
        }
    }
}
