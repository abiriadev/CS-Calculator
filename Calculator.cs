using System;
using System.Collections.Generic;

namespace Calculator
{
	class Calculator
	{
		// List of operations
		public static readonly List<string> optionList = new List<string> (
			new List<String> {
				"Add",
				"Subtract",
				"Multiply",
				"Divide"
			}
		);

		// find symbol(+, -, *, /) from operation inital
		public static string findOpSymbol(string opInitalChar)
		{
			string sym = "";

			switch (opInitalChar)
			{
				case "a":
					sym = "+";
					break;
				case "s":
					sym = "-";
					break;
				case "m":
					sym = "*";
					break;
				case "d":
					sym = "/";
					break;
				default:
					throw new Exception($"unknown operation: {opInitalChar}");
			}

			return sym;
		}

		// the main login of calculator
		public static double DoOperation(double num1, double num2, string op)
		{
			double result = double.NaN;

			switch (op)
			{
				case "a":
					result = num1 + num2;
					break;

				case "s":
					result = num1 - num2;
					break;

				case "m":
					result = num1 * num2;
					break;

				case "d":
					result = num1 / num2;
					break;

				default:
					throw new Exception($"Noooo!!! I don't know '{op}' operator!!@!@!@!");
			}

			return result;
		}
	}
}