using System;
using System.Linq;

namespace StringCalc202105
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;

            var result = numbers.Split(',')
                .Select(s => int.Parse(s))
                .Sum();

            return result;
        }
    }
}
