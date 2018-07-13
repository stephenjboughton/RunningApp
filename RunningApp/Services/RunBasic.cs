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
				Console.WriteLine();
				Console.Write("Please enter the distance of your latest run in miles to the nearest tenth mile: ");
				double runDistance = double.Parse(Console.ReadLine());
				Console.Write("Please enter the total number of minutes of your latest run (not including additional seconds beyond the last full minute): ");
				int runTimeMinutes = int.Parse(Console.ReadLine());
				Console.Write("Please enter the number of additional seconds beyond the last full minute: ");
				int runTimeSeconds = int.Parse(Console.ReadLine());

				int totalTimeInSeconds = MinutesToSeconds(runTimeMinutes, runTimeSeconds);
				int[] timePerMile = PerMileAverage(totalTimeInSeconds, runDistance);

				Console.WriteLine($"You averaged {timePerMile[0]} minutes and {timePerMile[1]} seconds per mile");
				Console.WriteLine();
				Console.WriteLine("Press [R] to return to the main menu or press any other key to calculate the pace for another run");
				string loopChoice = Console.ReadLine();

				if (loopChoice == "R")
				{
					break;
				}
			}
		}

		public int[] PerMileAverage(int totalTimeInSeconds, double runDistance)
		{
			int secondsPerMile = (int)Math.Floor(totalTimeInSeconds / runDistance);
			int minutesPerMile = secondsPerMile / 60;
			int extraSecondsPerMile = secondsPerMile % 60;
			int[] AverageMileTime = new int[]
				{ minutesPerMile, extraSecondsPerMile };
			return AverageMileTime;
		}

		public int MinutesToSeconds(int minutes, int seconds)
		{
			return minutes * 60 + seconds;
		}
	}
}
