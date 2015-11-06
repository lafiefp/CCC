using System.Collections.Generic;

namespace Level1
{
    class Program
    {
        const int NoInputFiles = 6;
        const string FileName = "level1_{0}.in";

        static void Main(string[] args)
        {
            int noSegs;
            List<Car> cars = new List<Car>();

            for (int i = 1; i <= NoInputFiles; i++)
            {
                noSegs = FileParser.ParseFile(string.Format(FileName, i), cars);

                var road = new Road(noSegs);
                foreach(var c in cars)
                {
                    road.InitCar(c);
                }

                System.Console.WriteLine("Results for inputfile " + i.ToString());
                road.Simulate();
            }
        }
    }
}
