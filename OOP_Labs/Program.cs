using Lab2;
using System.Text;

//підключаємо кодування для коректного виведення на консоль
Console.OutputEncoding = UTF8Encoding.UTF8;

//Створюємо масив об'єктів нашого типу 2.2, одразу записуємо їх в масив 2.3

ComponentsInfo[] compArr =
{
    new ComponentsInfo ("Фланець", "З", 3, 450),
    new ComponentsInfo ("Перехідник", "К", 8, 74),
    new ComponentsInfo ("Станина", "Про", 1, 117050),
    new ComponentsInfo ("Фланець", "З", 3, 450),
    new ComponentsInfo ("Перехідник", "К", 8, 74),
    new ComponentsInfo ("Станина", "Про", 1, 117050),
    new ComponentsInfo ("Фланець", "З", 3, 450),
    new ComponentsInfo ("Перехідник", "К", 8, 74),
    new ComponentsInfo ("Станина", "Про", 1, 117050),
    new ComponentsInfo ("Фланець", "З", 3, 450),
};

//2,4 Знаходимо об'єкти вага яких більше тисячі та виводимо на консоль через цикл
var query1 = compArr.Where(x => x.Weight > 1000);
foreach (var linq1 in query1)
{
    Console.WriteLine($"Ім'я об'єкту {linq1.Name}");
}

//2,4 Знаходимо об'єкти кількість яких більше 3
var query2 = compArr.Where(x => x.Amount > 3);
foreach (var linq2 in query2)
{
    Console.WriteLine($"Ім'я об'єкту {linq2.Name}");
}

//Перевірка кількості існуючих об'єктів у масиві 2,5
Console.Write("Введіть значення ");
int num = int.Parse(Console.ReadLine());
if(compArr.Length > num) Console.WriteLine("Кількість об'єктів більше заданого значення");
else Console.WriteLine("Кількість об'єктів меньше рівно заданому значенню");