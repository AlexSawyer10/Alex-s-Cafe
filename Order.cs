namespace Alexs_Cafe;

public class Order
{
    Customer customer1 = new Customer();
    
    
    public void Menu()
    {
        Console.WriteLine("Cheese Pizza- 2.99");
        Console.WriteLine("Pepperoni Pizza- 3.99");
        Console.WriteLine("Veggie Pizza- 3.10");
        Console.WriteLine("Black Coffee- 1.99");
    }

    List<String> userInputList = new();

    public void UserOrder()
    {
        bool validInputCheck = false;
        
        while (!validInputCheck)
        {

            List<String> availableOptions = ["cheese Pizza", "pepperoni Pizza", "veggie Pizza", "black Coffee"];
        
            Console.WriteLine("Input your order here, comma separated.");
            String orderInput = Console.ReadLine()!.ToLower();

             userInputList = orderInput.Split(',').ToList();

            foreach (String userInput in userInputList)
            {
                if (!availableOptions.Contains(userInput))
                {
                  Console.WriteLine("Invalid Input! Please try again.");
                  break;
                }
                else
                {
                    Console.WriteLine("Your order will be right out!");
                    validInputCheck = true;
                }
            }
            
        }
        
        customer1.SetOrder(userInputList);
        
 
    }
}