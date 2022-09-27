namespace DataLogger.lib
{
    public class WindSpeed : IWeatherData
    {
        public DateTime TimeStamp { get; set; }   // properties

        public double? Value { get; set; } = null;

        public override string ToString()
        {
            return $"Windgeschwindigkeit: {Value} km/h ({TimeStamp})";
        }
    }
}