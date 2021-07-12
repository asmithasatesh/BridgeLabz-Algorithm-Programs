using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_Programs
{
    class MergeSorting
    {
        private static List<int> Merge(List<int> lo, List<int> hi)
        {
            List<int> result = new List<int>();

            while (lo.Count > 0 || hi.Count > 0)
            {
                if (lo.Count > 0 && hi.Count > 0)
                {
                    if (lo.First() <= hi.First()) 
                    {
                        result.Add(lo.First());
                        lo.Remove(lo.First());   
                    }
                    else
                    {
                        result.Add(hi.First());
                        hi.Remove(hi.First());
                    }
                }
                else if (lo.Count > 0)
                {
                    result.Add(lo.First());
                    lo.Remove(lo.First());
                }
                else if (hi.Count > 0)
                {
                    result.Add(hi.First());

                    hi.Remove(hi.First());
                }
            }
            return result;
        }
        static public List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> lo = new List<int>();
            List<int> hi = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                lo.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                hi.Add(unsorted[i]);
            }

            lo = MergeSort(lo);
            hi = MergeSort(hi);
            return Merge(lo, hi);
        }
    }
}
