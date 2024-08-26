
public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public bool Sold { get; set; }
}

List<Product> products = new List<Product>()
{
};

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