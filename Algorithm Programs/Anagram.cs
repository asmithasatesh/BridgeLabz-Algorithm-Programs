using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Anagram
    {
        public static void CheckAnagram()
        {
            Console.WriteLine("Enter String 1");
            char[] string1 = Console.ReadLine().ToCharArray();
            Console.WriteLine("Enter String 2");
            char[] string2 = Console.ReadLine().ToCharArray();
            Array.Sort(string1);
            Array.Sort(string2);
            string firstString = String.Join("", string1);
            string secondString = String.Join("", string2);
            if (string1.Length== string2.Length)
            {

                int res = firstString.CompareTo(secondString);
                if (res == 0)
                {
                    Console.WriteLine("String1 is an Anagram of String2");
                }    
            }
            else
            {
                Console.WriteLine("String1 is not Anagram of String2");

            }
        }
    }
}
