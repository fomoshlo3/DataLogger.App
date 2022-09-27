using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger.lib
{
    public class Temperature : IWeatherData
    {
        public DateTime TimeStamp { get; set; }

        public double? Value { get; set; } = null;

        public override string ToString()
        {
            return $"Temperatur: {Value} °C ({TimeStamp})";
        }
    }
}
