using System;
using Xunit;
using OOPEssentialTraining;

namespace OOPEssentialTests
{
    public class LeapYearTest
    {
        //In order to transfer this method to test we use transfer attribute on this

        private LeapYear leapYear;
        public LeapYearTest() {
            leapYear = new LeapYear();
        }

        [Fact]
        public void DateOkShouldEqualTHeirEqual()
        {
           bool validDate =leapYear.DateOk(2,29,1991);
            Assert.True(validDate);
           // Assert.Throws<ArgumentOutOfRangeException>(() => validDate);
        }

        [Fact]
        public void getDaysInAMonth()
        {
            int val = leapYear.getDaysInAMonth(1995, 25);
            Assert.Equal(expected: 29, actual: val);
            Assert.Equal(expected: 28, actual: val);

        }
        [Fact]
        public void FindLeapYear()
        {
            bool isLeapYear = leapYear.FindLeapYear(1995);
                Assert.True(isLeapYear);

        }
    }
}
;