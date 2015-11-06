using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Segment
    {
        Car CurrentCar;
        List<Car> WaitingCars;

        public Segment()
        {
            WaitingCars = new List<Car>();
        }

        public void Add(Car car)
        {
            if (CurrentCar == null)
            {
                CurrentCar = car;
            }

            WaitingCars.Add(car);
        }
    }
}
