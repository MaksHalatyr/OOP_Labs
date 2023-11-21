namespace Lab4;

//Класс області
public class Region
{
    //поля для імені, обл центруб площаб список районів області
    private string name;
    private string regionalCenter;
    private double area;
    private List<District> districts = new List<District>();

    //конструтор класу області
    public Region(string name, string regionalCenter, double area)
    {
        this.name = name;
        this.regionalCenter = regionalCenter;
        this.area = area;
    }

    // додати район до області
    public void AddDistrict(District district)
    {
        districts.Add(district);
    }

    //метод для знаходження обласного центру
    public virtual string GetRegionalCenter()
    {
        return $"Обласний центр {name}: {regionalCenter}";
    }

    //метод для знаходження площі
    public virtual double GetArea()
    {
        double totalArea = area;
        foreach (var district in districts)
        {
            totalArea += district.GetArea();
        }
        return totalArea;
    }
}
