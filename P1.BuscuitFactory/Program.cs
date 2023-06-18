using System;

namespace P1.BiscuitFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double biscuitsDailyPerWorker = double.Parse(Console.ReadLine()); // worker per day 
            int workersCount = int.Parse(Console.ReadLine()); // amount of people working 
            int biscuitsGoal = int.Parse(Console.ReadLine()); // competing factory produces in 30 days
            double totalBiscuitsProduced = 0;

            for (int i = 1; i <= 30; i++) // 30 days = 1 month 
            {
                double totalBiscuitsPerDay = 0;
                if (i % 3 == 0)
                {
                    totalBiscuitsPerDay = biscuitsDailyPerWorker * workersCount;
                    totalBiscuitsPerDay = Math.Floor(totalBiscuitsPerDay * 0.75);
                }
                else
                {
                    totalBiscuitsPerDay = biscuitsDailyPerWorker * workersCount;
                }

                totalBiscuitsProduced += totalBiscuitsPerDay;
            }
            Console.WriteLine($"You have produced {totalBiscuitsProduced} biscuits for the past month.");

            if (totalBiscuitsProduced > biscuitsGoal)
            {
                Console.WriteLine($"You produce {(totalBiscuitsProduced - biscuitsGoal) / biscuitsGoal * 100:f2} percent more biscuits.");
            }
            else if (totalBiscuitsProduced < biscuitsGoal)
            {
                Console.WriteLine($"You produce {(biscuitsGoal - totalBiscuitsProduced) / biscuitsGoal * 100:f2} percent less biscuits.");
            }




        }
    }
}
