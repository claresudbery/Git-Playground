using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GitPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = OutputOptionsAndGetUserChoice();

                while (input != "3" && input.ToUpper() != "EXIT")
                {
                    switch (input)
                    {
                        case "1": ThingDoer.Start(); break;
                        case "2": OtherThingDoer.Start(); break;
                    }

                    System.Console.WriteLine("");
                    input = OutputOptionsAndGetUserChoice();
                }

                System.Console.WriteLine("Goodbye!");
                System.Console.WriteLine("(There will now be a pause for a few seconds to give you time to read this message)");

                Thread.Sleep(System.TimeSpan.FromSeconds(5));
            }
            catch (Exception)
            {
                System.Console.WriteLine("Either something went wrong or you decided you'd had enough.");
                System.Console.WriteLine("I'm just going to leave this screen up for a few seconds so you can read this message [drums fingers].");
                Thread.Sleep(System.TimeSpan.FromSeconds(10));
            }
        }

        private static string OutputOptionsAndGetUserChoice()
        {
            InputOutput.OutputOptions(new List<string>
                {
                    "1. Do this thing here",
                    "2. Do something completely stupid!",
                    "3. " + CatchAPony(),
                    "4. Exit",
                });

            return System.Console.ReadLine();
        }

        private static string CatchAPony()
        {
            return "Pony";
        }
    }
}
