
string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

Console.WriteLine("Please enter a product name: ");

string response = Console.ReadLine().Trim();

while (string.IsNullOrEmpty(response))
{
    Console.WriteLine("You didn't choose anything, try again!");
    response = Console.ReadLine();
}

Console.WriteLine($"You choose {response}");

Console.WriteLine(@"Products:
1. Football
2. Hockey Stick
3. Boomerang
4. Frisbee
5. Golf Putter");
Console.WriteLine("Please enter a product number: ");