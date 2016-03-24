using System.Collections.Generic;

namespace csharp_depth
{
    // C# v4

    public class Product_v4
    {
        // powrót do niezmienialnych właściwości, nie możemy ich zmienić na zewnątrz (publicznie)

        readonly string name;
        public string Name { get { return name; } }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public Product_v4(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        // możemy podawać nazwy argumentów przy wywołaniu konstruktora

        public static List<Product_v4> GetSampleProducts()
        {
            return new List<Product_v4>
            {
                new Product_v4(name: "West Side Story", price: 9.99m),
                new Product_v4(name: "Assassins", price: 14.99m),
                new Product_v4(name: "Frogs", price: 13.99m),
                new Product_v4(name: "Sweeney Todd", price: 10.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
