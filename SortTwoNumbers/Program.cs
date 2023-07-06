using System;

namespace SortTwoNumbers
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string[] inputs = inputString.Split(' ');

            if (int.Parse(inputs[0]) < int.Parse(inputs[1]))
            {
                Console.WriteLine(inputs[0] + " " + inputs[1]);
            }

            else
            {
                Console.WriteLine(inputs[1] + " " + inputs[0]);
            }
        }
    }
}

