class Recursion
{
    public void CalculateItrative(int N)
    {
        while(N>0)
        {
            int K = N * N;
            Console.WriteLine(K); // Time Complaxity : (n+1):=> O(n): Linear 
           N= N - 1;

        }
    }
    static void Main(string[] args)
    {
      Recursion r=new Recursion();
        //r.CalculateItrative(10);
        // r.CalculateTRecursive(10);
        // r.CalculateHRecursive(10);
        r.CalculateTreeRecursive(10);
        Console.ReadKey();
    }
    // Tail Recursion:
    public void CalculateTRecursive(int N)
    {
        if (N > 0)
        {
            int K = N * N;
            Console.WriteLine(K);
            CalculateTRecursive(N-1); 

        }
    }
    // Head Recursion:
    public void CalculateHRecursive(int N)
    {
        if (N > 0)
        {
            CalculateHRecursive(N - 1);
            int K = N * N;
            Console.WriteLine(K);
            

        }
    }
    //Tree Recursion:
    public void CalculateTreeRecursive(int N)
    {
        if (N > 0)
        {
            CalculateTreeRecursive(N - 1);
            int K = N * N;
            Console.WriteLine(K);
            CalculateTreeRecursive(N - 1);

        }
    }
}
