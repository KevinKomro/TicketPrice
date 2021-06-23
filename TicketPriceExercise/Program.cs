using System;

namespace TicketPriceExercise
{
    class Program
    {

        static void ProcessAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentNullException();
            }
        }

        static void Main(string[] args)
        {
            bool isStudent = false;
            bool continueTransactions = true;
            int ticketPrice;
            string response;

            while (continueTransactions == true)
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                try
                {
                    ProcessAge(age);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Age cannot be below zero!", e);
                    System.Environment.Exit(1);
                }

                if (age > 12)
                {
                    Console.WriteLine("Are you a student? Y/N");
                    response = Console.ReadLine().ToUpper();

                    if (response.Equals("Y"))
                    {
                        isStudent = true;
                    }
                }

                if ((age >= 0 & age <= 12) || (isStudent == true))
                {
                    ticketPrice = 8;
                    Console.WriteLine("You are between 0 and 12, or you are a student. ");
                    Console.WriteLine("Your ticket price is " + "$" + ticketPrice + " dollars.\x0A");
                }
                else if (age >= 13 & age <= 64)
                {
                    ticketPrice = 14;
                    Console.WriteLine("You are between 13 and 64, as you are " + age + " years old.");
                    Console.WriteLine("Your ticket price is " + "$" + ticketPrice + " dollars.\x0A");
                }
                else
                {
                    ticketPrice = 10;
                    Console.WriteLine("You are over 65 years young.");
                    Console.WriteLine("Your ticket price is " + "$" + ticketPrice + " dollars.\x0A");
                }

                //will break loop if user enters "N" or "n". 
                Console.WriteLine("Would you like to keep processing tickets? Y/N");
                string continueResponse = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (continueResponse.Equals("N"))
                {
                        continueTransactions = false;
                }
            }
        }
    }
}
