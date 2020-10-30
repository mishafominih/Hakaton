using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public class Manager
    {
        public void Update(InputData s)
        {
            var val = s.GetValue();
            //Statistic.Data
        }

        public Tick GetTick()
        {
            return null;
        }

        public List<Tuple<DateTime, double>> GetGraf(Type type)
        {
            return null;
        }
    }
}
