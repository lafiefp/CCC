using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Level1
{
    class FileParser
    {
        public static int ParseFile(string filename, List<Car> cars)
        {
            int numberOfSegments = 0;

            var lines = File.ReadAllLines(filename);
            numberOfSegments = int.Parse(lines[0]);
            var numberOfCars = int.Parse(lines[1]);
            

            for(var i = 2; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length > 1)
                    cars.Add(new Car(int.Parse(parts[0]), int.Parse(parts[1])));
            }

            return numberOfSegments;
        }

    }
}
