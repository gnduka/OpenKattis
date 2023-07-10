using System;

namespace Sum
{
    class Program
    {
        static void Main()
        {
            int NumberofIntegers = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();

            string[] inputs = inputString.Split();
            int output = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                output += int.Parse(inputs[i]);
            }
            Console.WriteLine(output);
        }
    }
}

