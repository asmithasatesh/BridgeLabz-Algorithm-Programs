using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs!\n");
            Console.WriteLine("Enter 1-to Calculate Permutation of a string");
            Console.WriteLine("Enter 2-to Perform Binary Search in a Word List");
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

                case 2:
                    string txtpath= File.ReadAllText(@"D:\Assignments\Algorithm Programs\Algorithm Programs\WordList.txt");
                    List<string> wordList = new List<string>(txtpath.Split(" "));
                    wordList.Sort();
                    BinarySearchInList.BinarySearch(wordList);
                    break;
            }
           
        }
    }
}
