namespace Lab_10;

public class CharList//Створення адт чарлісту
{
    private List<char> elements = new List<char>();
    public void Add(char element)//Додаємо елемент до поля ліст
    {
        elements.Add(element);
    }
    public void RemoveAt(int k)//видаляємо конкретний елемент
    { 
        elements.RemoveAt(k); 
    }
    //доступ до елементу
    public char this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }
    public static CharList operator +(CharList left, CharList right)//перенавантажуєм оператор +
    {
        CharList newList = new CharList();
        foreach (char element in left.elements)
        {
            newList.Add(element);
        }
        foreach (char element in right.elements)
        {
            newList.Add(element);
        }
        return newList;
    }

    public static bool operator ==(CharList left, CharList right)//перенавантажуєм ==
    {
        if (ReferenceEquals(left, right))
            return true;
        if (left is null || right is null)
            return false;
        return left.elements.Equals(right.elements);
    }
    public static bool operator !=(CharList left, CharList right)//перенавантажуєм !=
    {
        return !(left == right);
    }

    public override bool Equals(object obj)//метод порівняння
    {
        if (obj is CharList otherList)
            return this == otherList;
        return false;
    }

    public override int GetHashCode()//метод для повернення хеш коду екземпляру
    {
        return elements.GetHashCode();
    }
    public void Print()
    {
        foreach (char v in elements)
        {
            Console.WriteLine(v);
        }
    }
}
