namespace Lab_3.Second_Task;

public class User//Клас юзер із методами і полями відповідно до завдання
{
    protected string name;
    protected int age;
    public User(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string getName() => this.name;
    public void setName(string name)
    {
        this.name = name;
    }
    public int getAge() => this.age;
    public void setAge(int age)
    {
        this.age = age;
    }
}
