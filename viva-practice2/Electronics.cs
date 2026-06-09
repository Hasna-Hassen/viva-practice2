using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace viva_practice2
{
    internal class Electronics:Product
    {
        public Electronics(string productID, string name, double price) : base(productID, name, price) { }

        public override void CalculateDiscountedPrice()
        {
            base.CalculateDiscountedPrice();
            double discountedPrice = Price * 0.9; // 10% discount
            Console.WriteLine($"Original Price: {Price}, Discounted Price: {discountedPrice}");
        }
    }
}
