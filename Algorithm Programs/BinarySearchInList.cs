using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BinarySearchInList<T> where T : IComparable
    {
        //Check if a word is present in word List
        public T BinarySearch(List<T> wordList,T key)
        {
            //Initialize Local Variables
            int mid,beg = 0;
            int end = wordList.Count - 1;
            bool found = false;

            while (beg<=end)
            {
                mid = beg+ (end-beg) / 2;
                int flag = key.CompareTo(wordList[mid]);
                if (flag == 0)
                {
                    found = true;
                    break;
                }
                else if( flag > 0)
                {
                    beg = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if(!found)
            {
                return default;
            }
            else
            {
                return key;
            }
          
        }
    }
}
