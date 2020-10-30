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
        private readonly double TUsege;
        public Type TypeDivice
        {
            get { return TypeDivice; }
            private set => TypeDivice = value;
        }
        private double RealUsege = -1;
        private List<Tuple<DateTime, double>> ListUsege; // <time, RealUsege>
        private int number;


        public Device(double TConsumption, Type type)
        {
            ListUsege = new List<Tuple<DateTime, double>>();
            this.TUsege = TConsumption;
            TypeDivice = type;
            //Statistic.data.Where(e => )
        }

        public void SetUsege(double realUsege, DateTime time)
        {
            RealUsege = realUsege;
            ListUsege.Add(Tuple.Create(time, realUsege));
        }

        public double GetConsumption()
        {
            if (RealUsege > 0)
                return RealUsege;
            return TUsege;
        }

        public static bool operator !=(Device device1, Device device2)
        {
            if (device1.number != device2.number) return false;
            if (!Analizer.IsEquals(device1.GetConsumption(),device2.GetConsumption())) return false;
            if (device1.TypeDivice != device2.TypeDivice) return false;
            return true;
        }

        public override bool Equals(object device)
        {
            if (device is Device)
                return this == (Device)device;
            else return false;
        }

        public static bool operator ==(Device device1, Device device2)
        {
            return !(device1 != device2);
        }
    }
}
