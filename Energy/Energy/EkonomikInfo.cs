using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public class EkonomikInfo
    {
        public double StandartTarif;
        public EkonomikInfo(List<Device> devices, DateTime start, double tarif = 5)
        {
            var sum = 0.0;
            foreach(var d in devices)
            {
                sum += GetUsege(d, start);
            }
            StandartTarif = sum * tarif;
        }

        private double GetUsege(Device d, DateTime start)
        {
            var sum = 0.0;
            var list = d.GetGraf().Where(x => x.Item1 >= start).ToList();
            foreach(var t in list)
                sum += t.Item2;
            return sum;
        }
    }
}
