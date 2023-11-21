namespace Lab4;

//клас трикутника
class TTriangle
{
    //поля трикутника
    protected double a, b, c;

    //конструктор із параметрами трикутника
    public TTriangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    //метод обчислення площі
    public virtual double CalculateArea()
    {
        // Формула Герона для обчислення площі трикутника
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    //метод обчислення периметру
    public virtual double CalculatePerimeter()
    {
        return a + b + c;
    }
}

//класс рівностороннього трикутника
class TEquilateralTriangle : TTriangle
{
    public TEquilateralTriangle(double side) : base(side, side, side)
    {
    }
}

//клас прямокутного трикутника
class TRectangleTriangle : TTriangle
{
    public TRectangleTriangle(double a, double b) : base(a, b, Math.Sqrt(a * a + b * b))
    {
    }
}

//класс рівнобедренного трикутника
class TIsoscelesTriangle : TTriangle
{
    public TIsoscelesTriangle(double baseSide, double equalSide) : base(baseSide, equalSide, equalSide)
    {
    }
}

//класс управління нашими трикутниками
public class TriangleManager
{
    //створюємо ліст типу трикутника
    private List<TTriangle> triangles = new List<TTriangle>();

    //метод для створення і обчислення трикутників
    public void CreateAndCalculateTriangles(int n)
    {
        //використовуючи рандом вибираємо тип трикутника
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int triangleType = random.Next(3); // Випадковим чином обираємо тип трикутника

            switch (triangleType)
            {
                case 0:
                    triangles.Add(new TEquilateralTriangle(random.Next(1, 10)));
                    break;
                case 1:
                    triangles.Add(new TRectangleTriangle(random.Next(1, 10), random.Next(1, 10)));
                    break;
                case 2:
                    triangles.Add(new TIsoscelesTriangle(random.Next(1, 10), random.Next(1, 10)));
                    break;
            }
        }
    }

    //метод виведення результату на консоль
    public void DisplayResults()
    {
        double totalArea = 0;
        double totalPerimeter = 0;

        foreach (var triangle in triangles)
        {
            totalArea += triangle.CalculateArea();
            totalPerimeter += triangle.CalculatePerimeter();
        }

        Console.WriteLine($"Сума площ трикутників: {totalArea:F2}");
        Console.WriteLine($"Сума периметрів трикутників: {totalPerimeter:F2}");
    }
}
