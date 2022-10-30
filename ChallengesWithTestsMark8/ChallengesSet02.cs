using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool retval = true;
            if (c < 65 ) retval = false;
            if (c > 90 && c < 97) retval = false;
            if (c > 122 ) retval = false;
            return retval;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberOdd(int num)
        {
            return !IsNumberEven(num);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;

            double min = double.MaxValue;
            for (int i = 0; i < numbers.Count(); i++) 
            {
                double val = numbers.ElementAt(i);
                if (val <min)
                    min = val;
            }

            double max = double.MinValue;
            foreach (double val in numbers) 
            {
                if (val > max)
                    max = val;
            }

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;

            int retval = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                retval = retval + number;
            }
            return retval;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;

            int retval = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (number % 2 == 0)
                {

                    retval = retval + number;
                }
            }
            return retval;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }

            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 0)
                {

                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
}
