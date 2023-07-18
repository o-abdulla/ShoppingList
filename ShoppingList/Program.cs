// Shopping List

Console.WriteLine("Welcome to the shopping list app");

// setting up dictionary with items and prices

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("milk", 4.99m);
menu.Add("bread", 2.50m);
menu.Add("cereal", 3.98m);
menu.Add("juice", 5.99m);
menu.Add("chicken", 23.45m);
menu.Add("bleach", 6.19m);
menu.Add("detergent", 18.69m);
menu.Add("soap", 3.99m);

// Displaying the dictionary for the user to see
foreach (KeyValuePair<string, decimal> kvp in menu)
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");

// creating a list using a loop to adding input to shopping cart

List<string> item = new List<string>();



bool runProgram = true;
while (runProgram)
{




    Console.WriteLine("Please enter an item name");
    string input = Console.ReadLine().ToLower().Trim();

    if (menu.ContainsKey(input))
    {
        item.Add(input);
        Console.WriteLine($"You've added {input} to the shopping list");


    }
    else
    {
        Console.WriteLine("Item doesn't exist, please try again.");
        continue;
    }



    while (true)
    {
        Console.WriteLine("Would you like to add another item to the shopping list? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {

            if (item.Count > 0)
            {

                decimal sum = 0;
                foreach (string i in item)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(menu[i]);
                    sum += menu[i];

                }
                sum = sum / item.Count;
                Console.WriteLine($"The average of the prices ordered is {sum}");

            }
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, try again");
        }
    }
}






