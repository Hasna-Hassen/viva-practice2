using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    internal class Clothing:Product
    {
        public Clothing(string productID, string name, double price) : base(productID, name, price) { }

        public override void CalculateDiscountedPrice()
        {
            base.CalculateDiscountedPrice();
            double discountedPrice = Price * 0.8; // 20% discount
            Console.WriteLine($"Original Price: {Price}, Discounted Price: {discountedPrice}");
        }
    }
}
