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
<<<<<<< Updated upstream
            InputData inputData = new InputData(new List<Tick>
            {
                new Tick("Computer, Computer", 100),
                new Tick("Computer, Lamp, Freese", 140)
            });
=======
            Console.WriteLine("Я работаю!!!");
            var x = new Device(1, Type.Freese);
            Console.WriteLine(x.Number);
            Statistic.AddElement(x);
            x = new Device(1, Type.Freese);
            Console.WriteLine(x.Number);
>>>>>>> Stashed changes
            Console.ReadLine();
        }
    }
}
