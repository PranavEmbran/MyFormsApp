// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Newtonsoft.Json;

public class Product
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public List<string> Tags { get; set; }
}


public class Program
{
    public static void Main()
    {
        // try
        // {

        string json = "{\"Name\" : \"Laptop\" , \"Price\" : \"49999.99\", \"Tags\" : [\"Electronics\", \"Computers \"]}";

        // Product product = JsonConvert.DeserializeObject<Product>(json)!; // ! here is the null forgiving operator. Use the null‑forgiving operator only if you’re sure JSON always has those fields
        Product product = JsonConvert.DeserializeObject<Product>(json);

        Console.WriteLine($"Product : {product.Name}, Price : {product.Price}, Tags : {string.Join(", ", product.Tags)}");
        // }
        // catch (Exception ex)
        // {
        // Console.WriteLine($"Error : {ex.Message}");
        // }


        Product newProduct = new Product
        {
            Name = "Smartphone",
            Price = 15999.99m,
            Tags = new List<string> { "Electronics", "Mobile" },
        };
        string newJson = JsonConvert.SerializeObject(newProduct, Formatting.Indented);
        Console.WriteLine($"SerializedAttribute JSON : \n{newJson}");

    }
}
