namespace OSMSUOIC;

public interface IPayment
{
    void ProcessPayment(decimal amount);
}

public class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Credit card payment processed for {amount:C2}");
    }
}

public class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"PayPal payment processed for {amount:C2}");
    }
}
