using System;

// 18022021 - fizz buzz excercise V0.002

//Fizz Buzz wiki definition
//Players generally sit in a circle. The player designated to go first says the number "1",
//and the players then count upwards in turn. However, 
//any number divisible by three is replaced by the word 
//fizz and any number divisible by five by the word buzz. 
//Numbers divisible by 15 become fizz buzz.

//div by 3 = fizz
//div by 5 = buzz
//div by 15 = fizz buzz

//run a loop through 1 to 100 range and return the appropriate fizzbuzz numbers.

//================

namespace fizz_buzz
{
    class Program
    {
        //global vars
        public const int fizz = 3, buzz = 5, fizz_buzz = 15;

        static bool FizzBuzz_15_check(int i)
        {
            if (i % fizz_buzz == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } //check if divisible by 15

        static void FizzBuzz_Main(int input)
        {
            for (int i = 1; i < input; i++)
            {
                if (i % fizz == 0)
                {
                    if (FizzBuzz_15_check(i) == true)
                    {
                        Console.WriteLine(i + " = fizz buzz");
                        continue;
                    }
                    Console.WriteLine(i + " = fizz");
                }
                else if (i % buzz == 0)
                {
                    if (FizzBuzz_15_check(i) == true)
                    {
                        Console.WriteLine(i + " = fizz buzz");
                        continue;
                    }
                    Console.WriteLine(i + " = buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        } //main fizzbuzz block

        static int FizzBuzz_Input_Validation(int i)
        {
            bool input_valid = false;

            while (input_valid == false)
            {
                Console.WriteLine("Enter number range: ");

                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    
                    if (i == 0 || i < 0)
                    {
                        Console.WriteLine("Error: Range value must be greater that 0");
                        continue;
                    }

                    input_valid = true;
                }
                catch
                {
                    Console.WriteLine("Error: Invalid input, enter a positive whole number");
                }
            }
            return i;
        } //fizzbuzz range input validation

        static bool Exit_check(string s)
        {
            bool input_valid = false;

            while (input_valid == false)
            {
                Console.WriteLine("Run again? y/n: ");
                try
                {
                    s = Console.ReadLine();
                    if (s == "y")
                    {
                        return true;
                    }
                    else if (s == "n")
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid input, enter 'y' or 'n' ");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Invalid input, enter 'y' or 'n' ");
                    continue;
                }
            }
            return true;

        }

        static void Main(string[] args)
        {
            int number = 0;
            bool quit = false;
            string quit_input = "";

            Console.WriteLine("Welcome to Fizz Buzz!");

            while (quit == false)
                {
                    number = FizzBuzz_Input_Validation(number);
                    FizzBuzz_Main(number);

                    if (Exit_check(quit_input) == false)
                    {
                        quit = true;                    
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            Console.WriteLine("Program Exit on Input");
            Console.ReadLine();
        }
    }
}
