using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class PrimeCheck
    {
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
                }
            }
            
        }
    }
}
