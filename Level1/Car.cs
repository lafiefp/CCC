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
            get { return this.start; }
        }
        private int end;
        public int End
        {
            get { return this.start; }
        }

        private int elapsedTime;
        public int ElapsedTime
        {
            get { return this.elapsedTime; }
        }


        public Car(int startpoint, int endpoint)
        {
            this.start = startpoint;
            this.end = endpoint;
            this.elapsedTime = 0;
        }

        public void Drive()
        {
            this.elapsedTime++;
        }
    }
}
