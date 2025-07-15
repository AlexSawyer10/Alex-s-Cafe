using System.Reflection;

namespace Alexs_Cafe;

public class Checkout
{
    public void DisplayOrder(Customer customer1)
    {
        Console.WriteLine($"This is your order: {string.Join(",",customer1.GetOrder())}");
    }

    public void DisplayFName(Customer customer1)
    {   
        Console.WriteLine($"This is your first name: {customer1.GetFName()}");
    }

    public void DisplayLName(Customer customer1)
    {
        Console.WriteLine($"This is your last name: {customer1.GetLName()}");
    }

    public void DisplayEmail(Customer customer1)
    {
        Console.WriteLine($"This is your email: {customer1.GetEmail()}");
    }

    public void WriteToFile(Customer customer1)
    {
        string filePath = "order.txt";
        
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"test");
            writer.WriteLine("First Name: " + customer1.GetFName());
            writer.WriteLine("Last Name: " + customer1.GetLName());
            writer.WriteLine("Email: " + customer1.GetEmail());
            writer.WriteLine("Order: " + string.Join(", ", customer1.GetOrder()));
        }
        string newOrderTxt = File.ReadAllText(filePath);
        Console.WriteLine("\nContents of the file:");
        Console.WriteLine( newOrderTxt);
    }
    
    
}