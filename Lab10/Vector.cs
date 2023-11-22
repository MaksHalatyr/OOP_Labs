namespace Lab_10;

public class Vector//Клас вектору
{
    private double[] values;// за основу взято масив

    public Vector(int length)
    {
        values = new double[length];
    }

    public Vector(double[] values)
    {
        this.values = values;
    }

    public int Length//метод який повертає довжину
    {
        get { return values.Length; }
    }
    //доступ по індексу
    public double this[int index]
    {
        get { return values[index]; }
        set { values[index] = value; }
    }
    //public static Vector operator =(Vector v1, double value)// "=" не можливо перенавантажити
    //{
    //    for (int i=0; i<v1.Length; i++)
    //    {
    //        v1[i] = value;
    //    }
    //    return v1;
    //}

    public static bool operator ==(Vector v1, Vector v2)//перенавантажуєм оператор == 
    {
        if (ReferenceEquals(v1, v2))
            return true;
        if (v1 is null || v2 is null)
            return false;
        return v1.values.Equals(v2.values);
    }

    public static bool operator !=(Vector v1, Vector v2)//перенавантажуєм оператор != 
    {
        return !(v1 == v2);
    }
    public void Print()
    {
        foreach (double v in values)
        {
            Console.WriteLine(v.ToString());
        }
    }
}