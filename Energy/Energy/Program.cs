
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                new Tick("Computer 3", 140),
                new Tick("Computer 4", 180),
                new Tick("Computer 5", 200),
                new Tick("Computer 4, Lamp 2", 200),
                new Tick("Computer 4, Lamp 2, Freese 1", 250),
                new Tick("Computer 4, Lamp 2, Freese 1, Condition 1", 350),
                new Tick("Computer 4, Lamp 2, Freese 1, Condition 1, DishWasher 2", 500)
            });


            for (int i = 0; i < 10; i++)
            {
                Manager.Update(inputData);
                Thread.Sleep(100);
            }

            var form = new Menu();
            Application.Run(form);

            Console.ReadLine();
        }
    }
}
