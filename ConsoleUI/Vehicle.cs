using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class vehicle 
    {
        public string make { get; set; } = "generic Manufacturer";
        public string model { get; set; } = "generic model"; 
        public string year { get; set; } = "no year";

        public abstract void driveAbstract(); 

        public virtual void DriveVirtual()
        {
            Console.WriteLine("i'm driving my vehicle virtually."); 
        }
    }
}
