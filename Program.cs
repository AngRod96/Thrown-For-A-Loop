
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