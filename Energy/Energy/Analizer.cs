using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public static class Analizer
    {
        public static void Update(Tick tick)
        {
            var firstCalculate = 0.0;
            foreach(var d in tick.Devices) firstCalculate += d.GetUsege();
            if (IsEquals(firstCalculate, tick.Usage)) return;
            foreach (var d in tick.Devices)
            {
                if (Statistic.haveDevice(d))//если есть новые элементы
                {
                    d.SetUsege(Math.Abs(tick.Usage - firstCalculate), DateTime.Now);
                }
            }
        }

        public static bool IsEquals(double v1, double v2)
        {
            return Math.Abs(v1 - v2) <= 0.00001;
        }
    }
}
