using System;
using System.Collections.Generic;
using System.Text;

namespace Common.CSharpEventDelegate
{
    // boiler 类
    class Boiler
    {
        private int temp;
        private int pressure;
        public Boiler(int t, int p)
        {
            temp = t;
            pressure = p;
        }

        public int getTemp()
        {
            return temp;

        }

        public int getPressure()
        {

            return pressure;
        }

    }
}
