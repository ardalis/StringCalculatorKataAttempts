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

            var result = numberString.Split(delimiters.ToArray())
                .Select(s => int.Parse(s))
                .Sum();

            return result;
        }
    }
}
