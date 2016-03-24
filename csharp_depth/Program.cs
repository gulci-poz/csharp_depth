using System;
using System.Collections;

namespace csharp_depth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, in depth!");

            ArrayList products = Product_v1.GetSampleProducts();
            products.Sort(new ProductNameComparer());

            foreach (Product_v1 product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
