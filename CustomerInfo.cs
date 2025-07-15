namespace Alexs_Cafe;

public class CustomerInfo
{
    public void UserFirstName(Customer customer1)
    {
        
        Console.WriteLine("What is your first name?: ");
        
        String firstName = Console.ReadLine()!;
        
        customer1.SetFName(firstName);
    }

    public void UserLastName(Customer customer1)
    {
        Console.WriteLine("What is your last name?: ");
        
        String lastName = Console.ReadLine()!;
        
        customer1.SetLName(lastName);
    }

    public void UserEmail(Customer customer1)
    {
        Console.WriteLine("What is your email?: ");
        
        String email = Console.ReadLine()!;
        
        customer1.SetEmail(email);
    }
}