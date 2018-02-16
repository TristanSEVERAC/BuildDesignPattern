using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    /// <summary>
    /// The 'ConcreteBuilder' class called SportCarBuilder
    /// </summary>
    class SportCarBuilder : CarBuilder
    {
        public SportCarBuilder()
        {
            car = new Car("Sport");
        }

        public override void buildBodyStyle()
        {
            car["body"] = "length : 192.3, width : 75.5, height : 54.2";
        }

        public override void buildBreaks()
        {
            car["breaks"] = "turning circle : 37.5";
        }

        public override void buildEngine()
        {
            car["engine"] = "3.6L V6 DOHC and variable valve timing";
        }

        public override void buildFuelType()
        {
            car["fuelType"] = "Gasoline 17 MPG City, 28 MPG Highway, 20 MPG combined";
        }

        public override void buildPower()
        {
            car["power"] = "323 hp @ 6,800 rpm; 278 ft lb of torque";
        }

        public override void buildSeats()
        {
            car["seats"] = "Driver sports front seat with one power adjustements manual height";
        }

        public override void buildWindows()
        {
            car["windows"] = "Front windows with one-touch on two windows";
        }
    }
}
