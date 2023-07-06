using System;

namespace aaaah
{
    class Program
    {
        static void Main()
        {
            string FirstInput = Console.ReadLine();
            string SecondInput = Console.ReadLine();

            if (FirstInput.Length >= SecondInput.Length)
            {
                Console.WriteLine("go");
            }

            else if (SecondInput.Length > FirstInput.Length)
            {
                Console.WriteLine("no");
            }
        }
    }
}
