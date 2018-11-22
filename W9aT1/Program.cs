using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9aT1
{
	class Program
	{
		static void Main2(string[] args)
		{
			int Wins = 0, Draws = 0, Defeats = 0, Scored = 0, Conceded = 0, Points = 0;
			string results = "Manchester United 1 Chelsea 0, Arsenal 1 Manchester United 1, Manchester United 3 Fulham 1, Liverpool 2 Manchester United 1, Swansea 2 Manchester United 4";
			string[] matches = results.Split(',');
			for (int i = 0; i < 5; i++)
			{
				string[] match = matches[i].Split(' ');
				if (match[i] == "Manchester" && match[i+1] == "United")
				{
					Scored += Convert.ToInt32(match[i + 2]);
					switch (i)
					{
						case 0:
							Conceded += Convert.ToInt32(match[i + 4]);
							break;
						case 2:
							Conceded += Convert.ToInt32(match[i - 1]);
							break;
						default:
							break;
					}

					if ((i == 2 && Convert.ToInt32(match[i + 2]) > Convert.ToInt32(match[i - 1])) || (i == 0 && Convert.ToInt32(match[i + 2]) > Convert.ToInt32(match[i + 4])))
						Wins++;
					else if ((i == 2 && Convert.ToInt32(match[i + 2]) == Convert.ToInt32(match[i - 1])) || (i == 0 && Convert.ToInt32(match[i + 2]) == Convert.ToInt32(match[i + 4])))
						Draws++;
					else
						Defeats++;   
				}
			}
			Points = Wins * 3 + Draws * 1;
			Console.WriteLine("Number of wins = {0}, Number of draws = {1}, Number of defeats = {2}, Goals scored = {3}, Goals Conceded = {4}, Number of points = {5}", Wins, Draws, Defeats, Scored, Conceded, Points);
			Console.ReadLine();
		}
	}
}
