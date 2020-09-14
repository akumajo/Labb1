using System;
using System.Text;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder addDigitsToString = new StringBuilder();
            string userInput = Console.ReadLine();
            long countSum = 0;

            for (int y = 0; y < userInput.Length - 1; y++)
            {
                if (!char.IsDigit(userInput[y]))
                {
                    continue;
                }

                addDigitsToString.Clear();
                addDigitsToString.Append(userInput[y]);

                for (int x = y + 1; x < userInput.Length; x++)
                {
                    if (!char.IsDigit(userInput[x]))
                    {
                        break;
                    }

                    addDigitsToString.Append(userInput[x]);

                    if (userInput[y] == userInput[x])
                    {
                        break;
                    }
                }

                if (addDigitsToString[0] == addDigitsToString[addDigitsToString.Length - 1] && addDigitsToString.Length > 1)
                {
                    Console.Write(userInput.Remove(y));
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(addDigitsToString);
                    Console.ResetColor();
                    Console.Write(userInput.Substring(y + addDigitsToString.Length));

                    Console.WriteLine();
                    countSum += long.Parse(addDigitsToString.ToString());
                }
            }
            Console.WriteLine($"Summan av kardemumman: {countSum}");
        }
    }
}