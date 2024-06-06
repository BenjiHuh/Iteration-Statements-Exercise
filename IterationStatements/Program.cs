using System.Runtime;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            thousands();
            threes();
            isEqual(5, 6);
            isEqual(6, 6);
            isEven(5);
            isEven(6);
            isPositive(5);
            isPositive(-6);
            isPositive(0);
            canVote(5);
            canVote(39);
            betweenTens(5);
            betweenTens(-29);
            multiplicationTable();

        }

        private static void thousands()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static void isEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("the two numbers are equal.");
            }
        }
        private static void isEven(int num)
        {
            Console.WriteLine((num % 2 == 0) ? "the number is even" : "the number is odd");
        }

        private static void isPositive(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            } 
            else if (num > 0) {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is nonnegative");
            }
        }

        private static void canVote(int num)
        {
            Console.WriteLine((num >= 18) ? $"a person age {num} can vote" : $"a person age {num} cannot vote");
        }

        private static void betweenTens(int num)
        {
            Console.WriteLine((num >= -10 && num <= 10) ? $"{num} is within the range [-10, 10]" : $"{num} is not within the range [-10, 10]");
        }

        private static void multiplicationTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    int numLength = (j * i).ToString().Length;
                    switch (numLength)
                    {
                        case 1:
                            Console.Write($"{j * i}   ");
                            break;
                        case 2:
                            Console.Write($"{j * i}  ");
                            break;
                        case 3:
                            Console.Write($"{j * i} ");
                            break;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
