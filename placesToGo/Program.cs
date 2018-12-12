using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace placesToGo
{
	public class Program
	{
		public static void Main()//beginning of code, asks party size + begins function.
		{
			int partySize = 0;


			Console.WriteLine("Hey!I'm here to help you decide where your party and/or you should go. \n\n" +
				"First let me ask how many people(Including you) are going?(Just type a number then hit enter)");

			try
			{
				partySize = int.Parse(Console.ReadLine());
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message + " I told you numbers only. :( " +
					"I'm sending you back to the beginning to try and fix this! \n\n");
			}

			if (partySize == 0)
			{
				Main();
			}


			if (partySize == 1)
			{
				Console.WriteLine("\n\n I believe it's best to just walk if you're already in Detroit, \n if not,  i'd advise taking an uber " +
				"then using the People Mover/Qline for transportation needs! \n Don't forget your quarters! \n\n");
			}

			else if (partySize > 1 && partySize < 5)
			{
				Console.WriteLine("\n\n With a smaller sized party like this, I'd recommend uber if you plan on drinking. \n " +
					"If one person won't drink, then I would say a compact/fuel effecient car would be the way to go! \n" +
					 "GreekTown casino has free parking occassionally. Try them out!");
			}

			else if (partySize > 5 && partySize < 41)
			{
				Console.WriteLine("\n\n This party size would call for bigger public transportation! " +
					"\n I believe a bus going to downtown Detroit would be the best bet" +
					 "If you decide to go out for food/drinks, please call ahead of time for courtesy!");
			}

			else if (partySize > 41)
			{
				Console.WriteLine("\n I think your party may be a bit too big to coordinate properly. Maybe a limo?");
			}


			Console.WriteLine("\n \n now just type in the number prior to the activity your party or you would like to partake in, then press enter!\n\n" +
				" 1. Food \n 2. Drinks \n 3. Entertainment ");

			Choices();
		}

		public static void Choices() // The choices for what this application will output 
		{
			var food = new string[] { "1", "food", "Food", "FOOD", "fOOD" };
			var drinks = new string[] { "2", "drinks", "drink", "Drinks", "Drink", "dRINKS", "dRINK" };
			var entertainment = new string[] { "3", "entertainment", "Entertainment", "Entertain", "entertain", "eNTERTAINMENT", "eNTERTAIN" };
			

			string answer = Console.ReadLine();
			Console.WriteLine("You've chosen " + answer);
			string result = answer;

			if (food.Contains(result))
			{
				Food();
			}

			else if (drinks.Contains(result))
			{
				Drink();
			}

			else if (entertainment.Contains(result))
			{
				Entertain();
			}


			else
			{
				Console.WriteLine("Sorry I'm not made to take that sort of input. Can you try again?");
				Choices();

			}


		}


		public static void Food()// if you're hungry, this will give a decent idea on what to look for w/ price ranges!
		{
			Console.WriteLine("\n I'll find some options for food in the Downtown area if you give me a spending range per person." +
				"\n\n 1. $2-5 \n 2. $5-15 \n 3. $15-35");
			var one = new string[] { "1", "one", "First", "first"};
			var two = new string[] { "2", "two", "5", "$5", "$15" };
			var three = new string[] { "3", "15", "35", "$15", "$35" };

			string answer = Console.ReadLine();

			if (one.Contains(answer))
			{
				Console.WriteLine("\n McDonald's and Burger King are great choices. \n" +
					"There's a BK and McD southeast of Campus Martius park!");

				Console.WriteLine("\n\n I hope this was helpful, goodbye!");
				Console.ReadKey();
			}

			else if (two.Contains(answer))
			{
				Console.WriteLine("\n Buffalo Wild Wings isn't a bad idea, but if you aren't from around here," +
					"\n I'd say any Coney Island!" +
					"\n There's a Coney Island in the Campus Martius area, you should check it out!");

				Console.WriteLine("\n\n I hope this was helpful, goodbye!");
				Console.ReadKey();
			}

			else if (three.Contains(answer))
			{
				Console.WriteLine("\n If you aren't from around here, you should try Blackrock out! " +
					"\n it's an awesome concept, and enjoyable! \n If you're in Detroit, you should try out Partheons.");

				Console.WriteLine("\n\n I hope this was helpful, goodbye!");
				Console.ReadKey();
			}

			else
			{
				Console.WriteLine("Didn't quite catch that, try again!");
				Food();
			}
		}


		public static void Drink()// Drinks in Detroit.
		{
			int age = 0;

			Console.WriteLine("\n This is meant for people of a certain age. " +
				"\n Please disclose your age and press enter to determine whether or not you can enter. ");
			try
			{
				age = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("\n Exact numbers only please.");

			}

			if (age == 0)
			{
				Drink();
			}

			else if (age > 0 && age < 21)
			{
				Console.WriteLine("\n You're too young to be doing this. Please don't chose this again.");
				Console.ReadKey();
				Choices();
			}

			else if (age >= 21 && age < 100)
			{
				Console.WriteLine("\n If you're in the Detroit area, I recommend Punch Bowl Social. " +
					"\n They serve you alcohol in a giant glass, and it's a fun environment to be in!" +
					 "\n Another great bar would be Sugar House. It's even good to bar hop in Detroit and try them all out!" +
					 "\n If you DO drink, please get a sober driver! DO NOT DRIVE DRUNK!");
				Console.WriteLine("\n\n I hope this was helpful, goodbye!");
				Console.ReadKey();
			}

			else if (age >= 100)
			{
				Console.WriteLine("I think someone may be lying....");
				Console.ReadKey();
				Choices();
			}
		}

		public static void Entertain() // Fun things to do around Detroit.
		{
			Console.WriteLine("\n If you're able to dedicate a whole day for entertainment I'd suggest going to Cedar Point." +
				"\n\n However it's always nice to visit local attractions! Some of the suggestions are as follows" +
				" \n\n 1.The Detroit Institute of Art, even if you aren't the artsy type, it's very fun to visit!" +
				" \n 2.Belle Isle is a beautiful little island to see! I'd recommend going there during the summer for the beach!" +
				" \n 3.Kayaking through the Detroit River can be very exciting as well!" +
				" \n 4.If you haven't been on the People mover or Qline, it can be exciting as a first time passenger." +
				" \n 5.There's festivals often in Detroit, check online for timing these events!" +
				" \n 6.If you're of age, seeing a local brewery is unique, and adds to the Michigan experience." +
				" \n 7.Jumping on the bridge to Canada could be fun as well. It's a massive difference from the states to Canada." +
				" \n 8.Seeing a good movie isn't a bad option either. 2019 has many great movies coming out!");
			Console.WriteLine("\n\n I hope this was helpful, goodbye!");
			Console.ReadKey();
			
		}
		}
	}

