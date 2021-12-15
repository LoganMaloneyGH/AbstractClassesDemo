using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class MotorCycle : vehicle
    {
        public bool HasSideKart { get; set; }
        public override void driveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name}. It goes vroom!"); 
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"I'm driving my {GetType().Name}. It goes vroom!");
        }
    }
}
