
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

while (response > 5 || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

// //figure out why im getting error on response

name = "Grace Hopper"; //totally fine
name = null; //totally fine - strings can be null
name = 586; //compiler error. 586 is an int, not a string. 

age = 42; //totally fine
age = null // compiler error! a regular int cannot be null.
age = "ten"; //compiler error - "ten" is a string

ready = true; //totally fine
ready = "true"; //compiler error, "true" is a string, not a bool
ready = null; //compiler error - bools cannot be null.

List<string> names = new List<string>();
