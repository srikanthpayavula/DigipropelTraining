using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Assmt_July
//{
//    class _07Jul_1
//    {
//        public static void Main(string[] args)
//        {
//            Car car = new Car(0);
//            Console.WriteLine("enter value for fuel");
//            int fuel = int.Parse(Console.ReadLine());
//            if (car.Refuel(fuel))
//            {
//                car.Drive();
//            }
//            Console.ReadLine();
//        }

//        public interface IVehicle
//        {
//            void Drive();
//            bool Refuel(int amount);
//        }

//        public class Car : IVehicle
//        {
//            public int Fuel { get; set; }

//            public Car(int fuel)
//            {
//                Fuel = fuel;
//            }

//            public void Drive()
//            {
//                if (Fuel > 0)
//                {
//                    Console.WriteLine("Driving");
//                }
//                else
//                {
//                    Console.WriteLine("No fuel");
//                }
//            }

//            public bool Refuel(int amount)
//            {
//                Fuel += amount;
//                return true;
//            }
//        }
//    }
//}


 //output 
 //enter value for fuel
 // 50
 // Driving
 // enter value for fuel
 //    0
 // No Fuel
 
