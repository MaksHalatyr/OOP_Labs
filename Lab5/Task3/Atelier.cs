namespace Lab5.Task3;

public class Atelier
{
    public void DressWoman(IFemaleClothing[] clothes)//одягнути жінку
    {
        Console.WriteLine("Dressing Woman:");
        foreach (var item in clothes)
        {
            item.DressWoman();
        }
    }

    public void DressMan(IMaleClothing[] clothes)//одягнути чоловіка
    {
        Console.WriteLine("Dressing Man:");
        foreach (var item in clothes)
        {
            item.DressMan();
        }
    }
}
