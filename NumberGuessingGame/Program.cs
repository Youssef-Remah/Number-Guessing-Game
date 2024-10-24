namespace NumberGuessingGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool continuePlaying = true;

			while (continuePlaying)
			{

				Console.WriteLine("Welcome to the Number Guessing Game!\n");

				Console.WriteLine("I'm thinking of a number between 1 and 100.\n");

				Console.WriteLine("You have 5 chances to guess the correct number.\n");


				Console.WriteLine("Please select the difficulty level:\n");

				Console.WriteLine("1. Easy (10 chances)\n2. Medium (5 chances)\n3. Hard (3 chances)\n");

				Console.Write("Enter your choice: ");

				bool res = int.TryParse(Console.ReadLine(), out int choice);

				if (res && choice >= 1 && choice <= 3)
				{
					Dictionary<int, int> levels = new Dictionary<int, int>()
				{
					{ 1, 10 },

					{ 2, 5 },

					{ 3, 3 }
				};

					Console.WriteLine("\nGreat, you have selected the " +
						(choice == 1 ? "Easy" : choice == 2 ? "Medium" : "Hard") + " difficulty level.\n");

					Console.WriteLine("\nLet's start the game!");


					int randomNumber = new Random().Next(1, 100);

					Console.WriteLine("\n" + randomNumber + "\n");

					for (int i = levels[choice]; i > 0; i--)
					{
						Console.Write("\nEnter your guess: ");

						if (int.TryParse(Console.ReadLine(), out int guessedNumber))
						{
							if (guessedNumber == randomNumber)
							{
								Console.WriteLine($"\nCongratulations! You guessed the correct number in " +
									$"{levels[choice] - i + 1} attempts.");

								break;
							}

							else if (guessedNumber > randomNumber)
							{
								Console.WriteLine($"\nIncorrect! The number is less than {guessedNumber}.");
							}

							else
							{
								Console.WriteLine($"\nIncorrect! The number is greater than {guessedNumber}.");
							}
						}

						else
						{
							Console.WriteLine("\nPlease choose a valid integer number!");
						}
					}

					Console.Write("\nDo you want to play another Round? (y/n): ");

					if ("n".Equals(Console.ReadLine(), StringComparison.OrdinalIgnoreCase))
					{
						continuePlaying = false;
					}

					Console.Clear();
				}

				else
				{
					Console.WriteLine("\nIncorrect choice!");
				}
			}
		}
	}
}
