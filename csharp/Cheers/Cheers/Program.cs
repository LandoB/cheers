﻿using System;

namespace Cheers
{
	class MyMainClass
	{

		public static string daysBeforeBday(int diff)
		{
			return (diff < 0) ? (Math.Abs(diff).ToString()) : (365 - diff).ToString();
		}


		public static void Main (string[] args)
		{
			string cheering; // It will determine if we need "a" or "an"
			// We are capturing the array of characters that usually use "an" 
			// then we will compare them with the characters of the name
			// if it is one of them, then we'll use "an"
			char[] an_characters = new char[12] { 'a', 'e', 'i', 'o', 'f', 'h', 'l', 'm', 'n', 'r', 's', 'x' }; 
																	 

			// We now ask the user to type a name
			Console.Write("Please type your name: ");
			string name = Console.ReadLine();
			name = name.ToLower();

			// We ask the user for their birthday
			Console.Write("Now, type your birthday (MM/DD): ");
			string bday = Console.ReadLine();
			Console.WriteLine();

			// Let's parse string into month and day
			string[] monthDay = bday.Split('/');

			// Now we create a DateTime object for birthday
			DateTime birthday = new DateTime(DateTime.Today.Year, int.Parse(monthDay[0]), int.Parse(monthDay[1]));

			// We calculate the difference between today and next birthday
			int diff = DateTime.Today.Subtract(birthday).Days;

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

			Console.WriteLine( (diff == 0) ? "It's your birthday... Happy Birthday!!" : 
				"Your birthday is {0} days away.", daysBeforeBday(diff) );

			Console.ReadLine();
		}
	}
}



