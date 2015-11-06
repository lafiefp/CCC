using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Car
    {
        private int start;
        public int Start
        {
            get { return start; }
        }
        private int end;
        public int End
        {
            get { return end; }
        }

        private int elapsedTime;
        public int ElapsedTime
        {
            get { return elapsedTime; }
        }


        public Car(int startpoint, int endpoint)
        {
            start = startpoint;
            end = endpoint;
            elapsedTime = 1;
        }

        public void Drive()
        {
            elapsedTime++;
        }
    }
}
