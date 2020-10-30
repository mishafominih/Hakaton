using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public static class Statistic
    {
        public static List<Device> data = new List<Device>();

        public static bool haveDevice(Device device)
        {
            return data.Contains(device);
        }
    }
}
