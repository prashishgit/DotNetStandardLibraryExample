using CoreClassLibrary;
using DotnetStandardClassLibrary;
using FrameworkClassLibrary;
using System;

namespace CoreApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test testone = new Test();
            string google = testone.PrintName("Google");
            Console.WriteLine(google);
            //Console.ReadLine();
            Food food = new Food();
            food.PrintFoorName();
            Planet jupiter = new Planet();
            jupiter.PrintPlanetName();
            Vehicle vehicle = new Vehicle();    
            vehicle.PrintVehicleName();
        }
        

    }
    public class Test
    {
        public string PrintName(string name)
        {
            return name + " Microsoft";

        }
    }
}
