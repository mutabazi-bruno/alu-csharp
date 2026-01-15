using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# is an object-oriented programming language and part of the .NET family.";
		str = str.Substring(49, 35) + str.Substring(110, 4) + str.Substring(0, 2);
		Console.WriteLine(str);
	}
}
