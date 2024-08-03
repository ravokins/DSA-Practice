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
        //SearchingAlgo s=new SearchingAlgo();
        //int[] A = { 12, 23, 45, 677, 90 };
        //int Result = s.LinearSearch(A,5,0);
        //Console.WriteLine("Result:"+Result);
        //Console.ReadKey();

        //// Binary Serch using itratiion:
        //SearchingAlgo s = new SearchingAlgo();
        //int[] A = { 12, 23, 45, 677, 90 };
        //int Result = s.BinarySearch(A, 6, 90);
        //Console.WriteLine("Result:" + Result);
        //Console.ReadKey();

        // Binary Serch using Recursion:
        //SearchingAlgo s = new SearchingAlgo();
        //int[] A = { 12, 23, 45, 677, 90 };
        //int Result = s.BinaryRSearch(A,677,0,4);
        //Console.WriteLine("Result:" + Result);


     
        // Sorting Algorithms:
        int[] A = { 12, 23, 45, 677, 90 };
        //BubbleSort bubbleshort=new BubbleSort();
       // SlectionSort sort = new SlectionSort();
      // InsertionSort insertionSort = new InsertionSort();
        Console.WriteLine("Before Sorting:");
        PrintArray(A);
        Console.WriteLine("\n After Sorting:");
        MergedSort mergedSort = new MergedSort();
        mergedSort.Divide(A,0,A.Length-1);
       // QuickSort quickSort = new QuickSort();
       // quickSort.QuickSorting(A, 0,A.Length-1);
       // insertionSort.InsertionSorting(A);
       // bubbleshort.BubbleSorting(A);
        PrintArray(A);
        Console.ReadKey();

    }
    public static void PrintArray(int[] Arr)
    {
        foreach (int i in Arr)
        {
            Console.Write(" " + i + " ");
        }
    }
}
