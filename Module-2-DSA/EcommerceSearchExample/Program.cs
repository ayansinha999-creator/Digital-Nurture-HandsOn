class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class SearchMethods
{
    public static Product LinearSearch(Product[] products, string nameToFind)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].ProductName == nameToFind)
            {
                return products[i];
            }
        }
        return null;
    }

    public static Product BinarySearch(Product[] sortedProducts, string nameToFind)
    {
        int low = 0;
        int high = sortedProducts.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int comparison = sortedProducts[mid].ProductName.CompareTo(nameToFind);

            if (comparison == 0)
            {
                return sortedProducts[mid];
            }
            else if (comparison < 0)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(1, "Apple", "Fruit"),
            new Product(2, "Banana", "Fruit"),
            new Product(3, "Carrot", "Vegetable"),
            new Product(4, "Mango", "Fruit"),
            new Product(5, "Potato", "Vegetable")
        };

        Product foundLinear = SearchMethods.LinearSearch(products, "Mango");
        if (foundLinear != null)
        {
            Console.WriteLine("Linear Search found: " + foundLinear.ProductName);
        }
        else
        {
            Console.WriteLine("Linear Search: not found");
        }

        Product foundBinary = SearchMethods.BinarySearch(products, "Mango");
        if (foundBinary != null)
        {
            Console.WriteLine("Binary Search found: " + foundBinary.ProductName);
        }
        else
        {
            Console.WriteLine("Binary Search: not found");
        }
    }
}
