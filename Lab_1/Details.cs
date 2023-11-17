public class Details
{
    public int Amount { get; set; } = 0;
    public double Weight { get; set; } = 0;
    public string Name { get; set; } = "";
    public string Type { get; set; } = "";

    public Details(string name, string type, int amount, double weight)
    {
        Amount = amount;
        Weight = weight;
        Name = name;
        Type = type;
    }
    public void Print()
    {
        Console.WriteLine($"Name = {Name}, Type = {Type}, Amount = {Amount}, Weight of 1 part (g) = {Weight}");
    }
}
