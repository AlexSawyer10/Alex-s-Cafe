namespace Alexs_Cafe;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        Order.Menu();
        Order.UserOrder();
    }

    private static void Welcome()
    {
        Console.WriteLine("Welcome to Alex's Cafe, what would you like to order?");
        Console.Write(Environment.NewLine);
    }
    
}
