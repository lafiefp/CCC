using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Road
    {
        public List<Segment> Segments;

        public Road(int NoSegments)
        {
            Segments = new List<Segment>(NoSegments);
            for (int i = 0; i < NoSegments; i++)
            {
                Segments.Add(new Segment());
            }
        }

        public void InitCar(Car car)
        {
            Segments[car.Start].Add(car);
        }

        internal void Simulate()
        {
            // TODO: implement logic!!!
        }
    }
}
