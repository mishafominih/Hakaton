using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public class Manager
    {
        public static void Update(InputData s)
        {
            var val = s.GetValue();
            if (val != null)
            {
                var tick = Statistic.UpdateTick(val);
                Analizer.Update(tick);
                Statistic.AddElement(tick);
            }
        }

        public static Tick GetTick()
        {
            return null;
        }

        public static List<Tuple<DateTime, double>> GetGraf(Type type)
        {
            return null;
        }
    }
}
