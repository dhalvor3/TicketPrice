using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isStudent = false;
            int price = 14;

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you a student? (enter yes or no): ");
            string inputStudent  = Console.ReadLine();
            if (inputStudent == "yes" ) {
                isStudent = true;
            } else {
                isStudent = false;
            }

            if ((age >= 0 && age < 13) || isStudent == true ) {
                price = 8;
            } else if (age > 65) {
                    price = 12;
            } 
            
            try {   
                if (age < 0) {
                    throw new ArithmeticException ("Age must be greater than 0");
                } else {
                Console.WriteLine("Your ticket price is: " + price);
                }
            }
            catch (ArithmeticException) {
                Console.WriteLine("Age must be greater than 0");
            }
            
        }
    }
}
