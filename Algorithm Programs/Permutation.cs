using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Permutation
    {
        public static List<string> recursiveList=new List<string>();
        public static List<string> iterativeList = new List<string>();
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

        //Permutation through iteration
        public static void IterativePermutation(string str, int n)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string s= String.Join("", arr);

            while (true)
            {
                Console.WriteLine(s);

                iterativeList.Add(s);
                int i = n - 1;
                while (s[i - 1] >= s[i])
                {
                    if (--i == 0)
                    {
                        return;
                    }
                }
                int j = n - 1;
                while (j > i && s[j] <= s[i - 1])
                {
                    j--;
                }
                s=swap(s,i - 1, j);
                s=reverse(s,i);

            }
        }
        public static string reverse(string str,int k)
        {
            char[] chars = str.ToCharArray();
            for (int i = k, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
    }
}

