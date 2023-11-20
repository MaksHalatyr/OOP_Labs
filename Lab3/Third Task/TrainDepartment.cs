namespace Lab_3.Third_Task;

public class TrainDepartment : Time //наслідємо від часу
{
    //поле номеру поїзду
    public int TrainNumber;
    //поле шляху
    public string Way;
    //поле часу
    public TimeOnly TimeDep;

    //конструктор класу
    public TrainDepartment(int TrainNumber, string Way, int hours, int minutes, int seconds) : base(hours, minutes, seconds)//наслідємо базовий конструктор класу тайм
    {
        this.TrainNumber = TrainNumber;
        this.Way = Way;
        TimeDep = new TimeOnly(hours, minutes, seconds);
    }
    //метод виведення інформації на консоль
    public override void Print() => Console.WriteLine($"Поїзд із номером {TrainNumber} шляхом до {Way} відправляється в {TimeDep}");
    //метод визначення часу до відправлення
    public void TimeToDep()
    {
        TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
        if (currentTime > TimeDep)
        {
            Console.WriteLine("Поїзд вже відправився, ви спізнились");
        }
        else
        {
            TimeSpan timeToDeparture = TimeDep - currentTime;
            Console.WriteLine($"Поїзд {TrainNumber} до населеного пункту {Way} відправляється через {timeToDeparture.Minutes} хв");
        }
    }
}
