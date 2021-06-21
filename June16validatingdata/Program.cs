using System;
using System.Text.RegularExpressions;

namespace June16validatingdata
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserInput();
            ValidateUserEmail();
            ValidateUserName();
            ValidateTheDate();
        }

        static void ValidateUserInput()
        {
            Regex pattern = new Regex(@"(\d{3}-)(\d{3}-)(\d{4}-)");
            Console.WriteLine("Please enter valid phone number.");
            var phoneNumber = Console.ReadLine();

            if (pattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("This is a real number");

            }
            else
            {
                Console.WriteLine("This number is not real.");
            }
        }

        static void ValidateUserEmail()
        {
            Regex emailPattern = new Regex(@"(\w+)@(\w+).(\w{2,3})");
            Console.WriteLine("enter a valid email");
            var emailAddress = Console.ReadLine();

            if (emailPattern.IsMatch(emailAddress))
            {
                Console.WriteLine("Valid email.");
            }
            else
            {
                Console.WriteLine("Invalid email.");
            }
        }

        static void ValidateUserName()
        {
            Regex userName = new Regex(@"([A-Z]|[a-z])");
            Console.WriteLine("Enter a name.");
            var name = Console.ReadLine();

            if (userName.IsMatch(name))
            {
                Console.WriteLine("Valid name.");
            }
            else
            {
                Console.WriteLine("Invalid name.");
            }

        }

        static void ValidateTheDate()
        {
            Regex userDate = new Regex(@"(\d{2}/)(\d{2}/)(\d{4})");
            Console.WriteLine("Enter the date.");
            var date = Console.ReadLine();

            if (userDate.IsMatch(date))
            {
                Console.WriteLine("Valid date.");
            }
            else
            {
                Console.WriteLine("Invalid date.");
            }


        }
    }
}
