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

        public bool HasCar { get { return CurrentCar != null; } }

        public void Add(Car car)
        {
            WaitingCars.Add(car);
        }

        public void NextCar(bool nextOccupied)
        {
            if (nextOccupied || HasCar)
            {
                for (int i = 0; i < WaitingCars.Count; i++)
                {
                    WaitingCars[i].Drive();
                }
            }
            else
            {
                if (WaitingCars.Count > 0)
                {
                    CurrentCar = WaitingCars.First();
                    WaitingCars.RemoveAt(0);
                }
            }
        }
    }
}
