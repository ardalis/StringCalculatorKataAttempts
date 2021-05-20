using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalc202105
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;

            var delimiters = new List<char> { ',', '\n' };

            string numberString = numbers;
            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');
                var newDelimiter = splitInput.First().Trim('/');
                numberString = String.Join('\n', splitInput.Skip(1));

                delimiters.Add(Convert.ToChar(newDelimiter));
            }

            var numberList = numberString.Split(delimiters.ToArray())
                .Select(s => int.Parse(s));

            var negatives = numberList
                .Where(n => n < 0);

            if(negatives.Any())
            {
                string negativeString = String.Join(',',negatives
                    .Select(n => n.ToString()));
                throw new Exception($"Negatives not allowed: {negativeString}");
            }

            var result = numberList
                .Where(n => n <= 1000)
                .Sum();

            return result;
        }
    }
}
