namespace Lab4;

//клас району
public class District
{
    //поля які описують район ім'яб рай центрб площа
    protected string name;
    protected string districtCenter;
    protected double area;

    //конструктор району
    public District(string name, string districtCenter, double area)
    {
        this.name = name;
        this.districtCenter = districtCenter;
        this.area = area;
    }

    //метод повертає районний центр
    public virtual string GetDistrictCenter()
    {
        return $"Центр району {name}: {districtCenter}";
    }

    //метод для площі
    public virtual double GetArea()
    {
        return area;
    }
}
