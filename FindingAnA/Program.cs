using System;

namespace A
{
    class Program
    {
        public static string inputString;

        static void Main()
        {
            inputString = Console.ReadLine();
            int counter = 0;

            foreach (char c in inputString)
            {
                if (c != 'a')
                {
                    counter++;
                    continue;
                }

                else
                {
                    Display(counter);
                    return;
                }
            }
        }

        static void Display(int startingPoint)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (startingPoint < inputString.Length)
                {
                    Console.Write(inputString[startingPoint]);
                    startingPoint++;
                }

                else
                {
                    return;
                }
            }
        }
    }
}

