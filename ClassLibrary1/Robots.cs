using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    public class Robots
    {
        public bool isTerminator { get; set; } = false;

        public bool active { get; set; }

        public void startup()
        {
            active = true;
            Console.WriteLine("Started..");
        }

        public void shutdown()
        {
            active = false;
            Console.WriteLine("Shutdown..");
        }

        public string DisplayGreeting()
        {
            string greeting = "Salutations, bloodbag!";
            return greeting;
        }

        public void amTerminator()
        {
            isTerminator = true;
        }
    }
}
