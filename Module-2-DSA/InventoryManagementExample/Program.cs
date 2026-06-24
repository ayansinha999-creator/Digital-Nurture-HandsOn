using System.Collections.Generic;

class Product
{
    public int ProductId;
    public string ProductName;
    public int Quantity;
    public double Price;

    public Product(int id, string name, int quantity, double price)
    {
        ProductId = id;
        ProductName = name;
        Quantity = quantity;
        Price = price;
    }
}

class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("Product added successfully.");
    }

    public void UpdateProduct(int productId, int newQuantity, double newPrice)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == productId)
            {
                product.Quantity = newQuantity;
                product.Price = newPrice;

                Console.WriteLine("Product updated successfully.");
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    public void DeleteProduct(int productId)
    {
        Product productToDelete = null;

        foreach (Product product in products)
        {
            if (product.ProductId == productId)
            {
                productToDelete = product;
                break;
            }
        }

        if (productToDelete != null)
        {
            products.Remove(productToDelete);
            Console.WriteLine("Product deleted successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DisplayProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine(
                product.ProductId + " " +
                product.ProductName + " " +
                product.Quantity + " " +
                product.Price
            );
        }
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(
            new Product(1, "Laptop", 10, 50000)
        );

        inventory.AddProduct(
            new Product(2, "Mouse", 25, 500)
        );

        Console.WriteLine("\nInventory:");
        inventory.DisplayProducts();

        inventory.UpdateProduct(1, 15, 55000);

        Console.WriteLine("\nAfter Update:");
        inventory.DisplayProducts();

        inventory.DeleteProduct(2);

        Console.WriteLine("\nAfter Delete:");
        inventory.DisplayProducts();
    }
}