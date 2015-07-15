using System;

namespace Cheers
{
	class MyMainClass
	{
		public static void Main (string[] args)
		{
			string cheering; // It will determine if we need "a" or "an"
			char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' }; // We are capturing the array of vowels to compare with the characters of the name
																	 // if it is a vowel, then we'll use "an"

			// Ask the user to type a name
			Console.Write("Please enter your name: ");
			string input = Console.ReadLine();
			input = input.ToLower();

			// Then, print out the cheering
			// for each character in the name
			// And we also compare it with our array of vowels
			// to see if we need "a" or "an" 
			// then print out the line for the appropriate cheering

			for (int i = 0; i < input.Length; i++)
			{
				// Check to see if the character is a vowel or not
				cheering = Array.IndexOf(vowels, input[i]) < 0 ? "a" : "an";
				Console.WriteLine("Give me {0}..{1}", cheering, input[i]);
			}

			// Finally, print out the line with name in all uppercase
			Console.WriteLine("{0} is.. GRANDIOSO!!!", input.ToUpper());

			Console.ReadLine();
		}
	}
}



