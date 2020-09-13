using System;
using System.Collections.Generic;
using System.Numerics;

namespace Substrings
{
	internal class Program
	{
		public static void Main()
		{
			Console.WriteLine("Please enter the input string:");
			string input = Console.ReadLine();

			Console.WriteLine();

			FindSubstrings(input);

			Console.ReadKey();
		}

		// Finds all substring that match the criteria in a given input string. The criteria for a substring are:
		// 1. It does not contain any non-numeric characters
		// 2. It starts and ends with the same digit
		// 3. That digit does not occur anywhere inside the substring
		// The implementation is based on BigIntegers, which allows for really big numbers - therefore, the input string can be of any length
		private static void FindSubstrings(string input)
		{
			var numbers = new List<BigInteger>();

			for (int i = 0; i < input.Length - 1; i++)
			{
				// Save the current character
				var character = input[i];

				if (!char.IsNumber(character))
				{
					// If the current character is not a number, go next - the substring cannot contain letters
					continue;
				}

				string substr = character.ToString();

				// Check subsequent characters
				for (int j = i + 1; j < input.Length; j++)
				{
					// If a subsequent character is not a digit, break - there can't be a letter inside the substring
					if (!char.IsNumber(input[j]))
					{
						break;
					}

					// If a subsequent character is the same digit again, evaluate substr (it can't contain the same digit inside)
					if (input[j] == character)
					{
						substr += input[j];

						var value = BigInteger.Parse(substr);

						numbers.Add(value);

						DisplaySubstring(input, substr);

						break;
					}

					substr += input[j];
				}
			}

			Console.WriteLine($"\nThe total value of all found numbers is: {SumOfNumbers(numbers)}");
		}

		// Displays the input string and highlights the given substring in it
		private static void DisplaySubstring(string input, string substr)
		{
			for (int i = 0; i < input.Length; i++)
			{
				// Set the text's color properly, so that the substring is highlighted
				if (i == input.IndexOf(substr))
				{
					Console.ForegroundColor = ConsoleColor.Green;
				}
				else if (i == input.IndexOf(substr) + substr.Length)
				{
					Console.ForegroundColor = ConsoleColor.Gray;
				}

				Console.Write(input[i]);
			}

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("\n");
		}

		// Returns a sum of all numbers in a list of BigIntegers (LINQ doesn't support Sum<BigInteger>()
		private static BigInteger SumOfNumbers(List<BigInteger> numbers)
		{
			BigInteger sum = 0;

			foreach (var num in numbers)
			{
				sum += num;
			}

			return sum;
		}
	}
}
