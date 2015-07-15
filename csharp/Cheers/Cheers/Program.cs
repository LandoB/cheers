using System;

namespace Cheers
{
	class MyMainClass
	{
		public static void Main (string[] args)
		{
			// Prompt user to type a name
			Console.Write("Please enter your name: ");
			string input = Console.ReadLine();
			input = input.ToLower();


			// print out the cheer
			// for each character in the name

			for (int i = 0; i < input.Length; i++)
			{
				Console.WriteLine("Give me a..{0}", input[i]);
			}

			// print out final line with name in uppercase
			Console.WriteLine("{0} is.. GRANDIOSO!!!", input.ToUpper());

			Console.ReadLine();
		}
	}
}



