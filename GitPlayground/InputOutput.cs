using System.Collections.Generic;

namespace GitPlayground
{
    static class InputOutput
    {
        public static void OutputOptions(List<string> options)
        {
            System.Console.WriteLine("Enter the number next to the option you want. Or not. Whatever.");

            foreach (var option in options)
            {
                System.Console.WriteLine(option);
            }
        }

        public static void OutputStringList(List<string> stringList)
        {
            foreach (var output in stringList)
            {
                System.Console.WriteLine(output);
            }
        }
    }
}
