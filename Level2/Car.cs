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
        
        public int ElapsedTime
        {
            get; set;
        }


        private int starttime;
        public int StartTime
        {
            get { return starttime; }
        }

        public int ArrivalTime { get; internal set; }

        public Car(int startpoint, int endpoint, int startingtime)
        {
            start = startpoint;
            end = endpoint;
            starttime = startingtime;
            ElapsedTime = 1;
        }

        public void Drive()
        {
            ElapsedTime++;
        }
    }
}
