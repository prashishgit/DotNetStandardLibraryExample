using DotnetStandardClassLibrary;
using FrameworkClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Framework Project");
            Food food = new Food();
            food.PrintFoorName();
            Vehicle vehicle = new Vehicle();
            vehicle.PrintVehicleName(); 
            Console.ReadLine();
            //Planet earth = new Planet();
          
        }
    }
}
