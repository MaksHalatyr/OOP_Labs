namespace Lab5.Task3;

public class Skirt : Clothing, IFemaleClothing
{
    public Skirt(ClothingSize size, decimal cost, string color) : base(size, cost, color)
    {
    }

    public void DressWoman()
    {
        Console.WriteLine($"Women's Skirt - Size: {Size}, Color: {Color}, Cost: {Cost}");
    }
}
