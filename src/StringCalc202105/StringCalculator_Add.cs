using System;
using Xunit;

namespace StringCalc202105
{
    public class StringCalculator_Add
    {
        [Fact]
        public void Returns0GivenEmptyString()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

            Assert.Equal(0, result);
        }
    }
}
