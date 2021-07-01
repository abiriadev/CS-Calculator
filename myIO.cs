using System;
using System.Collections.Generic;

namespace Calculator
{
	// custom I/O class
	public class myIO
	{
		// get multiple inputs
		public static List<double> getNumbers(int howmany, string msg = "input")
		{
			List<double> inputs = new List<double>();

			for (int i = 1; i <= howmany; i++)
			{
				inputs.Add(
					myIO.Input($"{msg}{i}: ")
				);
			}

			return inputs;
		}

		// input() method like python's
		public static double Input(string message)
		{
			string input = "";
			double clean = double.NaN;

			while (true)
			{
				Console.Write(message);
				input = Console.ReadLine();

				if (!double.TryParse(input, out clean))
				{
					Console.WriteLine($"'{input}' is not valid input. Please enter an integer value:");
				}
				else
					break;
			}
			
			return clean;
		}
	}
}