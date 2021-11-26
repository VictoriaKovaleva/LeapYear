using System;
using System.Collections.Generic;
using Xunit;

namespace LeapYearKata.Tests
{
    public class LeapYearTests
    {

        [Theory]
        [InlineData(2020, "Leap Year!")]
        [InlineData(2021, "Not Leap Year!")]
        [InlineData(2022, "Not Leap Year!")]
        [InlineData(2023, "Not Leap Year!")]
        [InlineData(2024, "Leap Year!")]
        public void YearIsLeapOrNotLeapYear(int year, string expected)
        {
            string actual = LeapYearChecker.LeapYear(year);
            
            Assert.Equal(expected, actual);
        }
    }
}