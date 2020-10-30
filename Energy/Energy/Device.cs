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
        private int number;
        private Type typeDivice;
        public Type TypeDivice { get { return typeDivice; } }
        private double RealUsege = -1;
        private List<Tuple<DateTime, double>> ListUsege; // <time, RealUsege>
        public int Number { get { return number; } }

        public Device(double TConsumption, Type type)
        {
            ListUsege = new List<Tuple<DateTime, double>>();
            this.TUsege = TConsumption;
            typeDivice = type;
            number = getNumber();
        }

        private int getNumber()
        {
            if (Statistic.Data.Count == 0)
                return 1;

            return Statistic.Data
                .Where(e => e.TypeDivice == TypeDivice)
                .Max(e => e.Number) + 1;
        }

        public void SetUsege(double realUsege, DateTime time)
        {
            RealUsege = realUsege;
            ListUsege.Add(Tuple.Create(time, realUsege));
        }

        public double GetUsege()
        {
            if (RealUsege < 0)
                return TUsege;
            return GetProbabilityUsege();
        }

        private double GetProbabilityUsege()
        {
            var lisProbability = new Dictionary<double, double>();
            var key = 0.0;
            foreach (var item in ListUsege) 
            { 
                key = ListUsege.Where(e => item == e).Count() / ListUsege.Count;
                lisProbability[key] = item.Item2;
            }
            key = lisProbability.Max(e => e.Key);
            return lisProbability[key];
        }

        public static bool operator !=(Device device1, Device device2)
        {
            if (device1.Number != device2.Number) return false;
            if (!Analizer.IsEquals(device1.GetUsege(),device2.GetUsege())) return false;
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
