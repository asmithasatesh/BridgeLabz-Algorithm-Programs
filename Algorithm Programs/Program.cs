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
            Console.WriteLine("Enter 3-to Perform Insertion Sort");
            Console.WriteLine("Enter 4-to Perform Bubble Sort");
            Console.WriteLine("Enter 5-to Perform Merge Sort");
            Console.WriteLine("Enter 6-Check Anagram or not");
            Console.WriteLine("Enter 7-Check Prime numbers in a given range and print anagram and Palindrome");
            Console.WriteLine("Enter 10-to Play Guess a number!");
            Console.WriteLine("Enter 11-Message Demonstartion using RegEx");


            //Creating generics Object for generic Class
            BinarySearchInList<string> binarySearchInList = new BinarySearchInList<string>();
            InsertionSort<int> insertion = new InsertionSort<int>();
            BubbleSort<int> bubbleSort = new BubbleSort<int>();
            MergeSorting<int> obj = new MergeSorting<int>();
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

                    //Get search word from user
                    Console.WriteLine("Enter the word to be searched in list");
                    string key = Console.ReadLine();
                    string found=binarySearchInList.BinarySearch(wordList,key);
                    if(found==key)
                    {
                        Console.WriteLine("Found word \"{0}\" in Text File!", key);

                    }
                    else
                    {
                        Console.WriteLine("Word does not exist in Text File!");

                    }
                    break;

                case 3:
                    List<int> arr = ArrayInput();
                    insertion.InsertionSorting(arr);
                    break;

                case 4:
                    List<int> buubleSort = ArrayInput();
                    bubbleSort.BubbleSorting(buubleSort);
                    break;
                case 5:
                    List<int> mergeSort = ArrayInput();
                    mergeSort=obj.MergeSort(mergeSort);
                    Console.WriteLine("*****MERGE SORT*****");
                    insertion.Display(mergeSort);
                    break;
                case 6:
                    Anagram.CheckAnagram();
                    break;
                case 7:
                    Console.WriteLine("Enter Start range");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter end range");
                    int end = Convert.ToInt32(Console.ReadLine());
                    PrimeCheck.PrimeChecker(start, end);
                    break;
                case 10:
                    GuessANumber obj1 = new GuessANumber();
                    obj1.ThinkANumber();
                    break;
                case 11:
                    MessageDemonstartion.GetInput();
                    break;
            }
           
        }

        //Get integer List from user
        public static List<int> ArrayInput()
        {
            Console.WriteLine("Enter the Array size");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> array= new List<int>();
            while(number-- >0)
            {
                Console.WriteLine("Enter a number:");
                array.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return array;
        }
    }
}
