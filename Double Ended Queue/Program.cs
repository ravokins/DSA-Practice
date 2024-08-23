namespace Double_Ended_Queue
{
    public class DoubleEndedQ
    {
        private int[] arr;
        private int max;
        private int front;
        private int back;
        int counter;
       

        public DoubleEndedQ(int size)
        {
            this.max = size;
            this.arr = new int[size];
            this.front = -1;
            this.back = 0;
            this.counter = 0;
         
        }

        public bool isEmpty()
        {
            return counter == 0;
        }
        public bool isFull()
        {
            return  counter == max;
        }

        public void enqueueFront(int val)
        {
            if (isFull()) { Console.WriteLine("Queue is full"); return; }

            if (counterf <= max&&counterb==0)
            {
                front--;
                counterf--;
                arr[++front] = val;

            }
          
        }
        public void enqueueBack(int val)
        {
            if (isFull()) { Console.WriteLine("Queue is full"); return; }

            if (isEmpty())
            {
                arr[++back] = val;
                counterb++;
            }
            else
            {
                back--;
                counterb--;
                arr[++back] = val;
                counterb++;
            }


        }

        public void dequeueFront()
        {
            if (counterf >= 0) {
                Console.WriteLine("dequefront: " + arr[front]);
                front++;
                counterf++;
            }      
            
        }
        public void Print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Empty");
                return;
            }
            for (int i = front; i <= back; i++)
            {
                Console.Write(" Element: " + arr[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleEndedQ queue = new DoubleEndedQ(4);
            queue.enqueueFront(1);
            queue.enqueueBack(2);
            queue.enqueueBack(4);
            queue.Print();
        }
    }
}
