using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_Programs
{
    class MergeSorting<T> where T : IComparable
    {
        private static List<T> Merge(List<T> lo, List<T> hi)
        {
            List<T> result = new List<T>();

            while (lo.Count > 0 || hi.Count > 0)
            {
                if (lo.Count > 0 && hi.Count > 0)
                {
                    if (lo.First().CompareTo(hi.First())<0) 
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
        public List<T> MergeSort(List<T> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<T> lo = new List<T>();
            List<T> hi = new List<T>();

            int middle = unsorted.Count / 2;
            //Dividing the unsorted list
            for (int i = 0; i < middle; i++)  
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
