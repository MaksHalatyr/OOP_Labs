namespace Lab9;

// Делегат для представлення функції
public delegate double EquationDelegate(double x);

public class BisectionMethod
{
    // Метод для знаходження кореня рівняння методом поділу проміжку пополам
    public static double FindRoot(EquationDelegate equation, double a, double b, double epsilon)
    {
        if (equation(a) * equation(b) > 0)
        {
            throw new ArgumentException("Не виконується умова існування кореня на заданому проміжку.");
        }

        double result = double.NaN;
        while ((b - a) / 2 > epsilon)
        {
            double c = (a + b) / 2;
            if (equation(c) == 0.0)
            {
                result = c;
                break;
            }
            else if (equation(c) * equation(a) < 0)
            {
                b = c;
            }
            else
            {
                a = c;
            }
        }

        return result;
    }
}
