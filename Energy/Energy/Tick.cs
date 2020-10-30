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

        public Tick(string devices, double u)
        {
            Devices = devices
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (Type)Enum.Parse(typeof(Type), x))
                .Select(x => new Device(0, x))
                .ToList();
            Usage = u;
        }

        public Tick(List<Device> d, double u)
        {
            Devices = d;
            Usage = u;
        }
    }
}
