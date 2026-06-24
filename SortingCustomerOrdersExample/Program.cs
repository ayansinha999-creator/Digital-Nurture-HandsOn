class Order
{
    public int OrderId;
    public string CustomerName;
    public double TotalPrice;

    public Order(int id, string name, double price)
    {
        OrderId = id;
        CustomerName = name;
        TotalPrice = price;
    }
}

class SortingMethods
{
    public static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    public static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order temp1 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp1;

        return i + 1;
    }

    public static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);

            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    public static void DisplayOrders(Order[] orders)
    {
        foreach (Order order in orders)
        {
            Console.WriteLine(
                order.OrderId + " " +
                order.CustomerName + " " +
                order.TotalPrice
            );
        }
    }
}

class Program
{
    static void Main()
    {
        Order[] bubbleOrders = new Order[]
        {
            new Order(1, "Ayush", 5000),
            new Order(2, "Rahul", 2000),
            new Order(3, "Priya", 8000),
            new Order(4, "Neha", 3000)
        };

        Order[] quickOrders = new Order[]
        {
            new Order(1, "Ayush", 5000),
            new Order(2, "Rahul", 2000),
            new Order(3, "Priya", 8000),
            new Order(4, "Neha", 3000)
        };

        Console.WriteLine("Original Orders:");
        SortingMethods.DisplayOrders(bubbleOrders);

        SortingMethods.BubbleSort(bubbleOrders);
        Console.WriteLine("\nAfter Bubble Sort:");
        SortingMethods.DisplayOrders(bubbleOrders);

        SortingMethods.QuickSort(quickOrders, 0, quickOrders.Length - 1);
        Console.WriteLine("\nAfter Quick Sort:");
        SortingMethods.DisplayOrders(quickOrders);
    }
}