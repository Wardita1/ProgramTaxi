using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Latihan;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek Taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DrivName = "Wardita";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}