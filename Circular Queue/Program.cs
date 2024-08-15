using Circular_Queue;
using System.Drawing;

namespace Circular_Queue
{
    public class CircularQueue
    {
        private int[] arr;
        private int max;
        private int front;
        private int back;
        private int counter;
        public CircularQueue(int size)
        {
            this.max = size;
            arr = new int[size];
            front = 0;
            back = -1;
            counter = 0;
        }

        public bool isEmpty()
        {
            return counter==0;
        }
        public bool isFull()
        {
            return counter == max;
        }

        public void Enqueue(int val)
        {
            if ((isFull()))
            {
                Console.WriteLine("Queue is Overflow");
                return;
            }
                 
           
              back = (back + 1) % max;
              arr[back] = val;
            counter++;

            
        }

        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow");
                return;
            }
            Console.WriteLine("Removed Element:" + arr[front]);
            front = (front + 1) % max;
            
            counter--;
            
        }

        public void PrintCQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
          for(int i = 0; i < counter; i++)
            {
                int index= (front + i)%max;
                Console.Write(arr[index]+" ");
            }
          Console.WriteLine();
            
        }
    }

    }
    internal class Program
    {
    static void Main(string[] args)
    {
        CircularQueue cqueue = new CircularQueue(5);
        cqueue.PrintCQueue();
        cqueue.Enqueue(5);
        cqueue.Enqueue(10);
        cqueue.Enqueue(15);
        cqueue.Enqueue(20);
        cqueue.Enqueue(25); 
        cqueue.PrintCQueue();
        cqueue.Enqueue(5);
        cqueue.Dequeue();
        cqueue.PrintCQueue();
        cqueue.Enqueue(5);
        cqueue.PrintCQueue();





    }
    }

