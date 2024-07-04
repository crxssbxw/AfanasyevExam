using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace src.Classes
{
    public class CityControl
    {
        public List<City> Cities;

        public void Sort()
        {
            Cities.Sort((a, b) => string.Compare($"{b.Foundation} {b.Population.ToString()}", $"{a.Foundation} {a.Population.ToString()}"));
        }

        public void Save()
        {
            using (StreamWriter sw = new(@"../../File/citiesFile.txt"))
            {
                foreach(var city in Cities)
                {
                    sw.WriteLine($"{city.Name} ({city.Foundation})\t Население:\t {city.Population}");
                }
            }
        }
    }
}
