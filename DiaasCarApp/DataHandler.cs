using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    internal class DataHandler
    {
        public string FilePath { get; set; }

        public DataHandler(string filePath)
        {
            FilePath = filePath;
        }

        public void SaveCarsToFile(List<Car> cars)
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (Car car in cars)
                {
                    sw.WriteLine(car.ToString());
                }
            }
        }

        public void SaveCarsTripsToFile(List<Car> cars)
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (var car in cars)
                {
                    foreach (var Trip in car.Trips)
                    { 
                        sw.WriteLine(Trip.ToString());
                    }
                }
            }
        }

        public void ReadCarsFromFile()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))//There can be lines in the file that are empty, but it won't print them out.
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
