using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public enum Type
    {
        Computer,
        Lamp,
        Freese
    }
  
    public class Device
    {
        public int Count;
        public double SumUsege;
        public Type TypeDevice;
        List<Tuple<DateTime, double>> Graf = new List<Tuple<DateTime, double>>();

        public void UpdateGraf()
        {
            Graf.Add(Tuple.Create(DateTime.Now, SumUsege));
        }

        public Device(Type type, int c)
        {
            TypeDevice = type;
            Count = c;
        }

        public override bool Equals(object obj)
        {
            if(obj is Device)
            {
                return TypeDevice == ((Device)obj).TypeDevice;
            }
            return false;
        }
    }
}
