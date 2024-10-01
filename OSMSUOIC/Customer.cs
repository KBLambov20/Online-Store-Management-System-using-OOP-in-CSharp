namespace OSMSUOIC;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Customer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void DisplayCustomerDetails()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}
