using System;

namespace LifeYear
{
    class Program
    {
        static void Main()
        {
            int NumberOfInputs = int.Parse(Console.ReadLine());

            float output = 0;

            for (int i = 0; i < NumberOfInputs; i++)
            {
                string LineOfInput = Console.ReadLine();
                string[] inputStrings = LineOfInput.Split();

                float QualityOfLife = float.Parse(inputStrings[0]);
                float NumberOfYears = float.Parse(inputStrings[1]);

                float result = QualityOfLife * NumberOfYears;

                output += result;
            }

            Console.WriteLine(output);

        }
    }
}

