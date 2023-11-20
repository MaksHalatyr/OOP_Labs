namespace Lab_3.First_Task;

public class Student : Person //клас стцденту наслідується від персон
{
    public int grade { get; set; }
    public Student(string FirstName, string LastName, int grade)
        : base(FirstName, LastName)//базовий конструктор
    {
        this.grade = grade;
    }
    //Методи відповідно до завдання
    public int SetAge(int age) => Age = age;
    public void ShowAge() => Console.WriteLine("Age " + Age);
    public void Study() => Console.WriteLine("I'm studying");
}
