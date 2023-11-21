namespace Lab5.Task3;

public class Pants : Clothing, IMaleClothing, IFemaleClothing
{
    public Pants(ClothingSize size, decimal cost, string color) : base(size, cost, color)
    {
    }

    public void DressMan()
    {
        Console.WriteLine($"Men's Pants - Size: {Size}, Color: {Color}, Cost: {Cost}");
    }

    public void DressWoman()
    {
        Console.WriteLine($"Women's Pants - Size: {Size}, Color: {Color}, Cost: {Cost}");
    }
}
