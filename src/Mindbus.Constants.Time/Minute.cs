namespace Mindbus.Constants.Time
{
    public struct Minute
    {
        public int Value { get; set; }

        public static implicit operator int(Minute minute)
        {
            return minute.Value;
        }

        public static implicit operator Minute(int value)
        {
            return new Minute {Value = value };
        }
    }
}
