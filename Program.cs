using System;
using System.Text.RegularExpressions;

namespace RegexExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program ");
            string FirstName;
            String namePattern;
            while(true)
            {
                namePattern = @"([A-Z]+)[a-zA-Z]{2,}";
                Console.WriteLine("Enter your First Name with First letter in Capitals ");
                FirstName = Console.ReadLine();
                Regex regex = new Regex(namePattern);
                if(regex.IsMatch(FirstName))
                {
                    Console.WriteLine("Valid First Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                }
            }
            }
        }
    }

