using System;
using System.Collections.Generic;
using System.Text;

namespace RunningApp.Services
{
     public class RunBasic
    {
		public void Basic()
		{
			while (true)
			{
				Console.Write("Please enter the distance of your latest run in miles to the nearest tenth mile: ");
				double runDistance = double.Parse(Console.ReadLine());
				Console.Write("Please enter the total number of minutes of your latest run (not including additional seconds beyond the last full minute): ");
				int runTimeMinutes = int.Parse(Console.ReadLine());
				Console.Write("Please enter the number of additional seconds beyond the last full minute: ");
				int runTimeSeconds = int.Parse(Console.ReadLine());

				int totalTimeInSeconds = MinutesToSeconds(runTimeMinutes) + runTimeSeconds;
				double[] timePerMile = MileAverage(totalTimeInSeconds, runDistance);


				Console.WriteLine($"You averaged {timePerMile[0]} minutes and {timePerMile[1]} seconds per mile");
			}
		}

		private double[] MileAverage(int totalTimeInSeconds, double runDistance)
		{
			double secondsPerMile = totalTimeInSeconds / runDistance;
			double minutesPerMile = totalTimeInSeconds / 60;
			double extraSecondsPerMile = totalTimeInSeconds % 60;
			double[] AverageMileTime = new double[]
				{ minutesPerMile, extraSecondsPerMile };
			return AverageMileTime;
		}

		private int MinutesToSeconds(int minutes)
		{
			return minutes * 60;
		}
	}
}
