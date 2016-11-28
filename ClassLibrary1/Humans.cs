using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasAndRobots

{
    public class Humans
    {
        public bool isAsleep { get; set; }

        public string Eat(string food)
        {
            food = $"Yum, I ate {food}";
            return food;
        }


        public void GoToSleep()
        {
            isAsleep = true;
            Console.WriteLine("..Zzzzz...");
        }

        public void WakeUp()
        {
            isAsleep = false;
            Console.WriteLine("..*yawn*..");
        }

        public bool IsAsleep()
        {
            bool IsAsleep = isAsleep;
            return IsAsleep;

        }
    }
}
