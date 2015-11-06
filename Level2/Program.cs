using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Level1
{
    class Program
    {
        const int NoInputFiles = 3;
        const string FileName = "input/level2_{0}.in";
        const string OutFile = "level2_{0}.out";

        static void Main(string[] args)
        {
            var globalfile = new StreamWriter("abgabe2.txt");
            File.Delete(@"C:\Temp\out.txt");

            for (int i = 3; i <= NoInputFiles; i++)
            {
                var cars = new List<Car>();
                int noSegs = FileParser.ParseFile(string.Format(FileName, i), cars);

                var road = new Road(noSegs);
                foreach (var c in cars)
                {
                    road.InitCar(c);
                }

                Console.WriteLine("Results for inputfile " + i.ToString());
                while (road.HasCars)
                {
                    road.Simulate();
                }

                var car_times = string.Join(",", cars.Select(x => x.ArrivalTime));

                var fw = new StreamWriter(string.Format(OutFile, i));
                fw.WriteLine(car_times);
                fw.Close();

                globalfile.WriteLine(car_times);

                Console.WriteLine(car_times);
                Console.WriteLine(string.Format("Jams: {0}, CantEnter: {1}", road.JamCounter, Segment.CantEnter));
                Console.WriteLine("-------------------------------------");
                Segment.CantEnter = 0;
            }

            globalfile.Close();
        }
    }
}
