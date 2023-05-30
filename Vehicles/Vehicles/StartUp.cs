using System;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split().ToArray();
            string[] input2 = Console.ReadLine().Split().ToArray();
            string[] input3 = Console.ReadLine().Split().ToArray();

            var car = new Car(double.Parse(input1[1]), double.Parse(input1[2]), double.Parse(input1[3]));
            var truck = new Truck(double.Parse(input2[1]), double.Parse(input2[2]), double.Parse(input2[3]));
            var bus = new Bus(double.Parse(input3[1]), double.Parse(input3[2]), double.Parse(input3[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                string action = command[0];
                string vehicle = command[1];
                double amount = double.Parse(command[2]);

                try
                {
                    if (action == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            if (car.CanDrive(amount))
                            {
                                car.Drive(amount);
                                Console.WriteLine($"Car travelled {amount} km");
                            }

                            else
                            {
                                Console.WriteLine($"Car needs refueling");
                            }

                        }

                        else if (vehicle == "Truck")
                        {

                            if (truck.CanDrive(amount))
                            {
                                truck.Drive(amount);
                                Console.WriteLine($"Truck travelled {amount} km");
                            }

                            else
                            {
                                Console.WriteLine($"Truck needs refueling");
                            }
                        }

                        else if (vehicle == "Bus")
                        {
                            bus.IsEmpty = false;

                            if (bus.CanDrive(amount))
                            {
                                bus.Drive(amount);
                                Console.WriteLine($"Bus travelled {amount} km");
                            }

                            else
                            {
                                Console.WriteLine($"Bus needs refueling");
                            }
                        }
                    }

                    else if (action == "Refuel")
                    {
                        if (vehicle == "Car")
                        {
                            car.Refuel(amount);
                        }

                        else if (vehicle == "Truck")
                        {
                            truck.Refuel(amount);
                        }

                        else if (vehicle == "Bus")
                        {
                            bus.Refuel(amount);
                        }
                    }

                    else if (action == "DriveEmpty")
                    {
                        bus.IsEmpty = true;

                        if (bus.CanDrive(amount))
                        {
                            bus.Drive(amount);
                            Console.WriteLine($"Bus travelled {amount} km");
                        }

                        else
                        {
                            Console.WriteLine($"Bus needs refueling");
                        }
                    }
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
