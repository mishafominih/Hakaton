using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Energy
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData inputData = new InputData(new List<Tick>
            {
                new Tick("Computer 2", 100),
                new Tick("Computer 2", 105),
                new Tick("Lamp 3, Computer 2", 205),
                new Tick("Lamp 3, Computer 2", 206)
            });

            for(int i = 0; i < 500; i++)
                Manager.Update(inputData);

            var menu = new Menu();

            Application.Run(menu);
            Console.ReadLine();
        }
    }
}
