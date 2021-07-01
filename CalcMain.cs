using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
	public class CalcMain
	{
		// main entry
		static void Main(string[] args)
		{
			// indicate stopped the main loop
			bool endApp = false;

			// declare const
			int dashLength = 24;
			string enter = "Enter";
			string number = "number";

			Console.WriteLine("Console Calculator in C#");
			Console.WriteLine(new String('-', dashLength) + '\n');

			// main loop
			while (!endApp)
			{
				double num1 = double.NaN;
				double num2 = double.NaN;

				double result = double.NaN;

				Console.WriteLine($"Type a number, and then press {enter}");

				// multiple inputs
				List<double> inputs = myIO.getNumbers(2, number);

				num1 = inputs[0];
				num2 = inputs[1];
				
				// display options
				foreach (string optionName in Calculator.optionList)
					Console.WriteLine($"\t{Utils.getInital(optionName)} - {optionName}");

				Console.Write($"What is your option?: ");

				string op = Utils.getChar();

				while (Calculator.optionList.Select(Utils.getInital).ToList().IndexOf(op) == -1)
				{
					Console.WriteLine($"unknown operation: '{op}'");
					Console.Write("please input one of above options: ");
					op = Utils.getChar();
				}

				if (op == "d")
				{
					while (num2 == 0)
					{
						Console.WriteLine($"please input the non-zero number: ");
						num2 = myIO.Input($"new ${number}2: ");
					}
				}

				try
				{
					result = Calculator.DoOperation(num1, num2, op);

					if (double.IsNaN(result))
					{
						Console.WriteLine("This operation will result in a mathematical error\n");
					}
					else
					{
						Console.WriteLine(
							"\nYour result: {0:0.##} " +
							$"({num1} {Calculator.findOpSymbol(op)} {num2})",
							result
						);
					}
				}
				catch (Exception err)
				{
					Console.WriteLine($"\nOh no! An exception occurred trying to do the math\n - Details: {err.Message}");
				}

				Console.WriteLine("\n" + new string('-', dashLength) + "\n");
				Console.Write($"Press 'n' and {enter} to close the app,\nor press any other key and Enter to continue: ");
				if (Console.ReadLine() == "n") endApp = true;

				Console.WriteLine("\n");
			}
		}
	}
}