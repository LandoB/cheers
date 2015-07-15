using System;

namespace Cheers
{
	class MyMainClass
	{
		public static void Main (string[] args)
		{
			string cheering; // It will determine if we need "a" or "an"
			// We are capturing the array of characters that usually use "an" 
			// then we will compare them with the characters of the name
			// if it is one of them, then we'll use "an"
			char[] an_characters = new char[13] { 'a', 'e', 'i', 'o', 'u', 'f', 'h', 'l', 'm', 'n', 'r', 's', 'x' }; 
																	 

			// We now ask the user to type a name
			Console.Write("Please type your name: ");
			string name = Console.ReadLine();
			name = name.ToLower();

			// Then, print out the cheering
			// for each character in the name
			// And we also compare it with our array of "an" characters
			// to see if we need "a" or "an" 
			// then print out the line for the appropriate cheering

			for (int i = 0; i < name.Length; i++)
			{
				// Check to see if the character is a "an" character or not
				cheering = Array.IndexOf(an_characters, name[i]) < 0 ? "a" : "an";
				Console.WriteLine("Give me {0}..{1}", cheering, name[i]);
			}

			// Finally, print out the line with name in all uppercase
			Console.WriteLine("{0} is.. GRANDIOSO!!!", name.ToUpper());

			Console.ReadLine();
		}
	}
}



