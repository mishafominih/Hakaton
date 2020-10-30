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
        private Type typeDivice;
        private double RealUsege = -1;
        private List<Tuple<double, double>> ListUsege; // <time, RealUsege>


        public Device(double TConsumption, Type type)
        {
            ListUsege = new List<Tuple<double, double>>();
            this.TUsege = TConsumption;
            typeDivice = type;
        }

        public void SetUsege(double realUsege, double time)
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

    }
}
