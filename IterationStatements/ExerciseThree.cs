using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class ExerciseThree
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for(int i = 1000; i >= -1000;  i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThree() 
        {
            for(int i = 3; i <= 999; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool EqualOrNot(int a, int b)
        {
            return a == b;
        }
        //Write a method to check whether a given number is even or odd
        public static string OddOrEven(int a)
        { 
            if(a%2 == 0)
            {
                return "even";
            }
            else 
            {
                return "odd";
            }
        }
        //Write a method to check whether a given number is positive or negative

        public static string Signed(int a)
        {
            if (a >= 0)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()


        //precondition: takes in an input from Console.ReadLine();
        public static string Votable(string str) 
        {
            int numStr = (int.TryParse(str, out int num)) ? num : 0;
            if(numStr < 18)
            {
                return "cannot vote";
            }
            else 
            {
                return "can vote";
            }
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static bool CheckRange(string str)
        {
            int numStr = (int.TryParse(str, out int num)) ? num : 0;
            if (numStr <= 10 && numStr >= -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable(int a)
        { 
            for(int i = 1; i <= a; i++)
            {
                for(int j = 1; j <= a; j++)
                {
                    Console.Write(j * i + " ");
                }

                Console.WriteLine("");
            }
        }

        //Call the methods to test them in the Main method below
    }
}
