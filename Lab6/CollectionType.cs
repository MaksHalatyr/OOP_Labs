using System.Collections;

namespace Lab6;

//створюємо нашу колекцію на основі списку та реалізуєм в ній інтерфейс енумерабл
public class CollectionType<T> : IEnumerable<T>
{
    //список
    private List<T> items;

    // Конструктор
    public CollectionType()
    {
        items = new List<T>();
    }

    // Метод додавання елемента
    public void AddItem(T item)
    {
        items.Add(item);
    }

    // Метод видалення елемента
    public void RemoveItem(T item)
    {
        items.Remove(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Індексатор
    public T this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    // Властивість - кількість елементів
    public int Count
    {
        get { return items.Count; }
    }
}
