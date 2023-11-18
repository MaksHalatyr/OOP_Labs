namespace Lab2;

public static class ArrayExtension//Статичний клас із методами розширення для масиву
{
    public static double ArithmeticMean(this int[] arr) //метод для знаходження середнього арифметичного у масиві
    {
        double arithmeticMean = 0;
        foreach (int i in arr) arithmeticMean += arr[i];
        arithmeticMean /= arr.Length;
        return arithmeticMean;
    }

    public static double GeometricMean(this int[] arr)//метод для знаходження геометричної різниці в масиві
    {
        double product = 1;
        foreach (var number in arr)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Array contains non-positive numbers");
            }

            product *= number;
        }

        return Math.Pow(product, 1.0 / arr.Length);
    }
}

