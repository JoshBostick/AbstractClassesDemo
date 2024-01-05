using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSaddleBags { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle does not start");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Runs fine");
        }
    }
}
