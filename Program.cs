
// string greeting = @"Welcome to Thrown For a Loop
// Your one-stop shop for used sporting equipment";

// Console.WriteLine(greeting);

// Console.WriteLine("Please enter a product name: ");

// string response = Console.ReadLine().Trim();

// while (string.IsNullOrEmpty(response))
// {
//     Console.WriteLine("You didn't choose anything, try again!");
//     response = Console.ReadLine();
// }

// Console.WriteLine($"You choose {response}");

// Console.WriteLine(@"Products:
// 1. Football
// 2. Hockey Stick
// 3. Boomerang
// 4. Frisbee
// 5. Golf Putter");
// Console.WriteLine("Please enter a product number: ");

// while (response > 5 || response < 1)
// {
//     Console.WriteLine("Choose a number between 1 and 5!");
//     response = int.Parse(Console.ReadLine().Trim());
// }

// //figure out why im getting error on response
let names = [];

List<int> years = new List<int>()
{
    1985, 
    2022,
    1999,
    1976
};

let years = [
  1985, 
  2022,
  1999,
  1976
];

List<string> products = new List<string>()
{
    "Football",
    "Hockey Stick",
    "Boomerang",
    "Frisbee",
    "Golf Putter"
};

Console.WriteLine("Products:");

Console.WriteLine("Please enter a product number: ");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i]}");
}

