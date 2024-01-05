using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Undefined";
        public string Make { get; set; } = "Undefined";
        public string Model { get; set; } = "Undefined";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual () 
        {
            Console.WriteLine("Default");
        }
    }
}
