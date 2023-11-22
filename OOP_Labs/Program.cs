using Lab6;

//створюємо нашу колекцію типу компонентів
CollectionType<ComponentsInfo> components = new CollectionType<ComponentsInfo>();
//заповнюємо довільними елементами
components.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100.0 });
components.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100.0 });
components.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100 });
components.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100 });
components.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100 });
components.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100 });
//створюємо ще одну колекцію
CollectionType<ComponentsInfo> comp = new CollectionType<ComponentsInfo>();
//додаємо елементи
comp.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100.0 });
comp.AddItem(new ComponentsInfo { Name = "SomeComponent", Type = "q", Amount = 10, Weight = 100.0 });

//створюємо масив колекцій
CollectionType<ComponentsInfo>[] collectionArr = { components, comp };
//запит для пошуку кількості списків кількість об'єктів яких рівна 2
var query1 = collectionArr
    .Where(x => x.Count == 2)
    .Count();
//запит для пошуку об'єктів кількість яких компонентів рівна 10
var query2 = collectionArr
    .Select(x => x.Where(z => z.Amount == 10));

//запит для пошуку об'єктів кількість яких компонентів меньше 5
var query3 = collectionArr
    .Select(x => x.Where(x => x.Amount <5))
    .OrderDescending();

//запит для пошуку об'єктів кількість яких компонентів більше 5
var query4 = collectionArr
    .FirstOrDefault(list => list.Any(obj => obj.Amount > 5));

//запит для пошуку об'єктів вага яких рівна 100
var query5 = collectionArr
    .Any(list => list.Any(x => x.Weight == 100));

List<string> strings = new List<string>();
strings.Add("apple");
strings.Add("banana");
strings.Add("cherry");
strings.Add("date");
strings.Add("grape");

// Виведення рядків
Console.WriteLine("Strings:");
foreach (var str in strings)
{
    Console.WriteLine(str);
}

// Пошук рядків, що містять "a"
var containsA = strings.Where(s => s.Contains("a"));

Console.WriteLine("Strings containing 'a':");
foreach (var str in containsA)
{
    Console.WriteLine(str);
}

// Підрахунок кількості рядків довжини n
int n = 5;
var countN = strings.Count(s => s.Length == n);

Console.WriteLine($"Number of strings with length {n}: {countN}");

// Сортування у зростаючому порядку
var ascendingSort = strings.OrderBy(s => s);

Console.WriteLine("Ascending Sort:");
foreach (var str in ascendingSort)
{
    Console.WriteLine(str);
}

// Сортування у спадаючому порядку
var descendingSort = strings.OrderByDescending(s => s);

Console.WriteLine("Descending Sort:");
foreach (var str in descendingSort)
{
    Console.WriteLine(str);
}
