using Energy.Forms;
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
                new Tick("Lamp 3, Computer 2", 206),
                new Tick("Lamp 3, Computer 2, Freese 1", 306)
            });


            for(int i = 0; i < 10; i++)
                Manager.Update(inputData);

            var form = new DataUsegeDevice();
            Application.Run(form);

            Console.ReadLine();
        }
    }
}
