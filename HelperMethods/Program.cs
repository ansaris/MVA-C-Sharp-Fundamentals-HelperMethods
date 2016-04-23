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

            //Console.WriteLine();
            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            //Console.WriteLine();
            Console.Write("In what city were you born? ");
            string birthCity = Console.ReadLine();
            /*
            char[] firstNameArray = firstName.ToCharArray();
            char[] lastNameArray = lastName.ToCharArray();
            char[] birthCityArray = birthCity.ToCharArray();

            Array.Reverse(firstNameArray);
            Array.Reverse(lastNameArray);
            Array.Reverse(birthCityArray);
            */
            /*
            string firstNameReversed = new string(firstNameArray);
            string lastNameReversed = new string(lastNameArray);
            string birthCityReversed = new string(birthCityArray);

            Console.WriteLine(firstNameArray);
            Console.WriteLine("Results: {0} {1} {2}", firstNameReversed, lastNameReversed, birthCityReversed);
            //Console.WriteLine(birthCityArray.Reverse() + " " 
            //+ lastNameArray.Reverse() + " " + firstNameArray.Reverse());
            */
            /*
            string result = String.Format("{0} {1} {2}", 
                ReverseString(firstName), ReverseString(lastName), ReverseString(birthCity));
                */
            /*
            string firstNameReversed = ReverseString(firstName);
            string lastNameReversed = ReverseString(lastName);
            string birthCityReversed = ReverseString(birthCity);
            */
            DisplayResult(
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(birthCity)
                );

            DisplayResult(ReverseString(firstName) + " " 
                + ReverseString(lastName) + " " 
                + ReverseString(birthCity));
            /*
            foreach (char character in firstNameArray)
            {
                result += character;
            }

            result += " ";

            foreach (char character in lastNameArray)
            {
                result += character;
            }

            result += " ";

            foreach (char character in birthCityArray)
            {
                result += character;
            }
            */
            //Console.WriteLine("Results: {0}", result);

            Console.ReadKey();

        }

        private static string ReverseString(string originalString)
        {
            char[] originalArray = originalString.ToCharArray();
            Array.Reverse(originalArray);
            // string reversedString = new string(originalArray);
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
