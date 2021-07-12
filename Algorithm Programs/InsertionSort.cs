using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class InsertionSort
    {
        //Perform Insertion Sort
        public static void InsertionSorting(List<int> arrayList)
        {
            for(int i=0;i<arrayList.Count-1;i++)
            {
                for(int j=i+1;j>0;j--)
                {
                    if(arrayList[j-1]>arrayList[j])
                    {
                        Swap(arrayList, j-1, j);
                    }
                }
            }
            Console.WriteLine("*****INSERTION SORT*****");
            Display(arrayList);
        }
        //Swap List
        public static List<int> Swap(List<int> arrayList,int j, int i)
        {
            int temp = arrayList[j];
            arrayList[j] = arrayList[i];
            arrayList[i] = temp;
            return arrayList;
        }
        //Display List
        public static void Display(List<int> arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("Element {0} of Array: {1}", i + 1, arrayList[i]);

            }
        }
    }
}
