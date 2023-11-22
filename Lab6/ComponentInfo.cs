namespace Lab6;

public class ComponentsInfo : IComparable<ComponentsInfo>//Cтворюємо класс відповідно до варіанту
{
    public int Amount { get; set; } = 0; //властивість кількості
    public double Weight { get; set; } = 0; //властивість ваги
    public string Name { get; set; } = ""; //властивість імені
    public string Type { get; set; } = ""; //властивість типу

    public ComponentsInfo() { } //конструктор без параметрів
    public ComponentsInfo(string Name, string Type, int Amount, double Weight) //конструктор із параметрами
    {
        this.Name = Name;
        this.Type = Type;
        this.Amount = Amount;
        this.Weight = Weight;
    }
    public void Print() //метод прінт для виведення на консоль інформації нашого екземпляру
    {
        Console.WriteLine($"Name = {Name}, Type = {Type}, Amount = {Amount}, Weight of 1 part (g) = {Weight}");
    }

    //метод порівняння двох об'єктів за вагою
    public int CompareTo(ComponentsInfo? other) => Weight.CompareTo(other.Weight); 
}