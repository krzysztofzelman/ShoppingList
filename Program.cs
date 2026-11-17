List<string> products = new List<string>();
decimal total = 0;

while (true)
{
    Console.WriteLine("Product name (or 'end'):");
    string name = Console.ReadLine() ?? "";

    if (name == "end")
    {
        break;
    }

    Console.WriteLine("Price:");
    decimal price;
    while (true)
    {
        string priceText = (Console.ReadLine() ?? "").Replace(',', '.');
        if (decimal.TryParse(priceText, System.Globalization.CultureInfo.InvariantCulture, out price))
        {
            if (price <0)
            {
                Console.WriteLine("Price cannot be negative. Try again:");
                continue;
            }
            break;
        }
        Console.WriteLine("That is not a number. Try again:");
    }

    products.Add($"{name} - {price}");
    total = total + price;
}

Console.WriteLine();
int number = 1;

foreach (string product in products)
{
    Console.WriteLine($"{number}. {product}");
    number = number + 1;
}
Console.WriteLine($"Items: {products.Count}");
Console.WriteLine($"Total: {total}");
