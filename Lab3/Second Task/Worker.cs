namespace Lab_3.Second_Task;

public class Worker : User
{
    public double Salary { get; set; }
    public Worker(string name, int age, double Salary) : base(name, age)
    {
        this.Salary = Salary;
    }
    public void Print() => Console.WriteLine($"Name = {name} Age = {age} Salary = {Salary}");
}
