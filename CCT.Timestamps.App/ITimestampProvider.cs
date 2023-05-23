namespace CCT.Timestamps.App
{
    public interface ITimestampProvider
    {
        DateTime Today();
        DateTime Now();
    }
}
