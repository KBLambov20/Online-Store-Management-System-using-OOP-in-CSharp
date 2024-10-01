namespace OSMSUOIC;

public interface IDiscount
{
    decimal CalculateDiscount(decimal price);
}

public class FixedDiscount : IDiscount
{
    private decimal _amount;
    public FixedDiscount(decimal amount)
    {
        _amount = amount;
    }

    public decimal CalculateDiscount(decimal price)
    {
        return _amount;
    }
}

public class PercentageDiscount : IDiscount
{
    private decimal _percentage;
    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public decimal CalculateDiscount(decimal price)
    {
        return price * (_percentage / 100);
    }
}
