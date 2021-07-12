using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BinarySearchInList
    {
        //Check if a word is present in word List
        public static void BinarySearch(List<string> wordList)
        {
            //Initialize Local Variables
            int mid,beg = 0;
            int end = wordList.Count - 1;
            bool found = false;

            //Get search word from user
            Console.WriteLine("Enter the word to be searched in list");
            string key = Console.ReadLine();

            while (beg<=end)
            {
                mid = beg+ (end-beg) / 2;
                int flag = key.CompareTo(wordList[mid]);
                if (flag == 0)
                {
                    Console.WriteLine("Found word \"{0}\" in Text File!", key);
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
                Console.WriteLine("Word does not exist in Text File!");
            }
          
        }
    }
}
