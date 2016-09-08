using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_8_Batting_Average;

namespace Lab_8_BattingTest
{
    [TestClass]
    public class AverageTests
    {
        [TestMethod]
        public void TestBattingPerecentageIs0WhenNoRuns()

          

        {
         int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;

           double average = Program.CalculateBattingAverage(battingSheet);

            Assert.AreEqual(0, average);


        }

        [TestMethod]
        public void TestBattingPercentageIs60()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;

          double average = Program.CalculateBattingAverage(battingSheet);
          Assert.AreEqual(0.6, average);

        }

        [TestMethod]
        public void TestSluggingPercentageis0()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;

            double average = Program.CalculateSluggingPercentage(battingSheet);
            Assert.AreEqual(0, average);
        }

        [TestMethod]
        public void TestSluggingPercentageis60()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 1;
            battingSheet[2] = 1;
            battingSheet[3] = 1;
            battingSheet[4] = 0;

            double average = Program.CalculateSluggingPercentage(battingSheet);
            Assert.AreEqual(60, average);
        }


    }
}
