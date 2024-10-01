public class Program
{
    public static void Main()
    {
        // Create a customer
        ICustomer customer = new Customer("John", "Doe");
        
        // Create products
        PhysicalProduct laptop = new PhysicalProduct ("Laptop", 1000.00m, 5);
        PhysicalProduct smartphone = new PhysicalProduct("Smartphone", 700.00m, 2);
        
        // Subscribe to the out-of-stock event
        laptop.OutOfStockEvent += message Console.WriteLine($" [EVENT] {message}"); 
        smartphone.OutOfStockEvent += message Console.WriteLine($" [EVENT] {message}");
        
        // Create orders
        IOrder laptopOrder = new PhysicalProductOrder();
        IOrder smartphoneOrder = new PhysicalProductOrder();
        
        // Place orders with validation and discounts
        if (laptopOrder.CreateOrder(customer, laptop, 3))
        {
            // Apply a 10% discount to the laptop order
            laptopOrder.ApplyDiscount(new PercentageDiscount(10));
            laptopOrder.CompleteOrder();
        }

        Console.WriteLine();
        // Second order for smartphones
        if (smartphoneOrder.CreateOrder (customer, smartphone, 2))
        {
            smartphoneOrder.ApplyDiscount (new Fixed Discount (50));
            smartphoneOrder.CompleteOrder();
        }
            
        if (!laptopOrder.CreateOrder (customer, laptop, 3))
        {
            Console.WriteLine("Failed to create second laptop order due to insufficient stock.");
        }
    }
}