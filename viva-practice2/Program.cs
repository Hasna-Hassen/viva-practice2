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

//List<Product> products = new List<Product>();

//Electronics e1 = new Electronics("E001", "Smartphone", 500.0);
//Clothing c1 = new Clothing("C001", "T-Shirt", 20.0);

//products.Add(e1);
//products.Add(c1);

//foreach (Product product in products)
//{
//    product.CalculateDiscountedPrice();
//}

List<BankAccount> bankAccounts = new List<BankAccount>();
CurrentAccount c1 = new CurrentAccount(1001, "John Doe", 1000.0);
SavingsAccount s1 = new SavingsAccount(1002, "Jane Doe", 2000.0);
CurrentAccount c2 = new CurrentAccount(1003, "Alice Smith", 1500.0);
SavingsAccount s2 = new SavingsAccount(1004, "Bob Johnson", 3000.0);

bankAccounts.Add(c1);
bankAccounts.Add(s1);
bankAccounts.Add(c2);
bankAccounts.Add(s2);

foreach (BankAccount account in bankAccounts)
{
    Console.WriteLine($"Account Number: {account.AccountNumber}, Holder Name: {account.HolderName}, Balance: {account.Balance}, Interest: {account.CalculateInterest()}");
}