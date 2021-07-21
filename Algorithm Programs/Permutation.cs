using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Permutation
    {
        public static List<string> recursiveList=new List<string>();

        //Permutation using Recursion
        public static void RecursivePermutation(String str,int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine( str);
                recursiveList.Add(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    RecursivePermutation(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        //Swap two array index
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

    }
}

