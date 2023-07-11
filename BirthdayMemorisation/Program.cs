using System;

namespace Birthday
{
    public interface IPerson
    {
        string Name();
        int Preference();
        int BirthdayDay();
        int BirthdayMonth();
    }

    public class Program
    {

        static void Main()
        {
            int NumberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfInputs; i++)
            {
                string inputString = Console.ReadLine();
                string[] inputInfo = inputString.Split(' ', '/');

            }
        }

        class Birthdays
        {

        }
    }

    public class BirthdayMemorisation : IPerson
    {
        string 
    }
}

