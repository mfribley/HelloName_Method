/*
   Author: Mikessa Fribley
   Date: 1/28/2019
   Comments: This C# Console application code demonstrates the use of
   a void method after getting input from users.
*/

using System;

namespace HelloName_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Users are asked to input their full name.
            Console.Write("Enter your first and last name: ");

            /*
               The try catch block will validate user input.
               If an user provides bad input, the catch block 
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input.
                string Input = Console.ReadLine();

                /* 
                   This will execute the HelloUserName method. This is a void
                   method, therefore, it simply executes with nothing returned.
                */
                HelloUserName(Input);
            } // End of try.

            catch
            {
                Console.WriteLine("Please enter your full name next time.");
                Console.Write("Press any key to exit.");
                Console.ReadKey(true);
            } // End of catch.
        } // End of main.

        /* 
           This static void method will print the user name
           after getting input from users. The accessor is 
           private, so the method is limited to the containing class.
        */
        private static void HelloUserName(string Input)
        {
            // This variable will be used to store the name entered by user input.
            string UserName = Input;

            Console.WriteLine("");
            Console.WriteLine("Hello " + UserName + "!");
            Console.WriteLine("Press any key to exit the application.");
            Console.ReadKey(true);
        } // End of HelloUserName.
    } // End of class.
} // End of namespace.
