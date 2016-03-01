using Xunit;

namespace Mindbus.Constants.Time.Tests
{
    public class TimeTests
    {
        [Fact]
        public void InSeconds()
        {
            Assert.Equal(1, Time.InSeconds.OneSecond);
            Assert.Equal(5, Time.InSeconds.FiveSeconds);
            Assert.Equal(60, Time.InSeconds.OneMinute);
            Assert.Equal(3600, Time.InSeconds.OneHour);
            Assert.Equal(86400, Time.InSeconds.OneDay);
        }

        [Fact]
        public void InMinutes()
        {
            Assert.Equal(1, Time.InMinutes.OneMinute);
            Assert.Equal(60, Time.InMinutes.OneHour);
            Assert.Equal(1440, Time.InMinutes.OneDay);
        }

        [Fact]
        public void InHours()
        {
            Assert.Equal(1, Time.InHours.OneHour);
            Assert.Equal(24, Time.InHours.OneDay);
        }
    }
}
