namespace StackUsingLL
{


    public class Node
    {
        public int val {  get; set; }
        public Node? next;
        public Node(int val) {
        
        this.val = val;
        next = null;
        }
       
    }
    public class Stackll
    {
        public Node? top;

        public void push(int val)
        {
            Node newNode = new Node(val);
            newNode.next = top;
            top = newNode;

        }
        public void pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            Node? pointer = top;
            top = pointer.next;
            Console.WriteLine("poped element"+pointer.val);

        }
        public void Peak()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            var result = top.val;
            Console.WriteLine(result);
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public void PrintStack()
        {
            Node? pointer = top;
            while (pointer != null)
            {
                Console.Write(pointer.val+" ");
                pointer = pointer.next;
            }
            Console.WriteLine("NuLL");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Stackll stack = new Stackll();
            stack.push(2);
            stack.push(2);
            stack.push(2);
            stack.push(2);
            //stack.Peak();
             stack.pop();
            //stack.Peak();
            stack.PrintStack();

            Stack<int>  stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            Console.WriteLine(stack1.Peek());
            stack1.Pop();
            Console.WriteLine(stack1.Peek());

        }
    }
}