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

        // Checking if the given subtree is BST(Binary search tree) or not 
        public Node lastVisited = null;
        public int isBst(Node root)
        {
            if (root != null)
            {
               
              if(isBst(root.leftPointer)==0) return 0;
              if(lastVisited != null&&root.val<=lastVisited.val) return 0;
              lastVisited = root;
              if(isBst(root.rightPointer)==0) return 0;

            }
             
            return 1;
        }
        public void PrintISBST()
        {
            lastVisited = null;
            int result = isBst(Root);
            if (result == 0) Console.WriteLine("Not BST");
            else Console.WriteLine("BSt");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        

            // Defining Root value:
            BinaryTree tree = new BinaryTree(12);
            tree.Root.leftPointer= new Node(10);
            tree.Root.leftPointer.leftPointer=new Node(4);
            tree.Root.leftPointer.rightPointer=new Node(11);
            tree.Root.rightPointer= new Node(14);
            tree.Root.rightPointer.leftPointer= new Node(13);
            tree.Root.rightPointer.rightPointer= new Node(15);
            tree.preOrderTraversal(tree.Root);
            Console.WriteLine();
            tree.postOrderTraversal(tree.Root);
            Console.WriteLine();
            tree.inOrderTraversal(tree.Root);
            Console.WriteLine();
            tree.PrintISBST();
            Console.ReadLine();
            // Console.WriteLine("Binary Tree "+ tree.Root.val);

        }
    }
}
