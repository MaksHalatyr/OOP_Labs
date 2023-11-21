namespace Lab5.Task2;

//інтерфейс інструмент
public interface IInstrument
{
    //метод плей
    void Play();
    //властивість ключ
    string KEY { get; }
}

// Клас Гітара, що реалізує Інструмент
public class Guitar : IInstrument
{
    //кількість струн
    public int NumberOfStrings { get; set; }

    //реалізація методу плей
    public void Play()
    {
        Console.WriteLine($"Playing Guitar with {NumberOfStrings} strings");
    }

    //ключ музичний
    public string KEY { get; } = "До мажор";
}

// Клас Барабан, що реалізує Інструмент
public class Drum : IInstrument
{
    //властивість розмір
    public int Size { get; set; }

    //реалізація методу плей
    public void Play()
    {
        Console.WriteLine($"Playing Drum with size {Size}");
    }

    //ключ
    public string KEY { get; } = "До мажор";
}

// Клас Труба, що реалізує Інструмент
public class Trumpet : IInstrument
{
    //властивість діаметру
    public double Diameter { get; set; }

    //реалізація методу плей
    public void Play()
    {
        Console.WriteLine($"Playing Trumpet with diameter {Diameter}");
    }

    //ключ
    public string KEY { get; } = "До мажор";
}
