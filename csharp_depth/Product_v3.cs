using System.Collections.Generic;

namespace csharp_depth
{
    // C# v3

    public class Product_v3
    {
        // automatycznie implementowane właściwości, wszędzie w kodzie używamy właściwości zamiast zmiennych

        public string Name { get; private set; }

        public decimal Price { get; private set; }

        // publiczny konstruktor zostaje na potrzeby tworzenia obiektu w zewnętrznym kodzie

        public Product_v3(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // uproszczona inicjalizacja, prywatny konstruktor bez parametrów, do inicjalizacji właściwości

        Product_v3() { }

        public static List<Product_v3> GetSampleProducts()
        {
            return new List<Product_v3>
            {
                new Product_v3 { Name = "West Side Story", Price = 9.99m },
                new Product_v3 { Name = "Assassins", Price = 14.99m },
                new Product_v3 { Name = "Frogs", Price = 13.99m },
                new Product_v3 { Name = "Sweeney Todd", Price = 10.99m }
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
