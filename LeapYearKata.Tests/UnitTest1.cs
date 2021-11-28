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
        [InlineData(2025, "Not Leap Year!")]
        [InlineData(2028, "Leap Year!")]
        [InlineData(1968, "Leap Year!")]
        [InlineData(2054, "Not Leap Year!")]
        [InlineData(1911, "Not Leap Year!")]
        [InlineData(3000, "Not Leap Year!")]
        public void YearIsLeapOrNotLeapYear(int year, string expected)
        {
            string actual = LeapYearChecker.LeapYear(year);
            
            Assert.Equal(expected, actual);
        }
    }
}