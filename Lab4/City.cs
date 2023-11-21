using System.Xml.Linq;

namespace Lab4;

public class City : District
{
    public City(string name, string districtCenter, double area) : base(name, districtCenter, area)
    {
    }

    //метод повертає gkjoe
    public override double GetArea()
    {
        return area;
    }
}
