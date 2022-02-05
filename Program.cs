using System;

namespace Exercise7
{
    class Program
    {
        /* 
         * Write a program that generates a random number between 1 and 10. Ask a user
         * to guess the random number, then display the random number and a message
         * indicating whether the user's guess was too high, too low, or correct.
         * 
         * ------HINT-------
         * You can create a random number that is at least min but less than max using the following statements
         * Random randomGenerator = new Random();
         * int randomNumber = randomGenerator.Next(min,max);  1, 11
         * */
        static void Main(string[] args)
        {
            string a = "y";
            while (a == "y")
            {
                Console.WriteLine("Welcome to the guess game! :\n");
                Console.WriteLine("Please guess a number between 1 and 10: ");
                double answer = Convert.ToDouble(Console.ReadLine());

                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(1, 11); 

                if ( answer < randomNumber)
                {
                    Console.WriteLine("\nYou lost! Your guess was too low");
                    Console.WriteLine("\nYour guess was: " + answer+ "\nOur guess was: " + randomNumber);
                }
                else if (answer > randomNumber)
                {
                    Console.WriteLine("\nYou won! Your guess was too high");
                    Console.WriteLine("\nYour guess was: " + answer + "\nOur guess was: " + randomNumber);
                } else
                {
                    Console.WriteLine("\nYou tied! You had the same guess");
                    Console.WriteLine("\nYour guess was: " + answer + "\nOur guess was: " + randomNumber);
                }


                Console.WriteLine("\nDo you wanna guess again? \nPlease press y to yes and other to no");
                a = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
