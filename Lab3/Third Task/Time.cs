namespace Lab_3.Third_Task;

public class Time
{
    //поля часу
    public int Hours;
    public int Minutes;
    public int Seconds;

    public Time(int hours, int minutes, int seconds) //конструктор класу
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    //метод який повертає секунди
    public int CountSeconds() => Seconds;

    //метод збільшення секунд на 5 одиниць
    public void TimeIncreaseBy5Sec()
    {
        Seconds += 5;
        Console.WriteLine("Час збільшено на 5 секунд");
    }

    //метод виведення часу
    public virtual void Print() => Console.WriteLine($"Time: {Hours}:{Minutes}:{Seconds}");
}
