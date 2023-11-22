namespace Lab_10;
public class CharSet//Клас чарсету
{
    private HashSet<char> elements = new HashSet<char>();//за основу взятий хешсет

    public void Add(char element)//додати елеменет
    {
        elements.Add(element);
    }

    // Перенавантаження операції додавання елемента в множину
    public static CharSet operator +(CharSet charSet, char element)
    {
        charSet.elements.Add(element);
        return charSet;
    }

    // Перенавантаження операції перетину множин
    public static CharSet operator *(CharSet charSet1, CharSet charSet2)
    {
        CharSet result = new CharSet();
        foreach (char element in charSet1.elements)
        {
            if (charSet2.elements.Contains(element))
            {
                result.elements.Add(element);
            }
        }
        return result;
    }

    // Перенавантаження операції отримання потужності множини
    public static implicit operator int(CharSet charSet)
    {
        return charSet.elements.Count;
    }
    public void Print()
    {
        foreach (char v in elements)
        {
            Console.WriteLine(v);
        }
    }
}