using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    class Program
    {
        /// <summary>
        /// Main class for Structural
        /// Builder Design Pattern.
        /// </summary>
        static void Main(string[] args)
        {

            // Create director and builders
            CarBuilder car;
            Garage garage = new Garage();

            // Create 3 different cars
            car = new SedanCarBuilder();
            garage.Construct(car);
            car.getCar.Show();

            car = new SportCarBuilder();
            garage.Construct(car);
            car.getCar.Show();

            car = new BreakCarBuilder();
            garage.Construct(car);
            car.getCar.Show();

            Console.ReadKey();
        }
    }
}
