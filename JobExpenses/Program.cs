using System;

namespace Expenses
{
    internal class Program
    {
        static void Main()
        {
            int ArrayLength;

            ArrayLength = int.Parse(Console.ReadLine());

            if (ArrayLength == 0)
            {
                Console.WriteLine("0");
                return;
            }


            string TransactionsString = Console.ReadLine();
            string[] Transactions = TransactionsString.Split();

            int SumOfExpenses = 0;

            for (int i = 0; i < Transactions.Length; i++)
            {
                if ((int.Parse(Transactions[i])) < 0)
                {
                    SumOfExpenses += int.Parse(Transactions[i]);
                }
            }

            if (SumOfExpenses != 0)
            {
                int SumOfExpensesAsPositiveValue = SumOfExpenses * -1;

                Console.WriteLine(SumOfExpensesAsPositiveValue);
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

