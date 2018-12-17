using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex38events_2._0
{
    public class Listener
    {
        
        public void Display(object sender, EventArgs e)
        {
            Console.WriteLine( "Im still alive bitch :" + sender);
        }
    }
}
