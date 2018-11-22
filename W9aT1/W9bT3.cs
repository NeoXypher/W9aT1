using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9aT1
{
	class W9bT3
	{
		public static void Main()
		{
			string NewEntry = "7145";
			char[] Digits = NewEntry.ToCharArray();
			int Height = Digits.Length;
			for (int rows = 0; rows < Height; rows++)
			{
				Console.Write(Digits[0]);
				for (int i = 0; i < Digits.Length - 1; i++)
				{
					if (Digits[i] > Digits[i + 1])
						Digits[i] = Convert.ToChar(Convert.ToString(Convert.ToInt32(Convert.ToString(Digits[i])) - Convert.ToInt32(Convert.ToString(Digits[i + 1]))));
					else
						Digits[i] = Convert.ToChar(Convert.ToString(Convert.ToInt32(Convert.ToString(Digits[i + 1])) - Convert.ToInt32(Convert.ToString(Digits[i]))));
					Console.Write(Digits[i + 1]);
				}
				Console.WriteLine();
				for (int i = 0; i < rows + 1; i++)
				{
					Console.Write(" ");
				}
				
			}
			Console.ReadLine();
		}
	}
}
