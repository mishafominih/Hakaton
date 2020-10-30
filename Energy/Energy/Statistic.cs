using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public static class Statistic
    {

        private static List<Device> data = new List<Device>();
        public static List<Device> Data
        {
            get { return data; }
            private set => data = value;
        }

        public static bool haveDevice(Device device)
        {
            return data.Contains(device);
        }
    }
}
