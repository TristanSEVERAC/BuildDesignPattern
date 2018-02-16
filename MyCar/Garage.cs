using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{

    /// <summary>
    /// The 'Director' class called Garage
    /// </summary>
    class Garage
    {
        /// <summary>
        /// The Constructor
        /// </summary>
        public void Construct(CarBuilder car)
        {
            car.buildBodyStyle();
            car.buildFuelType();
            car.buildBreaks();
            car.buildEngine();
            car.buildPower();
            car.buildSeats();
            car.buildWindows();
        }
    }
}
