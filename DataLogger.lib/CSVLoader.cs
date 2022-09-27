using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger.lib
{
    internal class CSVLoader
    {
        public List<IWeatherData> WeatherData{ get; set;}

        public void ImportCSV(string path)
        {
            WeatherData = new List<IWeatherData>();

            StreamReader sr = new StreamReader(path);
        }
    }
}
