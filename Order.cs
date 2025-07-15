namespace Alexs_Cafe;

public class Order
{
    
    public void Menu()
    {
        Console.WriteLine("Cheese Pizza- 2.99");
        Console.WriteLine("Pepperoni Pizza- 3.99");
        Console.WriteLine("Veggie Pizza- 3.10");
        Console.WriteLine("Black Coffee- 1.99");
    }

    List<String> userInputList = new();

    public Customer UserOrder(Customer customer1)
    {
        bool validInputCheck = false;
        
        while (!validInputCheck)
        {

            List<String> availableOptions = ["cheese pizza", "pepperoni pizza", "veggie pizza", "black coffee"];
        
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
                    validInputCheck = true;
                }
            }
            
        }
        customer1.SetOrder(userInputList);
        
        return customer1;
    }

}