using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithm_Programs
{
    class MessageDemonstartion
    {
        public static void GetInput()
        {
            string statement= "\nHello <<name>>,\n  We have your fullname as <<fullname>> in our system. Your contact number is 91 - xxxxxxxxxx. Please,let us know in case of any clarification.\n\nThank you, \nBridgeLabz \n(xx/xx/xxxx)";
            Console.WriteLine(RegExFunction(statement));
        }

        public static string RegExFunction(string statement1)
        {
            string namePattern = "^[<]*name[>]*";
            string fullnamePatter = "[<]*fullname[>]*";
            string numberpatter = "[x]*";
            string dateTime = "^[xx][/][xx][/][xxxx]$";
            Regex regexname = new Regex(namePattern);
            Regex fullname = new Regex(fullnamePatter);
            Regex numberpattern = new Regex(numberpatter);
            Regex datetime = new Regex(dateTime);



            if (regexname.IsMatch("<<name>>"))
            {
                Console.WriteLine("Enter your first name");
                statement1 = statement1.Replace("<<name>>",Console.ReadLine());

            }
            if (fullname.IsMatch("<<fullname>>"))
            {
                Console.WriteLine("Enter your full name");
                statement1 = statement1.Replace("<<fullname>>",Console.ReadLine());

            }
            if (numberpattern.IsMatch("xxxxxxxxxx"))
            {
                Console.WriteLine("Enter your phone number");
                statement1 = statement1.Replace("xxxxxxxxxx", Console.ReadLine());

            }
            if (numberpattern.IsMatch("xx/xx/xxxx"))
            {
                string date = DateTime.UtcNow.ToString("MM/dd/yyyy");

                statement1 = statement1.Replace("xx/xx/xxxx", date);

            }
            return statement1;
        }
    }
}
