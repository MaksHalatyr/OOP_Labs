using Lab4;

//підключаєио кодування для корректного виведення символів на консоль
Console.OutputEncoding = System.Text.Encoding.UTF8;
//створюємо новий екземпляр країни
var country = new Country("Україна", "Київ");

// Додавання областей до держави
var kievRegion = new Region("Київська область", "Київ", 28124);
var kievCity = new City("Київ", "Київський район", 1234);
kievRegion.AddDistrict(kievCity);
country.AddRegion(kievRegion);

var lvivRegion = new Region("Львівська область", "Львів", 21833);
var lvivCity = new City("Львів", "Львівський район", 987);
lvivRegion.AddDistrict(lvivCity);
country.AddRegion(lvivRegion);

// Виклик методів через поліморфізм
Console.WriteLine("Столиця: " + country.GetCapital());
Console.WriteLine("Кількість областей: " + country.GetRegionsCount());
Console.WriteLine("Площа: " + country.GetArea() + " км²");
Console.WriteLine("Обласні центри:");
country.PrintRegionalCenters();

//друге завдання створюємо екземпляр менеджера трикутників
Console.WriteLine("");
TriangleManager manager = new TriangleManager();
manager.CreateAndCalculateTriangles(5);
manager.DisplayResults();