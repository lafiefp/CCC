using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Segment
    {
        public Car CurrentCar;
        public List<Car> WaitingCars;

        public Segment()
        {
            WaitingCars = new List<Car>();
        }

        public Segment(Segment seg)
        {
            CurrentCar = seg.CurrentCar;
            WaitingCars = seg.WaitingCars;
        }

        public static int CantEnter { get; set; }

        public bool HasCar { get { return CurrentCar != null; } }

        public void Add(Car car)
        {
            WaitingCars.Add(car);
            WaitingCars.OrderBy(x => x.StartTime);
        }

        public void NextCar(int currentTime, bool nextOccupied)
        {
            if (!nextOccupied && !HasCar)
            {
                if (WaitingCars.Count > 0)
                {
                    if (WaitingCars.First().StartTime < currentTime)
                    {
                        CurrentCar = WaitingCars.First();
                        WaitingCars.RemoveAt(0);
                    }
                }
            }
            else if (WaitingCars.Count > 0 && WaitingCars.First().StartTime < currentTime)
            {
                CantEnter++;
            }

            foreach(var c in WaitingCars.Where(x => x.StartTime < currentTime))
            {
                c.Drive();
            }
        }
    }
}
