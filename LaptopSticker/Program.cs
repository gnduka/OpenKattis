using System;

namespace Laptop
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string[] inputArray = inputString.Split();

            int ComputerWidth = int.Parse(inputArray[0]);
            int ComputerHeight = int.Parse(inputArray[1]);
            int StickerWidth = int.Parse(inputArray[2]);
            int StickerHeight = int.Parse(inputArray[3]);

            if (StickerWidth + 1 < ComputerWidth)
            {
                if (StickerHeight + 1 < ComputerHeight)
                {
                    Console.WriteLine("1");
                }

                else
                {
                    Console.WriteLine("0");
                }
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
