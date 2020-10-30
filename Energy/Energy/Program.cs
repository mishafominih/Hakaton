using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData inputData = new InputData(new List<Tick>
            {
                new Tick("Computer, Computer", 100),
                new Tick("Computer, Lamp, Freese", 140)
            });
            Console.ReadLine();
        }
    }
}
