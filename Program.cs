
using System.Runtime.InteropServices;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public bool Sold { get; set; }
}

List<Product> products = new List<Product>()
{
};

List<Cars> cars = new List<Cars>()
{
    new Cars()
    {
        Make = "Toyota",
        Model = "Civic ",
        Sold = false
    }    new Cars()
    {
        Make = "Honda",
        Model = "accord",
        Sold = True
    },
    new Cars()
    {
        Make = "Honda",
        Model = "accord",
        Sold = True
    }
}

List<Product> products = new List<Product>()
{
    new Product()
    { 
        Name = "Football", 
        Price = 15, 
        Sold = false
    },
    new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12, 
        Sold = false
    }
};

Console.WriteLine($"{i + 1}. {products[i].Name}");
Product chosenProduct = products[response - 1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");


//datetime
DateTime newYears2023 = new DateTime(2023, 1, 1);

const newYears2023 = new Date(2023, 0, 1);

DateTime noonOnJanuaryFirst = new DateTime(2023, 1, 1, 12, 0, 0);