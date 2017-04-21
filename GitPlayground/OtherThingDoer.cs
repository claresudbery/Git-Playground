using System;

namespace GitPlayground
{
    internal class OtherThingDoer
    {
        public static void Start()
        {
            OutputInstructions();
            string input = System.Console.ReadLine();

            while (input.ToUpper() != "EXIT")
            {
                OutputInstructions();
                input = System.Console.ReadLine();
            }

            System.Console.WriteLine("Goodbye!");
        }

        private static void OutputInstructions()
        {
            System.Console.WriteLine("Let's do another thing! Enter 'Exit' to exit.");
        }
    }
}