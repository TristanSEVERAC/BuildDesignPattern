using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    /// <summary>
    /// The 'ConcreteBuilder' class called SedanCarBuilder
    /// </summary>
    class SedanCarBuilder : CarBuilder
    {
        public SedanCarBuilder()
        {
            car = new Car("Sedan"); 
        }

        public override void buildBodyStyle()
        {
            car["body"] = "length : 202.9, width : 7602, height : 60.7";
        }

        public override void buildBreaks()
        {
            car["breaks"] = "four wheel disc brakes: two ventilated";
        }

        public override void buildEngine()
        {
            car["engine"] = "3.5L Duramax V6 DOHC";
        }

        public override void buildFuelType()
        {
            car["fuelType"] = "Gasoline 19 MPC City, 29 MPG Highway";
        }

        public override void buildPower()
        {
            car["power"] = "285 hp @ 6,500 rpm; 253 ft lb of torque";
        }

        public override void buildSeats()
        {
            car["seats"] = "front seat center armrest.rear seat center";
        }

        public override void buildWindows()
        {
            car["windows"] = "Laminated side windows.Fixed rear windows";
        }
    }
}
