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
        r.CalculateRecursive(10);
        Console.ReadKey();
    }

    public void CalculateRecursive(int N)
    {
        if (N > 0)
        {
            int K = N * N;
            Console.WriteLine(K);
            CalculateRecursive(N-1); 

        }
    }
}
