namespace Mindbus.Constants.Time
{
    /// <summary>
    /// A Set of commonly used Time constants
    /// </summary>
    public static class Time
    {
        /// <summary>
        /// Commonly used Time constants values in Seconds
        /// </summary>
        public static class InSeconds
        {
            public const int OneSecond = 1;
            public const int FiveSeconds = 5;
            public const int OneMinute = OneSecond*60;
            public const int OneHour = OneMinute*60;
            public const int OneDay = OneHour*24;
        }

        /// <summary>
        /// Commonly used Time constants values in Minutes
        /// </summary>
        public static class InMinutes
        {
            public const int OneMinute = 1;
            public const int OneHour = OneMinute*60;
            public const int OneDay = OneHour*24;
        }

        /// <summary>
        /// Commonly used Time constants values in Hours 
        /// </summary>
        public static class InHours
        {
            public const int OneHour = 1;
            public const int OneDay = 24;
        }
    }
}
