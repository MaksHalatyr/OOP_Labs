namespace Lab5.Task3;

public class Tie : Clothing, IMaleClothing
{
    public Tie(ClothingSize size, decimal cost, string color) : base(size, cost, color)
    {
    }

    public void DressMan()
    {
        Console.WriteLine($"Men's Tie - Size: {Size}, Color: {Color}, Cost: {Cost}");
    }
}
