using System;

namespace GitPlayground
{
    internal class OtherThingDoer
    {
        public static void Start()
        {
            OutputInstructions();
            string input = System.Console.ReadLine();

            while (input.ToUpper() != "BOGIES")
            {
                OutputInstructions();
                input = System.Console.ReadLine();
            }

            System.Console.WriteLine("Goodbye" + CatchAKitten());
        }

        private static string CatchAKitten()
        {
            return " Kitten.";
        }

        private static void OutputInstructions()
        {
            System.Console.WriteLine("Let's do another thing! Enter 'BOGIES' to exit.");
        }
    }
}