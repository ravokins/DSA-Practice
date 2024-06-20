using DSA_Lern_Practice;

class main_program
{
   
    static void Main(string[] args)
    {
        //Recursion r=new Recursion();
        //r.CalculateItrative(10);
        // r.CalculateTRecursive(10);
        // r.CalculateHRecursive(10);
        // r.CalculateTreeRecursive(10);
        // Console.ReadKey();




        // Problem:
        // Sum of n Natural Naumber:
        // Console.WriteLine(r.Sumn(12));
        //Console.WriteLine( r.SumnIteraton(12));
        //Console.WriteLine( r.SumnRecursion(12));
        // Console.ReadKey();



        //ProblemR r = new ProblemR();
        ////Factorial:
        //Console.WriteLine(r.FactRecursive(100));
        //Console.WriteLine(r.FactItrative(100));
        //Console.ReadKey();



        // Searching Algorithms:

        // Linear Search:
        SearchingAlgo s=new SearchingAlgo();
        int[] A = { 12, 23, 45, 677, 90 };
        int Result = s.LinearSearch(A,5,0);
        Console.WriteLine("Result:"+Result);
        Console.ReadKey();

    }
   
}
