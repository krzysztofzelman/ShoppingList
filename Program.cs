List<string> products = new List<string>();
    decimal total = 0;
while (true)
{
    Console.WriteLine("Product name (or 'end'");
    string name = Console.ReadLine() ?? "" ; 

    if (name == "end")
    {
        break;
    }
    Console.WriteLine("Price");
    decimal price = decimal.Parse(Console.ReadLine()); 
    
    products.Add($"{name} - {price}");
    total = total + price;
}
Console.WriteLine();

foreach (string product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine($"Total: {total}"); 