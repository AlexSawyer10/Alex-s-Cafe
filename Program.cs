namespace Alexs_Cafe;

class Program
{
    static void Main(string[] args)
    {
        
        Order order = new Order();
        CustomerInfo customerInfo = new CustomerInfo();
        Customer customer1 = new Customer();
        Checkout checkout = new Checkout();

        Welcome();
   
        order.Menu();
        customer1 = order.UserOrder(customer1);
        customerInfo.UserFirstName(customer1);
        customerInfo.UserLastName(customer1);
        customerInfo.UserEmail(customer1);
        checkout.DisplayOrder(customer1);
        checkout.DisplayFName(customer1);
        checkout.DisplayLName(customer1);
        checkout.DisplayEmail(customer1);
        checkout.WriteToFile(customer1);
    }

    private static void Welcome()
    {
        Console.WriteLine("Welcome to Alex's Cafe, what would you like to order?");
        Console.Write(Environment.NewLine);
    }
    
}
