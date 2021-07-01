using System;

public class Utils
{
	// get first letter
	public static string getInitial(string str)
	{
		return str[0].ToString().ToLower();
	}

	// input lower char
	public static string getChar()
	{
		return Console.ReadLine().ToLower();
	}
}
