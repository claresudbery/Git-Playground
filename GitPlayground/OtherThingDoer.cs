using System;

namespace GitPlayground
{
    internal class OtherThingDoer
    {
        public static void Start()
        {
            System.Console.WriteLine("Let's do another thing! Enter 'Exit' to exit.");
            string input = System.Console.ReadLine();

            while (input.ToUpper() != "BOGIES")
            {
                System.Console.WriteLine("Let's do another thing! Enter 'Exit' to exit.");
                input = System.Console.ReadLine();
            }

            System.Console.WriteLine("Goodbye" + CatchAKitten());
        }

        private static string CatchAKitten()
        {
            return " Kitten.";
        }

        private static string CatchACrab()
        {
            return " Crab.";
        }

        public static string FindAMollusc()
        {
            return " Limpet.";
        }
    }
}
