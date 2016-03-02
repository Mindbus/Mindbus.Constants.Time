using Xunit;

namespace Mindbus.Constants.Time.Tests
{
    public class ExtensionTests
    {
        [Fact]
        public void CastTests()
        {
            int expected = 5;
            Second testValue = 5;
            Assert.Equal(expected, testValue.Value);
            Assert.Equal(expected, (int)testValue);
        }

        [Fact]
        public void HoursInSecondsTest()
        {
            Second expected = Time.InSeconds.OneHour*5;
            var testValue = 5.Hours().InSeconds();
            Assert.Equal(expected, testValue);
        }

        [Fact]
        public void MinutesInSecondsTest()
        {
            Second expected = Time.InSeconds.OneMinute * 5;
            var testValue = 5.Minutes().InSeconds();
            Assert.Equal(expected, testValue);
        }

        [Fact]
        public void HoursInMinutesTest()
        {
            Minute expected = Time.InMinutes.OneHour * 5;
            var testValue = 5.Hours().InMinutes();
            Assert.Equal(expected, testValue);
        }

        [Fact]
        public void SecondsInHoursTest()
        {
            Hour expected = 1;
            Hour expectedMinusOne = 0;
            Hour expectedPlusOne = 2;
            var oneHourInSeconds = Time.InSeconds.OneHour;
            var approximateByDefault = oneHourInSeconds.Seconds().InHours();
            Assert.Equal(expected, approximateByDefault);

            var approximateByRound = oneHourInSeconds.Seconds().InHours(ApproximationType.Round);
            Assert.Equal(expected, approximateByRound);

            var approximateByFloor = (oneHourInSeconds + 10 ).Seconds().InHours(ApproximationType.Floor);
            Assert.Equal(expected, approximateByFloor);

            var approximateByFloorInverse = (oneHourInSeconds - 10).Seconds().InHours(ApproximationType.Floor);
            Assert.Equal(expectedMinusOne, approximateByFloorInverse);

            var approximateByTop = (oneHourInSeconds - 10).Seconds().InHours(ApproximationType.Top);
            Assert.Equal(expected, approximateByTop);

            var approximateByTopInverse = (oneHourInSeconds + 10).Seconds().InHours(ApproximationType.Top);
            Assert.Equal(expectedPlusOne, approximateByTopInverse);
        }

        [Fact]
        public void MinutesInHoursTest()
        {
            Hour expected = 1;
            Hour expectedMinusOne = 0;
            Hour expectedPlusOne = 2;
            var oneHourInMinutes = Time.InMinutes.OneHour;
            var approximateByDefault = oneHourInMinutes.Minutes().InHours();
            Assert.Equal(expected, approximateByDefault);

            var approximateByRound = oneHourInMinutes.Minutes().InHours(ApproximationType.Round);
            Assert.Equal(expected, approximateByRound);

            var approximateByFloor = (oneHourInMinutes + 10).Minutes().InHours(ApproximationType.Floor);
            Assert.Equal(expected, approximateByFloor);

            var approximateByFloorInverse = (oneHourInMinutes - 10).Minutes().InHours(ApproximationType.Floor);
            Assert.Equal(expectedMinusOne, approximateByFloorInverse);

            var approximateByTop = (oneHourInMinutes - 10).Minutes().InHours(ApproximationType.Top);
            Assert.Equal(expected, approximateByTop);

            var approximateByTopInverse = (oneHourInMinutes + 10).Minutes().InHours(ApproximationType.Top);
            Assert.Equal(expectedPlusOne, approximateByTopInverse);
        }

        [Fact]
        public void ExampleTests()
        {
            Assert.Equal(2, (int)120.Minutes().InHours());
            Assert.Equal(2, (int)125.Minutes().InHours(ApproximationType.Floor));
        }
    }
}
