namespace Lab5.Task1;

//інтерфейс фігури
public interface IFigure
{
    void DisplayType(); // Метод, що виводить на екран тип фігури
    void DisplayArea(); // Метод, що виводить на екран площу фігури
    double FirstDimension { get; set; } // Властивість для першого лінійного розміру фігури
    double SecondDimension { get; set; } // Властивість для другого лінійного розміру фігури
    void DisplayDiagonalLength(); // Метод, що виводить на екран довжину діагоналі фігури
}

// Інтерфейс IColoredFigure успадковує IFigure
public interface IColoredFigure : IFigure
{
    string Color { get; set; } // Властивість для кольору фігури
    void DisplayColor(); // Метод, що виводить на екран колір фігури
}

// Клас Rectangle реалізує IFigure
public class Rectangle : IFigure
{
    //властивості вимірів х,у
    public double FirstDimension { get; set; }
    public double SecondDimension { get; set; }

    //реалізації методів
    public void DisplayType()
    {
        Console.WriteLine("Rectangle");
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Area: {FirstDimension * SecondDimension}");
    }

    public void DisplayDiagonalLength()
    {
        Console.WriteLine($"Diagonal Length: {Math.Sqrt(FirstDimension * FirstDimension + SecondDimension * SecondDimension)}");
    }
}

// Клас ColoredRectangle реалізує IColoredFigure
public class ColoredRectangle : IColoredFigure
{
    //властивості вимірів та кольору
    public double FirstDimension { get; set; }
    public double SecondDimension { get; set; }
    public string Color { get; set; }

    //реалізації методів
    public void DisplayType()
    {
        Console.WriteLine("Colored Rectangle");
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Area: {FirstDimension * SecondDimension}");
    }

    public void DisplayDiagonalLength()
    {
        Console.WriteLine($"Diagonal Length: {Math.Sqrt(FirstDimension * FirstDimension + SecondDimension * SecondDimension)}");
    }

    public void DisplayColor()
    {
        Console.WriteLine($"Color: {Color}");
    }
}