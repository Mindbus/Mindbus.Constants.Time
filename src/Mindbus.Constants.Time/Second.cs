namespace Mindbus.Constants.Time
{
    public struct Second
    {
        public int Value { get; set; }

        public static implicit operator int(Second second)
        {
            return second.Value;
        }

        public static implicit operator Second(int value)
        {
            return new Second {Value = value };
        }
    }
}
