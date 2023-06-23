using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1:
            for(int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"{i}");
            }











            //Exercise 2:


                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            int num = 0;


            // Create a do-while loop and use the template below:
            do
            {
                // Increment num by 1
                num++;
                // Then add num to the collection - numbers
                numbers.Add(num);
                // Hint: reference num inside of the Add method's parentheses

            } // <---- While your variable is less than 100
            while (num < 100);


            // Create a while loop
            // <--- While num is less than 200
            while(num < 200)
            {
                // Increment num by 1
                num++;
                numbers.Add(num);
                // Then add num to the collection numbers
                //HINT: copy how this was done in the do while loop

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers
             foreach(int number in numbers)
             {
                Console.WriteLine(number);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            for(int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise













            //Exercise 3
            ExerciseThree.PrintThousand();
            ExerciseThree.PrintByThree();
            Console.WriteLine(ExerciseThree.EqualOrNot(1234, 1234));
            Console.WriteLine(ExerciseThree.EqualOrNot(1234, 1324));
            Console.WriteLine(ExerciseThree.OddOrEven(1234));
            Console.WriteLine(ExerciseThree.OddOrEven(1233));
            Console.WriteLine(ExerciseThree.Signed(-123412));
            Console.WriteLine(ExerciseThree.Signed(1234213));

            Console.WriteLine("\n\n How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine(ExerciseThree.Votable(age));

            Console.WriteLine("\n\n Give me a number");
            var someNum = Console.ReadLine();
            Console.WriteLine(ExerciseThree.CheckRange(someNum));

            ExerciseThree.MultTable(12);
            ExerciseThree.MultTable(6);
        
        
        }
    }
}
