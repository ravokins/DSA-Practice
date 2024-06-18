class Recursion
{
    public void Calculate(int N)
    {
        while(N>0)
        {
            int K = N * N;
            Console.WriteLine(K);
           N= N - 1;

        }
    }
    static void Main(string[] args)
    {
      Recursion r=new Recursion();
        r.Calculate(10);
        Console.ReadKey();
    }
}
