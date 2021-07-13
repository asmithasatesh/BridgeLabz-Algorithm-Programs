using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class GuessANumber
    {
        static int found = 0;
        static int startPoint=1,enPoint=100;
        public int FindMidNumber()
        {
            return ((int)(enPoint+startPoint) / 2);
        }
        public void CheckMidNumber(int midNumber)
        {
            Console.WriteLine("Enter:\n1-Is your number {0}?\n2-Is your number less than {0}?\n3-Is your number Greater than {0}?", midNumber);
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Guessed you Number!!!");
                    found = 1;
                    break;
                case 2:
                    enPoint = midNumber - 1;
                    break;
                case 3:
                    startPoint = midNumber + 1;
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
        public void ThinkANumber()
        {
            Console.WriteLine("Think of a number in Range (1-00)\n");
            while (startPoint != enPoint && found != 1)
            {
                int midNumber = FindMidNumber();
                CheckMidNumber(midNumber);
            }if(startPoint==enPoint)
            {
                Console.WriteLine("Guessed you Number!!! Number is: {0}",startPoint);

            }
        }

    }
}
