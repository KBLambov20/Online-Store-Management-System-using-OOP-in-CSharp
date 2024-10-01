namespace OSMSUOIC;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public event Action<string> OutOfStockEvent;

    public Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void DeductStock(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            if (Stock == 0)
            {
                OutOfStockEvent?.Invoke($"{Name} is now out of stock!");
            }
        }
    }

    public abstract void DisplayProductDetails();
}

public class PhysicalProduct : Product
{
    public PhysicalProduct(string name, decimal price, int stock) : base(name, price, stock) { }

    public override void DisplayProductDetails()
    {
        Console.WriteLine($"{Name}: ${Price}, Stock: {Stock}");
    }
}

public class DigitalProduct : Product
{
    public DigitalProduct(string name, decimal price, int stock) : base(name, price, stock) { }

    public override void DisplayProductDetails()
    {
        Console.WriteLine($"{Name}: ${Price} (Digital)");
    }
}
