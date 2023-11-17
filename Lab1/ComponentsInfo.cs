namespace Lab1;
public class ComponentsInfo //Cтворюємо класс відповідно до варіанту
{
    public int Amount { get; set; } = 0; //властивість кількості
    public double Weight { get; set; } = 0; //властивість ваги
    public string Name { get; set; } = ""; //властивість імені
    public string Type { get; set; } = ""; //властивість типу

    public ComponentsInfo(string name, string type, int amount, double weight) //конструктор із параметрами
    {
        Amount = amount;
        Weight = weight;
        Name = name;
        Type = type;
    }
    public void Print() //метод прінт для виведення на консоль інформації нашого екземпляру
    {
        Console.WriteLine($"Name = {Name}, Type = {Type}, Amount = {Amount}, Weight of 1 part (g) = {Weight}");
    }
}
