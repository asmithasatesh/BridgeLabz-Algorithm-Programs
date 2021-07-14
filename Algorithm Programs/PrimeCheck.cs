using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class PrimeCheck
    {
        //To store Anagrams ,palindrome and prime numbers
        public static List<int> primeNumbers= new List<int>();
        public static List<int> AnagramNumbers = new List<int>();
        public static List<int> PalindromeNumbers = new List<int>();

        //Check prime number from start-End range
        public static void PrimeChecker(int start,int end)
        {
            Console.WriteLine("\n---------------- Printing Prime Number in Range ({0} - {1}) ----------------", start, end);
            for(int i=start+1;i<=end;i++)
            {
                int flag = 0;
                for (int j = start;j < i;j++)
                {
                    if(i!=0 && i!=1 && j!=0 && j!=1 && (i%2 ==0 || i%j==0))
                    {
                        flag = 1;
                        break;
                    }
                }
                if(i!=1 && (flag!=1 || i==2))
                {
                    Console.WriteLine(i);
                    primeNumbers.Add(i);
                }
            }
            PrimeCheck.AnagramCheck();
            PrimeCheck.Palindrome();
            
        }
        //Check whether any anagram is present in Primenumber list
        public static void AnagramCheck()
        {
            foreach(var i in primeNumbers)
            {
                char[] string1 = Convert.ToString(i).ToCharArray();
                Array.Sort(string1);

                foreach (var j in primeNumbers)
                {
                    char[] string2 = Convert.ToString(j).ToCharArray();
                    Array.Sort(string2);
                    string firstString = String.Join("", string1);
                    string secondString = String.Join("", string2);
                    if (i!=j && firstString==secondString && AnagramNumbers.Contains(i)==false)
                    {
                        AnagramNumbers.Add(i);
                        AnagramNumbers.Add(j);
                    }
                }
            }
            Console.WriteLine("\n---------------- Printing Anagram of Prime Number ----------------");
            foreach(var i in AnagramNumbers)
            {
                Console.WriteLine(i);
            }
        }
        //Check whether any Palinrome is present in Prime Number List
        public static void Palindrome()
        {
            foreach (var i in primeNumbers)
            {
                char[] string1 = Convert.ToString(i).ToCharArray();

                char[] string2 = Convert.ToString(i).ToCharArray();
                Array.Reverse(string2);
                string firstString = String.Join("", string1);
                string secondString = String.Join("", string2);
                if (firstString == secondString)
                {
                    PalindromeNumbers.Add(i);
                }
            }
            Console.WriteLine("\n---------------- Printing Palindrome of Prime Number ----------------");
            foreach (var i in PalindromeNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
