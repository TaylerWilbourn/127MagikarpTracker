using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _127Magikarps
{
	class MagikarpTracker
	{
		string maleNature = "";
		string femaleNature = "";
		string data = "";

		public void Intro()
		{
			Console.WriteLine("Ensure your magikarp both have Everstones and are different natures.");
			bool sure = false;

			while (!sure)
			{
				Console.WriteLine("Type the male magikarp's nature, then press enter.");
				maleNature = Console.ReadLine();
				Console.WriteLine("Type the female magikarp's nature, then press enter.");
				femaleNature = Console.ReadLine();

				Console.WriteLine("The male's nature is: " + maleNature);
				Console.WriteLine("The female's nature is: " + femaleNature);
				Console.WriteLine("Are you sure? y/n");

				string sureCheck = Console.ReadLine().ToLower();
				if (sureCheck == "y")
				{
					sure = true;
				}
				else
				{
					sure = false;
					Console.WriteLine("Try again:");
				}
			}

			Console.WriteLine("Deposit them into the nursery and run around until there is an egg ready to pick up.");
			Console.WriteLine("Press any key to continue after each step.");
			Console.ReadKey();
			MainLoop();
		}

		private void MainLoop()
		{
			//Main Loop
			for (int i = 0; i < 127; i++)
			{
				//Save the game BEFORE picking up the egg.
				Console.WriteLine("Save the game BEFORE picking up the egg.");
				Console.ReadKey();
				//Accept the egg and hatch it.
				Console.WriteLine("Accept the egg and hatch it.");
				Console.ReadKey();
				//Check its nature and compare to the parents' natures.
				DataPrompt();
				Console.WriteLine("Entry #" + (i + 1).ToString() + " successfully recorded.");

				//Soft reset the game with L +R + Start to when the egg was ready to be picked up.
				Console.WriteLine("Soft reset the game with L+R+Start.");
				Console.ReadKey();
				//Reject the egg.
				Console.WriteLine("Reject the egg");
				Console.ReadKey();
				//Repeat from #2 in this section (run around until egg is ready to pick up) until you have 127 0 or 1 noted down in order.
				Console.WriteLine("Run around until there is an egg ready to pick up.");
				Console.ReadKey();
			}

			Outro();
		}


		private void DataPrompt()
		{
			string inputString = "";
			bool inputIsValid = false;
			while (!inputIsValid)
			{
				Console.WriteLine("Is the hatched pokemon " + maleNature + "(0) or " + femaleNature + "(1)?");
				Console.WriteLine("Enter 0 or 1.");
				inputString = Console.ReadLine();
				if (inputString == "0" || inputString == "1")
				{
					inputIsValid = true;
				}
				else
				{
					inputIsValid = false;
					Console.WriteLine("Invalid input. Try again:");
				}
			}

			data += inputString;
		}

		private void Outro()
		{
			SaveFile();
			Console.WriteLine("All data successfully recorded!");
			Console.WriteLine("Press any key to save and exit.");
			Console.ReadKey();
		}

		private void SaveFile()
		{
			System.IO.File.WriteAllText("MagikarpData.txt", data);
		}
	}
}
