using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger.lib
{
    public class CSVLoader
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
                string[] split = line.Split(';');
                DateTime timeStamp = DateTime.Parse(split[0]);
                WeatherData.Add(new WindSpeed()
                {
                    TimeStamp = timeStamp,
                    Value = double.Parse(split[1], System.Globalization.CultureInfo.InvariantCulture)
                });
                WeatherData.Add(new Temperature()
                {
                    TimeStamp = timeStamp,
                    Value = double.Parse(split[2], System.Globalization.CultureInfo.InvariantCulture)
                });
            }
            sr.Close();
        }
    }
}
