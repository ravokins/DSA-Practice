namespace BinarySearch_Representaion_Link
{

    public class Node
    {
        public int val { get; set; }
        public Node? leftPointer { get; set; }
        public Node? rightPointer { get; set; }
        public Node(int val)
        {

            this.val = val;
            leftPointer = null;
            rightPointer = null;
        }
    }

    public class BinaryTree
    {
        public Node? Root { get; set; }
        public BinaryTree(int rootval)
        {
            // Setting Root Value:
            Root = new Node(rootval);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        

            // Defining Root value:
            BinaryTree tree = new BinaryTree(12);
            tree.Root.leftPointer= new Node(1);
            tree.Root.rightPointer= new Node(2);
            tree.Root.leftPointer.leftPointer=new Node(3);
            tree.Root.leftPointer.rightPointer=new Node(4);
            tree.Root.rightPointer.leftPointer= new Node(5);
            tree.Root.rightPointer.rightPointer= new Node(6);

            Console.WriteLine("Binary Tree "+ tree.Root.val);
           
        }
    }
}
