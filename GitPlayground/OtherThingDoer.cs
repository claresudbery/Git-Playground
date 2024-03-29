using System;

namespace GitPlayground
{
    internal class OtherThingDoer
    {
        const int NumMolluscsFound = 0;

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
            NumMolluscsFound++;
            return " Mollusc.";
        }
            
        public static void Start()
        {
            NumMolluscsFound = 0;
            
            System.Console.WriteLine("Let's do another thing! Enter 'Exit' to exit.");
            string input = System.Console.ReadLine();

            while (input.ToUpper() != "BOGIES")
            {
                System.Console.WriteLine("Let's do another thing! Enter 'Exit' to exit.");
                input = System.Console.ReadLine();
            }

            System.Console.WriteLine("Goodbye" + CatchAKitten());
        }
    }
}
