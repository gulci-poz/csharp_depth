using System.Collections;


namespace csharp_depth
{
    // C# v1

    public class Product_v1
    {
        // publiczne gettery - settery też muszą być publiczne

        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
        }

        public Product_v1(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        // w czasie kompilacji nie ma informacji o zawartości ArrayList, można dodać do listy cokolwiek, np. string

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product_v1("West Side Story", 9.99m));
            list.Add(new Product_v1("Assassins", 14.99m));
            list.Add(new Product_v1("Frogs", 13.99m));
            list.Add(new Product_v1("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
