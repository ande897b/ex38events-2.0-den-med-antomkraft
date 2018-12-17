using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex38events_2._0
{
    public class Powerplant
    {
        public delegate void MyDelegate(object sender, EventArgs e);
        // public  EventArgs e = null;
        public  event MyDelegate Sensor;
        public delegate void MyDelegate1(object sender, EventArgs e);
        public  event MyDelegate1 Sensor1;

        public void Start(string navn)
        {
            Sensor1(navn,null);
            Console.Beep();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
              
                if (Sensor != null)
                {
                    Sensor(navn, null);
                }
               
            }
        }
    }
}
