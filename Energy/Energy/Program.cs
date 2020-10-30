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
            Console.WriteLine("Я работаю!!!");
            var x = new Device(1, Type.Freese);
            Console.WriteLine(x.Number);
            Console.ReadLine();
        }
    }
}
