using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger.lib
{
    public class CSVLoader
    {
        public List<IWeatherData> WindSpeed { get; set; }
        public List<IWeatherData> Temperature { get; set; }
        public void ImportCSV(string path)
        {
            WindSpeed = new List<IWeatherData>();
            Temperature = new List<IWeatherData>();
            StreamReader sr = new StreamReader(path);
            
            string? line = sr.ReadLine();

            if (line != "Time;Wind speed;Temperature") throw new Exception("Kann nicht laden weil Header fehlt.");
            line = sr.ReadLine();
            while (line != null)
            {
               
                string[] split = line.Split(';');
                DateTime timeStamp = DateTime.Parse(split[0]);
                WindSpeed.Add(new WindSpeed()
                {
                    TimeStamp = timeStamp,
                    Value = double.Parse(split[1], System.Globalization.CultureInfo.InvariantCulture)
                });
                Temperature.Add(new Temperature()
                {
                    TimeStamp = timeStamp,
                    Value = double.Parse(split[2], System.Globalization.CultureInfo.InvariantCulture)
                });
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
