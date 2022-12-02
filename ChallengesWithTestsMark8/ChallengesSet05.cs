using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.Serialization;

namespace ChallengesWithTestsMark8
{
	public class ChallengesSet05
	{
		public int GetNextNumberDivisibleByN(int startNumber, int n)
		{
			return ((startNumber / n) + 1) * n;
		}

		public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
		{
			for (int i = 0; i < businesses.Length; i++)
			{
				if (businesses[i].TotalRevenue == 0)
				{
					businesses[i].Name = "CLOSED";
				}
			}
		}

		public bool IsAscendingOrder(int[] numbers)
		{
			if (numbers == null || numbers.Length == 0)
			{
				return false;
			}
			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] < numbers[i - 1])
				{
					return false;
				}

			}
			return true;
		}

		public int SumElementsThatFollowAnEven(int[] numbers)
		{
			if (numbers == null)
			{
				return 0;
			}
			int sum = 0;

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i - 1] % 2 == 0)
				{
					sum += numbers[i];
				}
			}
			return sum;
		}

		public string TurnWordsIntoSentence(string[] words)
		{
			if (words == null)
			{
				return "";
			}
			string sentence = "";

			foreach (var word in words)
			{
				if (word.Trim().Length > 0)
				{
					sentence += word.Trim() + " ";
				}
			}

			if (sentence.Length == 0)
			{
				return "";
			}

			sentence = sentence.Trim();
			sentence += ".";
			return sentence;
		}

		public double[] GetEveryFourthElement(List<double> elements)
		{
			if (elements == null)
			{
				return new double[0];
			}
			List<double> everyfouth = new List<double>();

			for (int i = 3; i < elements.Count; i += 4)
			{
				everyfouth.Add(elements[i]);
			}
			return everyfouth.ToArray();
		}

		public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
		{
			if (nums == null) { return false; }
			for (int i = 0; i < nums.Length; i++)
			{
				for (int k = i + 1; k < nums.Length; k++)
				{
					if (nums[i] + nums[k] == targetNumber)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
