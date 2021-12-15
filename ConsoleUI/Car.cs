using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : vehicle
    {
        public bool HasTrunk { get; set; } 
        public override void driveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} in an abstract method, it is a {GetType().BaseType.Name}"); 
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual(); 
        }
    }
}
