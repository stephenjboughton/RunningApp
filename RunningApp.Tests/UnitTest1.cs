using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningApp.CLI;
using RunningApp.Services;

namespace RunningApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
		[DataRow(240, 1, 4, 0)]
		[DataRow(360, 1.5, 4, 0)]
		[DataRow(1620, 3, 9, 0)]
		[DataRow(3265, 6.2, 8, 46.61290322580646)]


		public void TestMileAverageCalculation(int totalSeconds, double totalMiles, double expectedMinutes, double expectedSeconds)
        {
			RunBasic run = new RunBasic();

			double averageMileMinutes = run.PerMileAverage(totalSeconds, totalMiles)[0];
			double averageMileSeconds = run.PerMileAverage(totalSeconds, totalMiles)[1];

			Assert.AreEqual(expectedMinutes, averageMileMinutes);
			Assert.AreEqual(expectedSeconds, averageMileSeconds);
        }

		[TestMethod]
		public void TestMileAverageCaluculation2()
		{
			RunBasic run = new RunBasic();

			double[] averageMile = run.PerMileAverage(360, 1.5);

			Assert.AreEqual(4, averageMile[0]);
			Assert.AreEqual(0, averageMile[1]);
		}
	}
}
