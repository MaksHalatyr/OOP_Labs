//Task 1
static void CreateDir(string path)//Створити диреторію
{
    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
}
static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
{
    // Get information about the source directory
    var dir = new DirectoryInfo(sourceDir);

    // Check if the source directory exists
    if (!dir.Exists)
        throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

    // Cache directories before we start copying
    DirectoryInfo[] dirs = dir.GetDirectories();

    // Create the destination directory
    Directory.CreateDirectory(destinationDir);

    // Get the files in the source directory and copy to the destination directory
    foreach (FileInfo file in dir.GetFiles())
    {
        string targetFilePath = Path.Combine(destinationDir, file.Name);
        file.CopyTo(targetFilePath);
    }

    // If recursive and copying subdirectories, recursively call this method
    if (recursive)
    {
        foreach (DirectoryInfo subDir in dirs)
        {
            string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
            CopyDirectory(subDir.FullName, newDestinationDir, true);
        }
    }
}
string lab_8 = @"D:\OOP_Lab08",
Groupe = @"D:\OOP_Lab08\KNms1-b23",
Surname = @"D:\OOP_Lab08\Halatyr",
Source = @"D:\OOP_Lab08\Source",
Reports = @"D:\OOP_Lab08\Reports",
Texts = @"D:\OOP_Lab08\Texts";

CreateDir(lab_8);
CreateDir(Groupe);
CreateDir(Surname);
CreateDir(Source);
CreateDir(Reports);
CreateDir(Texts);

string Txt = Surname + @"\Texts",
Sourc = Surname + @"\Source",
Rep = Surname + @"\Reports";
CopyDirectory(Texts, Txt, true);
CopyDirectory(Source, Sourc, true);
CopyDirectory(Reports, Rep, true);

Directory.Move(Surname, Groupe + @"\Halatyr");

string directoryPath = @"D:\OOP_Lab08\KNms1-b23\Halatyr\Texts"; // Назва каталогу

try
{
    // Перевіримо, чи каталог існує
    if (Directory.Exists(directoryPath))
    {
        // Отримаємо інформацію про каталог
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

        // Створимо текстовий файл для збереження інформації
        using (StreamWriter writer = new StreamWriter(Path.Combine(directoryPath, "dirinfo.txt")))
        {
            // Запишемо інформацію в текстовий файл
            writer.WriteLine($"Інформація про каталог: {directoryInfo.FullName}");
            writer.WriteLine($"Дата створення: {directoryInfo.CreationTime}");
            writer.WriteLine($"Останні зміни: {directoryInfo.LastWriteTime}");
            writer.WriteLine($"Кількість файлів: {directoryInfo.GetFiles().Length}");
            writer.WriteLine($"Кількість підкаталогів: {directoryInfo.GetDirectories().Length}");
        }

        Console.WriteLine("Інформація про каталог збережена в файлі dirinfo.txt.");
    }
    else
    {
        Console.WriteLine("Каталог не існує.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Помилка: {ex.Message}");
}
//Task 2
try
{
    Console.Write("Введіть значення n: ");
    int n = int.Parse(Console.ReadLine());

    using (StreamWriter writer = new StreamWriter("g.txt"))
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / Factorial(i); // Обчислення суми 1/1! + 1/2! + ... + 1/i!
            int bi = (int)(i * sum);
            writer.WriteLine(bi);
        }
    }

    Console.WriteLine($"Дані були записані у файл g.txt.");
}
catch (Exception ex)
{
    Console.WriteLine($"Помилка: {ex.Message}");
}


// Метод для обчислення факторіалу
static int Factorial(int number)
{
    if (number == 0)
        return 1;
    else
        return number * Factorial(number - 1);
}