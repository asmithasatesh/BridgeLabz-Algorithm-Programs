using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BubbleSort
    {
        public static  void BubbleSorting(List<int> arrayList)
        {
            int n = arrayList.Count;
            for (int i = 0; i < n - 1; i++)
            { 
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arrayList[j] > arrayList[j + 1])
                    {
                        InsertionSort.Swap(arrayList, j+1, j);
                    }
                }
            }
            Console.WriteLine("*****BUBBLE SORT*****");

        }
  
    }
}
