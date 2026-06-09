using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    public abstract class Product
    {
        private string productID;
        private string name;
        private double price;

        public Product(string productID, string name, double price)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public virtual void CalculateDiscountedPrice()
        {

        }
    }
}
