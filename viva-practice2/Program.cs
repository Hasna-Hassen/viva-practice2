using System;
using viva_practice2;

//List<Vehicle> vehicles = new List<Vehicle>();

//Car c1 = new Car("C001", "Toyota Camry", 50.0, 5);
//MotorBike b1 = new MotorBike("B001", "Yamaha R15", 30.0, 150);

//vehicles.Add(c1);
//vehicles.Add(b1);

//foreach(Vehicle vehicle in vehicles)
//{
//    Console.WriteLine(vehicle.ToString());
//}

List<Product> products = new List<Product>();

Electronics e1 = new Electronics("E001", "Smartphone", 500.0);
Clothing c1 = new Clothing("C001", "T-Shirt", 20.0);

products.Add(e1);
products.Add(c1);

foreach (Product product in products)
{
    product.CalculateDiscountedPrice();
}