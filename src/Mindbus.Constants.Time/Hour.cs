namespace Mindbus.Constants.Time
{
    public struct Hour
    {
        public int Value { get; set; }

        public static implicit operator int(Hour second)
        {
            return second.Value;
        }

        public static implicit operator Hour(int value)
        {
            return new Hour { Value = value };
        }
    }
}
