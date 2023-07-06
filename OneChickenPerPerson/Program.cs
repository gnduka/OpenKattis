using System;

namespace OneChickenPerPerson
{
    class Program
    {
        static void Main()
        {
            string stringInput = Console.ReadLine();
            string[] inputs = stringInput.Split();

            int PeopleCount = int.Parse(inputs[0]);
            int ChickenCount = int.Parse(inputs[1]);




            if (PeopleCount < ChickenCount)
            {
                if (ChickenCount - PeopleCount != 1)
                {
                    Console.WriteLine($"Dr. Chaz will have {ChickenCount - PeopleCount} pieces of chicken left over!");
                }

                else
                {
                    Console.WriteLine($"Dr. Chaz will have {ChickenCount - PeopleCount} piece of chicken left over!");
                }
                
            }

            else if (ChickenCount < PeopleCount)
            {
                if (PeopleCount - ChickenCount != 1)
                {
                    Console.WriteLine($"Dr. Chaz needs {PeopleCount - ChickenCount} more pieces of chicken!");
                }

                else
                {
                    Console.WriteLine($"Dr. Chaz needs {PeopleCount - ChickenCount} more piece of chicken!");
                }
                
            }
        }
    }
}

