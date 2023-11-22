Console.OutputEncoding = System.Text.Encoding.UTF8; //localization
//Task 1
static string ReplaceZerosAndOnes(string input, int startPosition)//Метод який замінює нулі та одиниці
{
    char[] chars = input.ToCharArray();
    for (int i = startPosition; i < input.Length; i++)
    {
        if (chars[i] == '0')
            chars[i] = '1';
        else if (chars[i] == '1')
            chars[i] = '0';
    }
    return new string(chars);
}
string input = "01010100101";
int startPosition = 3; // Позиція, з якої починається заміна
string result = ReplaceZerosAndOnes(input, startPosition);
Console.WriteLine("Результат: " + result);

//Task 2
static void DayToDate(DateTime targetDate)//Метод для перевірки днів до вказаної дати
{
    DateTime currentDate = DateTime.Now;

    if (targetDate < currentDate)
    {
        Console.WriteLine("Ця дата вже минула.");
    }
    else
    {
        TimeSpan remainingDays = targetDate - currentDate;
        Console.WriteLine($"Днів до вказаної дати: {remainingDays.Days}");
    }
}
DateTime Date = new DateTime(2023, 12, 19);
DayToDate(Date);

//Task 3
static void StrWithDate(string input)//Метод відповідно до 3 завдання
{
    string[] dateStrings = input.Split(',').Select(s => s.Trim()).ToArray();

    DateTime earliestDate = DateTime.MaxValue;
    DateTime latestDate = DateTime.MinValue;
    List<DateTime> springDates = new List<DateTime>();

    foreach (string dateString in dateStrings)
    {
        DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy", null);

        if (date < earliestDate)
            earliestDate = date;

        if (date > latestDate)
            latestDate = date;

        if (date.Month >= 3 && date.Month <= 5)
            springDates.Add(date);
    }

    Console.WriteLine($"Рік з найменшим номером: {earliestDate.Year}");
    Console.WriteLine("Весняні дати:");
    foreach (DateTime springDate in springDates)
    {
        Console.WriteLine(springDate.ToString("dd.MM.yyyy"));
    }
    Console.WriteLine($"Найпізніша дата: {latestDate.ToString("dd.MM.yyyy")}");
}
string inp = "24.02.2022, 17.04.2023, 19.12.2023";
StrWithDate(inp);