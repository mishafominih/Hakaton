using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public class Analizer
    {
        private static Tick prevTick;
        public static void Update(Tick tick)
        {
            foreach (var d in tick.devices)
            {
                if (prevTick is null)
                {
                    d.SumUsege = tick.Usege;
                    break;
                }
                var t = tick - prevTick;
                if (t is null)
                    break;
                t.Item2.SumUsege = t.Item1;
            }
            prevTick = tick;
        }
    }
}
