using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex38events_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Listener listener = new Listener();
            Listener1 listener1 = new Listener1();

            Powerplant p = new Powerplant();
            p.Sensor1 += listener1.Display;
            p.Sensor += listener.Display;
            Console.WriteLine("indtast navn yo");
            
            p.Start(Console.ReadLine());
            
        }
    }
}
