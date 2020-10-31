﻿using System;
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
                new Tick("Computer 2", 100),
                new Tick("Computer 3", 150),
                new Tick("Lamp 3, Computer 3", 200)
            });

            for(int i = 0; i < 3; i++)
                Manager.Update(inputData);
            Console.ReadLine();
        }
    }
}
