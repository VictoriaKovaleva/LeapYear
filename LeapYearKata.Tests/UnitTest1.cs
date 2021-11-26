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
        
    }
}