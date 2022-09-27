namespace DataLogger.lib
{
    public interface IWeatherData
    {
        DateTime TimeStamp { get; set; }
        double? Value { get; set; }

        string ToString();
    }
}