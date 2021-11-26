using System;
using System.Collections.Generic;
using Xunit;

namespace LeapYearKata.Tests
{
    public class LeapYearTests
    {
        [Fact]
        public void Year2020IsLeapYear()
        {
            string actual = LeapYearChecker.LeapYear(2020);
            
            Assert.Equal("Leap Year!", actual);
        }

        [Fact]
        public void Year2021IsNotLeapYear()
        {
            string actual = LeapYearChecker.LeapYear(2021);
            
            Assert.Equal("Not Leap Year!", actual);
        }
        
        [Fact]
        public void Year2022IsNotLeapYear()
        {
            string actual = LeapYearChecker.LeapYear(2022);
            
            Assert.Equal("Not Leap Year!", actual);
        }

        [Fact]
        public void Year2023IsNotLeapYear()
        {
            string actual = LeapYearChecker.LeapYear(2023);
            
            Assert.Equal("Not Leap Year!", actual);
        }
    }
}