using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public class Tick
    {
        public List<Device> Devices;
        public double Usage;

        public Tick(List<Device> d, double u)
        {
            Devices = d;
            Usage = u;
        }
    }
}
