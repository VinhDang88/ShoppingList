Dictionary<string, double> menu = new Dictionary<string, double>()
{
    ["Chicken"] = 3,
    ["Toast"] = 2,
    ["Cheese"] = 4,
    ["Rice"] = 3,
    ["Fish"] = 1,
    ["Pie"] = 2,
    ["Icecream"] = 3,
    ["Beef"] = 2,
};

Console.WriteLine("Welcome to Super Fresh Organic Market?");
Console.WriteLine("Item \t Price");
Console.WriteLine("=======================================");
foreach (KeyValuePair<string, double> kvp in menu)
{
    Console.WriteLine($"{kvp.Key} - ${kvp.Value} ");
}

List<string> shoppingList = new List<string>();
bool runExercise = true;
while (runExercise)
{
    Console.WriteLine("What item would you like to order?");
    string choice = Console.ReadLine();

    if (menu.ContainsKey(choice))
    {
        Console.WriteLine($"Adding {choice} to cart at ${menu[choice]}");
        shoppingList.Add(choice);
    }

    else
    {
        Console.WriteLine("Sorry, we don't have that item. Please try again.");
        
    }

    while (true)
    {
        Console.WriteLine("Would you like to order anything else? y/n");
        string choice2 = Console.ReadLine();
        if (choice2 == "y")
        {
            break;
        }
        else if (choice2 == "n")
        {
            runExercise = false;
            break;  
        }
        else
        {
            Console.WriteLine("Bad input");
        }
    }
  
}

Console.WriteLine("Thanks for your order!");
Console.WriteLine("Here's what you got:");


double total = 0;
double minPrice = 9999;
double maxPrice = 0;
string minName = "";
string maxName = "";

foreach (string item in shoppingList)
{
    Console.WriteLine($"{item} ${menu[item]}");
    total += (menu[item]);

    if (menu[item] < minPrice)
    {
        minPrice = menu[item];
        minName = item;
    }
    if(menu[item] > maxPrice)
    {
        maxPrice = menu[item];
        maxName = item;
    }    
}
Console.WriteLine($"Total = ${total}");
Console.WriteLine($"The cheapest item {minName}, ${minPrice}");
Console.WriteLine($"The most expensive item {maxName}, ${maxPrice}");


/*
while (runExercise == true)
{
    Console.WriteLine("Enter some text:");
    prompt.Add(Console.ReadLine());
    foreach (string s in prompt)
    {
        Console.Write(s + " ");
    }
    Console.WriteLine();
*/


/*  shoppingList.Add(choice);
    foreach (string s in shoppingList)
    {
        Console.WriteLine(s + "");
    }
    Console.WriteLine(); */




/* {
 "Chicken",
 "Toast",
 "Cheese",
 "Rice",
 "Fish",
 "Pie",
 "Icecream",
 "Beef",
}; */


//shoppingList.Add(choice);
//foreach (string s in shoppingList)
//{
//Console.WriteLine($" {s} - ${menu[choice]}");
//}



/* foreach (string item in shoppingList)
{
    Console.WriteLine($"{item} ${menu[item]}");
    total += (menu[item]);

    if (menu[item] < minPrice)
    {
        minPrice = menu[item];
        minName = item;
    }
    if(menu[item] > maxPrice)
    {
        maxPrice = menu[item];
        maxName = item;
    }    
} */


/* for(int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine($"{shoppingList[i]} - ${menu[shoppingList[i]]}");
    total += menu[shoppingList[i]];
} */