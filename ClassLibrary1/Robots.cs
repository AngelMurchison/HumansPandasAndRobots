using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    public class Robots
    {
        public void startup()
        {
            bool active = true;
            Console.WriteLine("Started..");
        }
        public void shutdown()
        {
            bool active = false;
            Console.WriteLine("Shutdown..");
        }
    }
}
