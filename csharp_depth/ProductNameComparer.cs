using System.Collections;

namespace csharp_depth
{
    // C# v1

    // dostarczamy implementację klasy IComparer i metody Compare

    class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Product_v1 first = (Product_v1)x;
            Product_v1 second = (Product_v1)y;
            return first.Name.CompareTo(second.Name);
        }
    }
}

// ewentualnie Product_v1 może implementować IComparable, możemy wtedy zefiniować tylko jeden porządek sortowania