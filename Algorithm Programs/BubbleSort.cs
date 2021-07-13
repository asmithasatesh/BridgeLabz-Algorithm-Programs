using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BubbleSort<T> where T: IComparable
    {
        InsertionSort<T> bubbleDisplay = new InsertionSort<T>();
        public void BubbleSorting(List<T> arrayList)
        {
            int n = arrayList.Count;
            for (int i = 0; i < n - 1; i++)
            { 
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arrayList[j].CompareTo(arrayList[j + 1])>0)
                    {
                        bubbleDisplay.Swap(arrayList, j+1, j);
                    }
                }
            }
            Console.WriteLine("*****BUBBLE SORT*****");
            bubbleDisplay.Display(arrayList);

        }
  
    }
}
