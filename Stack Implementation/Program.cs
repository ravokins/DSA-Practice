namespace Stack_Implementation
{

    public class Stack
    {
        private int max;
        private int top;
        private int[]? arr;

        public Stack(int size) 
        { 
            arr = new int[size]; // Initialize the array with the specified size
            this.max = size;// Set the maximum size of the stack 
            top = -1; // Initialize the top index to -1, indicating an empty stack

        }
        // Condition to check if stack is empty or Full;
        public bool isEmpty()
        {
            return top == -1;    
        }
        public bool isfull()
        {
            return top == max - 1;
        }

        public void push(int val)
        {
            if (isfull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            arr[++top] = val;
        }
        public int pop()
        {
            if ((isEmpty()))
            {
                Console.WriteLine("Stack Underflow");
                return -1; 
            }
            return arr[--top];
        }

        public void Peak()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine(arr[top]);
            
            
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Stack s1= new Stack(6);
            s1.push(1);
            s1.Peak();
            s1.push(2);
            s1.push(3);
            s1.push(4);
            s1.Peak();
            s1.pop();
            s1.Peak();


        }
    }
}