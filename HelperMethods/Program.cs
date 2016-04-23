using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string birthCity = Console.ReadLine();

            DisplayResult(
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(birthCity)
                );

            Console.ReadKey();

        }

        private static string ReverseString(string originalString)
        {
            char[] originalArray = originalString.ToCharArray();
            Array.Reverse(originalArray);
            return String.Concat(originalArray);
        }

        private static void DisplayResult(
            string firstString, 
            string secondString, 
            string thirdString)
        {
            Console.WriteLine(String.Format("Results: {0} {1} {2}",
                firstString,
                secondString,
                thirdString));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine(String.Format("Results: {0}", message));
        }



    }
}
