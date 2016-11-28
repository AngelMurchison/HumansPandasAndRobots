using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots
{
    public abstract class HumansPandasAndRobots
    {
        public string DisplayName(string name)
        {
            string Name = $"{name}";
            return Name;
        }
        public abstract string DisplayGreeting();
    }
}
