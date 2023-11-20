namespace Lab_3.Second_Task;

public enum DriverCategory //перечислення для категорій водіння
{
    A,
    B,
    C
}
public class Driver : Worker
{
    private int DriverExperienceYears;
    private DriverCategory category;
    public Driver(string name, int age, double Salary, int DriverExperienceYears, DriverCategory category) : base(name, age, Salary)
    {
        this.age = age;
        this.name = name;
        this.Salary = Salary;
        this.DriverExperienceYears = DriverExperienceYears;
        this.category = category;
    }
}
