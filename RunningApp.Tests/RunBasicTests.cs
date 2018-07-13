using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningApp.CLI;
using RunningApp.Services;

namespace RunningApp.Tests
{
    [TestClass]
    public class RunBasicTests
    {
        [DataTestMethod]
		[DataRow(240, 1, 4, 0)]
		[DataRow(360, 1.5, 4, 0)]
		[DataRow(1620, 3, 9, 0)]
		[DataRow(3265, 6.2, 8, 46)]
		[DataRow(1545, 3.1, 8, 18)]


		public void TestMileAverageCalculation(int totalSeconds, double totalMiles, double expectedMinutes, double expectedSeconds)
        {
			RunBasic run = new RunBasic();

			double averageMileMinutes = run.PerMileAverage(totalSeconds, totalMiles)[0];
			double averageMileSeconds = run.PerMileAverage(totalSeconds, totalMiles)[1];

			Assert.AreEqual(expectedMinutes, averageMileMinutes);
			Assert.AreEqual(expectedSeconds, averageMileSeconds);
        }

		[DataTestMethod]
		[DataRow(1, 0, 60)]
		[DataRow(1, 30, 90)]
		[DataRow(7, 19, 439)]
		[DataRow(36, 54, 2214)]
		[DataRow(0, 42, 42)]
		public void TestMinutesToSecondsCalculation(int minutes, int seconds, int expectedTotalSeconds)
		{
			RunBasic run = new RunBasic();

			int totalSeconds = run.MinutesToSeconds(minutes, seconds);

			Assert.AreEqual(expectedTotalSeconds, totalSeconds);
		}
	}
}
