using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class InsertionSort<T> where T: IComparable
    {
        //Perform Insertion Sort
        public void InsertionSorting(List<T> arrayList)
        {
            for(int i=0;i<arrayList.Count-1;i++)
            {
                for(int j=i+1;j>0;j--)
                {
                    if(arrayList[j-1].CompareTo(arrayList[j])>0)
                    {
                        Swap(arrayList, j-1, j);
                    }
                }
            }
            Console.WriteLine("*****INSERTION SORT*****");
            Display(arrayList);
        }
        //Swap List
        public List<T> Swap(List<T> arrayList,int j, int i)
        {
            T temp = arrayList[j];
            arrayList[j] = arrayList[i];
            arrayList[i] = temp;
            return arrayList;
        }
        //Display List
        public void Display(List<T> arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("Element {0} of Array: {1}", i + 1, arrayList[i]);

            }
        }
    }
}
