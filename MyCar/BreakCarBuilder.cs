using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    /// <summary>
    /// The 'ConcreteBuilder' class called BreakCarBuilder
    /// </summary>
    class BreakCarBuilder : CarBuilder
    {
        public BreakCarBuilder()
        {
            car = new Car("Break");
        }

        public override void buildBodyStyle()
        {
            car["body"] = "length : 250.4, width : 8000, height : 62.3";
        }

        public override void buildBreaks()
        {
            car["breaks"] = "four wheel disc brakes: two ventilated";
        }

        public override void buildEngine()
        {
            car["engine"] = "4.0L Duramax ecoboost DOHC";
        }

        public override void buildFuelType()
        {
            car["fuelType"] = "Gasoline 24 MPC City, 32 MPG Highway";
        }

        public override void buildPower()
        {
            car["power"] = "200 hp @ 6,400 rpm; 253 ft lb of torque";
        }

        public override void buildSeats()
        {
            car["seats"] = "Three front seats, center armrest.rear, two seat center";
        }

        public override void buildWindows()
        {
            car["windows"] = "Laminated side windows.Fixed rear windows";
        }
    }
}
