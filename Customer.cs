namespace Alexs_Cafe;

public class Customer
{
    public List<String> OrderList = [];
    public string FirstName;
    public string LastName;
    public string Email;

    public void SetOrder(List<String> userOrder)
    {
        this.OrderList = userOrder;
    }

    public List<String> GetOrder()
    {
        return OrderList;
    }

    public void SetFName(string firstName)
    {
        this.FirstName = firstName;
    }

    public String GetFName()
    {
        return FirstName;
    }

    public void SetLName(string lastName)
    {
        this.LastName = lastName;
    }

    public String GetLName()
    {
        return LastName;
    }

    public void SetEmail(string email)
    {
        this.Email = email;
    }

    public String GetEmail()
    {
        return Email;
    }
}