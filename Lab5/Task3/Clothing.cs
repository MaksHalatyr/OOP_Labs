namespace Lab5.Task3;

public abstract class Clothing//Клас одежі 
{
    public ClothingSize Size { get; set; }//Розмір одежі властивість
    public decimal Cost { get; set; }//Ціна властивість
    public string Color { get; set; }//Колір властивість

    public Clothing(ClothingSize size, decimal cost, string color)//Конструтор із параметрами
    {
        Size = size;
        Cost = cost;
        Color = color;
    }
}
