using System;

namespace SharpWasher
{
    class Program
    {
        delegate void Wash(Car car);

        static void Main(string[] args)
        {
            Console.WriteLine("Look at a dirty car. If a car is clean you will see 'True'");
            Garage garage = new Garage();
            Car car1 = new Car("AUDI A6");
            Car car2 = new Car("BMW X8");
            Car car3 = new Car("VAZ 3310");
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);
            foreach (var car in garage)
            {
                Console.WriteLine(car.name + " " + car.clean);
            }

            Console.WriteLine("Lets wash all our cars. If car is clean you will see 'True'");
            foreach (var car in garage)
            {
                Washer washer = new Washer();
                Wash del = washer.Wash;
                del(car);
                Console.WriteLine(car.name + " " + car.clean);
            }
        }
    }
}