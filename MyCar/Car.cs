using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    /// <summary>
    /// The object class called Car
    /// </summary>
    class Car
    {
        private string _carType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>(); 

        // Constructor
        public Car(string carType)
        {
            this._carType = carType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------ {0} ------------------------", _carType);
            Console.WriteLine(" Body : {0}", _parts["body"]);
            Console.WriteLine(" Power : {0}", _parts["power"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" Breaks : {0}", _parts["breaks"]);
            Console.WriteLine(" Seats : {0}", _parts["seats"]);
            Console.WriteLine(" Windows : {0}", _parts["windows"]);
            Console.WriteLine(" FuelType : {0}", _parts["fuelType"]);
        }
    }
}
