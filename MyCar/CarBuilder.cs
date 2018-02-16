using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    /// <summary>
    /// The 'Builder' abstract class called CarBuilder
    /// </summary>
    abstract class CarBuilder
    {
        public Car car;

        // Gets car instance
        public Car getCar
        {
            get { return car; }
        }

        // Abstract build methods
        public abstract void buildBodyStyle();
        public abstract void buildPower();
        public abstract void buildEngine();
        public abstract void buildBreaks();
        public abstract void buildSeats();
        public abstract void buildWindows();
        public abstract void buildFuelType();
    }

    
}
