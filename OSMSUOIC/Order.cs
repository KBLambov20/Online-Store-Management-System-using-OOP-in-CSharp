namespace OSMSUOIC;

public interface IOrder
{
    bool CreateOrder(Customer customer, Product product, int quantity);
    void ApplyDiscount(IDiscount discount);
    void CompleteOrder();
}

public class PhysicalProductOrder : IOrder
{
    private Customer _customer;
    private Product _product;
    private int _quantity;
    private decimal _finalPrice;

    public bool CreateOrder(Customer customer, Product product, int quantity)
    {
        if (product.Stock >= quantity)
        {
            _customer = customer;
            _product = product;
            _quantity = quantity;
            _finalPrice = product.Price * quantity;
            product.DeductStock(quantity);
            return true;
        }
        Console.WriteLine($"Insufficient stock for {product.Name}. Available: {product.Stock}");
        return false;
    }

    public void ApplyDiscount(IDiscount discount)
    {
        _finalPrice -= discount.CalculateDiscount(_finalPrice);
        Console.WriteLine($"Discount applied. Final price: {_finalPrice:C2}");
    }

    public void CompleteOrder()
    {
        Console.WriteLine($"Order completed for {_quantity} unit(s) of {_product.Name}. Product shipped.");
    }
}
