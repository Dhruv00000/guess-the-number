// The default code.
using System;

namespace guess_the_number {

    class Program {

        static void Main(string[] args) {

            try {

                // Initializing the random class.
                Random rnd = new Random();

                // Getting the user input.
                Console.Write("Enter the starting number of the range from which the number will be randomly selected: ");
                string start = Console.ReadLine();
                int Start = int.Parse(start);

                Console.Write("Enter the ending number of the range from which the number will be randomly selected: ");
                string end = Console.ReadLine();
                int End = int.Parse(end);

                Console.Write("Enter the number of attempts to guess the number: ");
                string attempts = Console.ReadLine();
                int Attempts = int.Parse(attempts);

                // Asking the user for their guess until they either win or run out of attempts.
                if (Attempts < End - Start) {

                    int num = rnd.Next(Start, (End + 1));
                    int fails = 0;
                    int i = 0;

                    while (i < Attempts) {

                        Console.Write("Enter your guess: ");
                        string guess = Console.ReadLine();
                        int Guess = int.Parse(guess);

                        if (Guess == num) {

                            Console.WriteLine("You guessed the number correctly");
                            break;

                        } else fails++;

                        i++;

                    }

                    if (fails == Attempts) Console.WriteLine("You were not able to guess the number correctly.");

                }

                else Console.WriteLine("Number of attempts mut be smaller than the possible number of outcomes.");

            // If the yser enters a string instead of an integer, this message is printed out instead of the program crashing with an error.
            } catch (FormatException) {
            
                Console.WriteLine("Please enter a valid value.");
            
            }

            // Stopping the program from exitting instantly.
            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}