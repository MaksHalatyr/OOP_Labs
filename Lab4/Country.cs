namespace Lab4;

//Клас країни
public class Country
{
    //приватні поля ім'я країни, столиця, список областей
    private string name;
    private string capital;
    private List<Region> regions = new List<Region>();

    //конструтор країни
    public Country(string name, string capital)
    {
        this.name = name;
        this.capital = capital;
    }

    //додати область
    public void AddRegion(Region region)
    {
        regions.Add(region);
    }

    //метод який повертає столицю
    public string GetCapital()
    {
        return capital;
    }

    //метод повертає кількість областей
    public int GetRegionsCount()
    {
        return regions.Count;
    }

    //метод повертає площу
    public double GetArea()
    {
        double totalArea = 0;
        foreach (var region in regions)
        {
            totalArea += region.GetArea();
        }
        return totalArea;
    }

    //метод виводить на консоль обласні центри
    public void PrintRegionalCenters()
    {
        foreach (var region in regions)
        {
            Console.WriteLine(region.GetRegionalCenter());
        }
    }
}
