namespace Lab_3.First_Task;

public class Professor : Person // клас професор наслідується від персон
{
    public string Subject {  get; set; }
    public Professor(string FirstName, string LastName, int Age, string Subject) 
        : base(FirstName, LastName, Age)//використання базового конструктора суперкласу
    {
        this.Subject = Subject;
    }

    public void Explain() => Console.WriteLine("I'm explaining");//метод відповідно до завдання
}
