using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Batting_Average
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Batting Average Calculcator!");

            string anotherBatterAnswer = "y";
            do
            {
                Console.WriteLine("Enter number of times at bat: ");
                string userInputNumberOfTimes = Console.ReadLine();

                int userInput = int.Parse(userInputNumberOfTimes);

                int[] battingSheet = new int[userInput];
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");

                for (int i = 0; i < userInput; i++)
                {
                    Console.WriteLine($"Result for at-bat {i}: ");
                    string resultAtBat1 = Console.ReadLine();
                    int resultAtBat = int.Parse(resultAtBat1);
                    battingSheet[i] = resultAtBat;
                }

                Console.WriteLine("Batting average: " + Program.CalculateBattingAverage(battingSheet));
                Console.WriteLine("Slugging Percentage: " + Program.CalculateSluggingPercentage(battingSheet) + "%");

                Console.WriteLine("Another batter? (y/n)");
                anotherBatterAnswer = Console.ReadLine();
            }

            while (anotherBatterAnswer == "y");

        }

        public static double CalculateBattingAverage(int[] battingSheet)
        {
            int numoftimesatleast1base = 0;
            for (int i = 0; i < battingSheet.Length; i++)
            {
                double basesEarned = battingSheet[i];
                if (basesEarned > 0)
                {
                    numoftimesatleast1base++;
                }
            }

            double battingAverage = (double)numoftimesatleast1base / battingSheet.Length;
            return battingAverage;
        }




        public static double CalculateSluggingPercentage(int[] battingSheet)

        {
            int totalbasesHit = 0;
            for (int i = 0; i < battingSheet.Length; i++)
            {
                 totalbasesHit = totalbasesHit + battingSheet[i];
            }


            double sluggingpercentage = ((double) totalbasesHit / battingSheet.Length) * 100;
            return sluggingpercentage;
        }


    }
}


