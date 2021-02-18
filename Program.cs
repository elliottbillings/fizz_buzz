using System;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // 18022021 - fizz buzz excercise V0.001

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

            int number = 101;
            const int fizz = 3, buzz = 5, fizz_buzz = 15;

            Console.WriteLine("Fizz Buzz!");

            for (int i = 1; i < number; i++ )
            {
                if (i%fizz == 0)
                {
                    if(i % fizz_buzz == 0)
                    {
                        Console.WriteLine(i + " = fizz_buzz");
                        continue;
                    }
                    Console.WriteLine(i +" = fizz");
                }
                else if(i%buzz == 0)
                {
                    if (i % fizz_buzz == 0)
                    {
                        Console.WriteLine(i + " = fizz_buzz");
                        continue;
                    }
                    Console.WriteLine(i +" = buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
