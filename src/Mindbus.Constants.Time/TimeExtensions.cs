using System;

namespace Mindbus.Constants.Time
{
    public static class TimeExtensions
    {
        public static Hour Hours(this int value)
        {
            return value;
        }

        public static Minute Minutes(this int value)
        {
            return value;
        }

        public static Second Seconds(this int value)
        {
            return value;
        }


        public static Minute InMinutes(this Hour hour)
        {
            return hour * Time.InMinutes.OneHour;
        }

        public static Second InSeconds(this Hour hour)
        {
            return hour * Time.InSeconds.OneHour;
        }

        public static Second InSeconds(this Minute minute)
        {
            return minute * Time.InSeconds.OneMinute;
        }


        public static Minute InMinutes(this Second second, ApproximationType approximationType = ApproximationType.Round)
        {
            var value = second / (double)Time.InSeconds.OneMinute;
            return Approximate(value, approximationType);
        }

        public static Hour InHours(this Second second, ApproximationType approximationType = ApproximationType.Round)
        {
            var value = second / (double)Time.InSeconds.OneHour;
            return Approximate(value, approximationType);
        }

        public static Hour InHours(this Minute minute, ApproximationType approximationType = ApproximationType.Round)
        {
            var value = minute / (double)Time.InMinutes.OneHour;
            return Approximate(value, approximationType);
        }

        private static int Approximate(double value, ApproximationType approximationType)
        {
            switch (approximationType)
            {
                case ApproximationType.Top:
                    return (int)Math.Ceiling(value);
                case ApproximationType.Floor:
                    return (int)Math.Floor(value);
                default:
                    return (int)Math.Round(value);
            }
        }
    }
}
