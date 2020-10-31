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
    {   // содержит информацию о типе устройства
        public Diapazon diapazon;
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
            SetDiapazon();
        }

        public override bool Equals(object obj)
        {
            if(obj is Device)
            {
                return TypeDevice == ((Device)obj).TypeDevice;
            }
            return false;
        }

        private void SetDiapazon()
        {
            switch (TypeDevice)
            {
                case Type.Computer:
                    diapazon = new Diapazon(2, 10);
                    break;
                case Type.Freese:
                    diapazon = new Diapazon(20, 40);
                    break;
                case Type.Lamp:
                    diapazon = new Diapazon(0, 2);
                    break;
            }
        }
    }

    public class Diapazon
    {
        private double a, b;
        public Diapazon(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public bool IsIn(double d)
        {
            d = Math.Abs(d);
            return a < d && d < b;
        }
    }
}
