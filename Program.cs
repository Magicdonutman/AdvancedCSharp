using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_StevenVoth
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            Car myOtherCar;

            myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "F150", 1998, "Black");
            Console.WriteLine(myThirdCar);
            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
              myCar.Make,
              myCar.Model,
              myCar.Year,
              myCar.Color);

            myOtherCar = null;

            /*
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);
            */
            myCar = null;

            Console.ReadLine();
        }
    }

    class Car
    {

        public Car()
        {
            this.Make = "Nissan";

        }
        public Car(string make, string model, int year, string color)
        {
            Make = Make;
            Model = Model;
            year = Year;
            color = Color;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public static void MyMethod()
        {
            Console.WriteLine("Hello from my Static Method!");
        }
    }


}
