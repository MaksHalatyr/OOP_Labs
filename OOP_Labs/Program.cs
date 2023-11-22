// Приклад використання
using Lab9;

Console.OutputEncoding = System.Text.Encoding.UTF8;
EquationDelegate equation = x => x * x - 4; // Рівняння: x^2 - 4 = 0

double a = 0.0; // Ліва границя проміжку
double b = 3.0; // Права границя проміжку
double epsilon = 0.0001; // Точність

try
{
    double root = BisectionMethod.FindRoot(equation, a, b, epsilon);

    if (!double.IsNaN(root))
    {
        Console.WriteLine($"Корінь рівняння: {root}");
    }
    else
    {
        Console.WriteLine("На заданому проміжку корінь не знайдено.");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Помилка: {ex.Message}");
}