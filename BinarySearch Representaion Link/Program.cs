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

        public void preOrderTraversal(Node root)
        {
            // Checking if the root is not null
            if (root != null)
            {   //Printing the value
                Console.Write(root.val + " ");
                //Updating letft new root
                preOrderTraversal(root.leftPointer);
                //Updating right new root:
                preOrderTraversal(root.rightPointer);
            }
            else
                return;
           
        }

        public void postOrderTraversal(Node root)
        {
            if (root != null) { 
            postOrderTraversal(root.leftPointer);
            postOrderTraversal(root.rightPointer);
             Console.Write(root.val + " ");
            }
            else return;
        }

        public void inOrderTraversal(Node root)
        {
            if (root != null)
            {
                inOrderTraversal(root.leftPointer);
                Console.Write(root.val + " ");
                inOrderTraversal(root.rightPointer);
            }
            else return ;
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
            tree.preOrderTraversal(tree.Root);
            Console.WriteLine();
            tree.postOrderTraversal(tree.Root);
            Console.WriteLine();
            tree.inOrderTraversal(tree.Root);
            Console.WriteLine();
            // Console.WriteLine("Binary Tree "+ tree.Root.val);

        }
    }
}
