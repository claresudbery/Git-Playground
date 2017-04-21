using System;

namespace GitPlayground
{
    internal class OtherThingDoer
    {
        public static void Start()
        {
            System.Console.WriteLine("Let's do another thing! Enter 'Exit' to exit.");
            string input = System.Console.ReadLine();

            while (input.ToUpper() != "EXIT")
            {
                System.Console.WriteLine("Let's do another thing! Enter 'Exit' to exit.");
                input = System.Console.ReadLine();
            }

            System.Console.WriteLine("Goodbye!");
        }
    }
}