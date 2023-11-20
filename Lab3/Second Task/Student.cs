namespace Lab_3.Second_Task;

public class Student : User 
{
    private int scholarship { get; set; }
    private int grade { get; set; }
    public Student(string name, int age, int scholarship, int grade) : base(name, age)
    {
        this.scholarship = scholarship;
        this.grade = grade;
    }
}
