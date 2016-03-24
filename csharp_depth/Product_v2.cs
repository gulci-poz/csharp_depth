using System.Collections.Generic;

namespace csharp_depth
{
    // C# v2

    public class Product_v2
    {
        // prywatne settery

        string name;
        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }

            private set
            {
                price = value;
            }
        }

        public Product_v2(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // generics, silnie typowane kolekcja, kompilator wie, że lista zawiera produkty

        public static List<Product_v2> GetSampleProducts()
        {
            List<Product_v2> list = new List<Product_v2>();
            list.Add(new Product_v2("West Side Story", 9.99m));
            list.Add(new Product_v2("Assassins", 14.99m));
            list.Add(new Product_v2("Frogs", 13.99m));
            list.Add(new Product_v2("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
