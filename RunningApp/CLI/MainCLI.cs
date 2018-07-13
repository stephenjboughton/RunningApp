using System;
using System.Collections.Generic;
using System.Text;
using RunningApp.Services;

namespace RunningApp.CLI
{
    public class MainCLI
    {
		public void Menu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Please choose one of the following options: ");
				Console.WriteLine("[1] Compute the per mile average time for your most recent run");
				Console.WriteLine("[2] Determine the per mile average time you will need to hit your goal time for a specific race");
				Console.WriteLine("[Q] Quit");
				string mainMenuOption = Console.ReadLine();

				switch (mainMenuOption)
				{
					case "1":
						{
							RunBasic runbasic = new RunBasic();
							runbasic.Basic();
							break;
						}
					case "2":
						{
							RaceGoal racegoal = new RaceGoal();
							racegoal.ReachGoal();
							break;
						}
					case "Q":
						{
							return;
						}
				}


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
