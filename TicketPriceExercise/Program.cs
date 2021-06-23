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
            int ticketPrice;
            string response;

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

            if(age > 12)
            {
                Console.WriteLine("Are you a student? Y/N");
                response = Console.ReadLine();

                if(response.Equals("Y") || response.Equals("y"))
                {
                    isStudent = true;
                }
            }

            if((age >= 0 & age <= 12) || (isStudent == true))
            {
                ticketPrice = 8;
            }
            else if(age >= 13 & age <= 64)
            {
                ticketPrice = 14;
            }
            else 
            {
                ticketPrice = 10;
            }

            Console.WriteLine("Your ticket price is " + "$" + ticketPrice);

        }
    }
}
