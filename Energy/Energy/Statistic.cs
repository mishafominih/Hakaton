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

        public static void AddElement(Device element) => data.Add(element);

        public static void AddElement(Tick tick)
        {
            foreach(var d in tick.Devices)
            {
                if (!haveDevice(d))
                {
                    AddElement(d);
                }
            }
        }

        public static bool haveDevice(Device device)
        {
            return data.Contains(device);
        }

        public static Tick UpdateTick(Tick tick)
        {
            var res = new List<Device>();
            var arr = Data.ToList();
            foreach(var d in tick.Devices)
            {
                var x = arr.Where(e => e.TypeDivice == d.TypeDivice).FirstOrDefault();
                if(x != null)
                {
                    res.Add(x);
                    arr.Remove(x);
                }
                else
                {
                    res.Add(d);
                }
            }
            return new Tick(res, tick.Usage);
        }


    }
}
