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
            
            string line = sr.ReadLine();

            if (line != "Time;Wind speed;Temperature") throw new Exception("Kann nicht laden weil Header fehlt.");
            while(line != string.Empty)
            {
                    throw new NotImplementedException();
            }
        }
    }
}
