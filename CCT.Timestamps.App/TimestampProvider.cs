namespace CCT.Timestamps.App
{
    public class TimestampProvider : ITimestampProvider
    {
        public DateTime Today() => DateTime.Today;
        public DateTime Now() => DateTime.Now;
    }
}
