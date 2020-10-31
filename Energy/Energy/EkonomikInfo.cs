using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public class EkonomikInfo
    {
        public EkonomikInfo(List<Device> devices, DateTime start)
        {
            if(devices.Count > 1)
            {

            }
            else
            {
                var d = devices[0];
            }
        }

        private double GetUsege(Device d, DateTime start)
        {
            
        }
    }
}
