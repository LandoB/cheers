using System;

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
			string an_characters = "halfnorsemix";
																	 

			// We now ask the user to type a name
			Console.Write ("Please type your name: ");
			string name = Console.ReadLine ();
			name = name.ToLower ();

			// We ask the user for their birthday
			Console.Write ("Now, type your birthday (MM/DD): ");
			string bday = Console.ReadLine ();
			Console.WriteLine ();

			// Let's parse string into month and day
			string[] monthDay = bday.Split ('/');

			// Now we create a DateTime object for birthday
			DateTime birthday = new DateTime (DateTime.Today.Year, int.Parse (monthDay [0]), int.Parse (monthDay [1]));

			// We calculate the difference between today and next birthday
			int diff = DateTime.Today.Subtract (birthday).Days;


			// Then, print out the cheering
			// for each character in the name
			// And we also compare it with our array of "an" characters
			// to see if we need "a" or "an" 
			// then print out the line for the appropriate cheering

			foreach (var letter in name) {
				// Check to see if the character is a "an" character or not
				cheering = an_characters.IndexOf (letter) < 0 ? "a" : "an";
				Console.WriteLine ("Give me {0}..{1}", cheering, letter);
			}

			Console.WriteLine (); // I just need a blank space here

			// Finally, print out the line with name in all uppercase
			Console.WriteLine ("{0} is.. GRANDIOSO!!!", name.ToUpper ());
			Console.WriteLine (); // I just need a blank space here

			if (diff > 300) {
				Console.WriteLine ("I'm sorry we missed your birthday!");
			} else {
				if (diff == 0) {
					Console.WriteLine ("It's your birthday... Happy Birthday!!");
				} else {
				}
					Console.WriteLine ("Your birthday is {0} days away.", daysBeforeBday (diff));
				}
			}
			//Console.ReadLine();
		}
	}




