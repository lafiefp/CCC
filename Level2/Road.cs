using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Road
    {
        public int CurrentTime;
        public List<Segment> Segments;
        private int _carCount;

        public Road(int NoSegments)
        {
            CurrentTime = 1;
            Segments = new List<Segment>(NoSegments);
            for (int i = 0; i < NoSegments; i++)
            {
                Segments.Add(new Segment());
            }
        }

        public bool HasCars { get { return _carCount > 0; } }

        public int JamCounter { get; private set; }

        public void InitCar(Car car)
        {
            if ((car.End - 1) >= Segments.Count)
            {
                throw new Exception("");
            }
            Segments[car.Start - 1].Add(car);
            _carCount++;
        }

        public void Simulate()
        {
            var NextSegments = Segments.ConvertAll(seg => new Segment(seg));

            // shift segments
            for (int i = Segments.Count - 1; i > 0; i--)
            {
                if (Segments[i].CurrentCar == null)
                {
                    NextSegments[i].CurrentCar = Segments[i - 1].CurrentCar;
                    NextSegments[i - 1].CurrentCar = null;
                }

                if (Segments[i].CurrentCar != null && Segments[i-1].CurrentCar != null)
                {
                    JamCounter++;
                }
                // Segments[i].CurrentCar = Segments[i - 1].CurrentCar;
            }

            Segments = NextSegments;

            // handle waiting cars
            for (int i = 0; i < Segments.Count - 1; i++)
            {
                var seg = Segments[i];
                seg.NextCar(CurrentTime, Segments[i + 1].HasCar);
            }
            Segments[Segments.Count - 1].NextCar(CurrentTime, false);

            PrintRaod();

            // drive cars
            for (int i = 0; i < Segments.Count; i++)
            {
                if (Segments[i].CurrentCar != null)
                {
                    Segments[i].CurrentCar.Drive();

                    if (Segments[i].CurrentCar.End == (i + 1))
                    {
                        Segments[i].CurrentCar.ArrivalTime = CurrentTime;
                        Segments[i].CurrentCar = null;
                        _carCount--;
                    }
                }
            }

            CurrentTime++;
        }

        private void PrintRaod()
        {
            StreamWriter fw = new StreamWriter("C:\\Temp\\out.txt", true);
            foreach (var s in Segments)
            {
                fw.Write(string.Format(s.CurrentCar == null ? "0" : "1"));
            }
            fw.WriteLine();
            fw.Close();
        }
    }
}
