using System;

namespace Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs!");
            Console.WriteLine("Enter 1-to Calculate Permutation of a string");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter a string to calculate Permutation");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    Console.WriteLine("Permutation through Recursion Method");
                    Permutation.RecursivePermutation(str, 0, n - 1);
                    Console.WriteLine("\nPermutation through Iteration Method");
                    Permutation.IterativePermutation(str, n);
                    if(Permutation.recursiveList == Permutation.iterativeList)
                    {
                        Console.WriteLine("Both recursive and Iterative Method yield same array!");
                    }
                    else
                    {
                        Console.WriteLine("Both recursive and Iterative Method yield different array!");

                    }
                    break;
            }
           
        }
    }
}
