
using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int previoushighest = 0;
            string previousName = "";
            while (previoushighest < 10)
            {
                string playerName = Console.ReadLine();
                if (playerName == "END")
                {
                    break;
                }
                int numberofGoals = int.Parse(Console.ReadLine());

                if (numberofGoals > previoushighest)
                {
                    previoushighest = numberofGoals;
                    previousName = playerName;
                }
            }

            if (previoushighest >= 3)
            {
                Console.WriteLine($"{previousName} is the best player!");
                Console.WriteLine($"He has scored {previoushighest} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{previousName} is the best player!");
                Console.WriteLine($"He has scored {previoushighest} goals.");
            }
        }
    }
}
