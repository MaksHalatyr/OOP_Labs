namespace Lab7;

//клас бібліотеки
public class Library
{
    public string Name { get; set; }

    public void GenerateDescription()
    {
        Console.WriteLine($"Library: {Name}");
    }
}

//клас департаменту
public class Department
{
    public string GenreName { get; set; }
    public int NumberOfPublications { get; set; }

    public void GenerateDescription()
    {
        Console.WriteLine($"Department (Genre): {GenreName}, Number of Publications: {NumberOfPublications}");
    }
}

//клас публікації
public class Publication
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    public void GenerateDescription()
    {
        Console.WriteLine($"Publication: {Title}, Author: {Author}, Year: {PublicationYear}");
    }
}

//клас книги
public class Book : Publication
{
    public string Summary { get; set; }

    public new void GenerateDescription()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}, Year: {PublicationYear}, Summary: {Summary}");
    }
}

//клас журналу
public class Journal : Publication
{
    private List<string> articles = new List<string>();

    public void AddArticle(string article)
    {
        articles.Add(article);
    }

    public new void GenerateDescription()
    {
        Console.WriteLine($"Journal: {Title}, Author: {Author}, Year: {PublicationYear}");
        Console.WriteLine("Articles:");
        foreach (var article in articles)
        {
            Console.WriteLine($"- {article}");
        }
    }
}

//класи винятків
public class BookException : Exception
{
    public BookException(string message) : base(message)
    {
    }
}

public class RikVydannyaException : Exception
{
    public RikVydannyaException(string message) : base(message)
    {
    }
}
