using Lab7;

Library library = new Library { Name = "City Library" };
library.GenerateDescription();

// використання класу Department
Department department = new Department { GenreName = "Fiction", NumberOfPublications = 100 };
department.GenerateDescription();

// використання класу Publication
Publication publication = new Publication { Title = "Sample Book", Author = "John Doe", PublicationYear = 2022 };
publication.GenerateDescription();

// використання класу Book з викликом методу, що може викликати виняток
Book book = new Book { Title = "C# Programming", Author = "Jane Doe", PublicationYear = 2023, Summary = "" };
book.GenerateDescription();

// використання класу Journal з додаванням статтей
Journal journal = new Journal { Title = "Tech Journal", Author = "Tech Writers", PublicationYear = 2023 };
journal.AddArticle("New Advances in AI");
journal.AddArticle("Web Development Trends");
journal.GenerateDescription();

// виклик конструктора класу Видання з викликом винятка RikVydannyaException
try
{
    Publication invalidPublication = new Publication { Title = "Invalid Book", Author = "Invalid Author", PublicationYear = 0 };
    invalidPublication.GenerateDescription();
}
catch (RikVydannyaException ex)
{
    Console.WriteLine($"Exception caught: {ex.Message}");
}

catch (BookException ex)
{
    Console.WriteLine($"Book Exception caught: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception caught: {ex.Message}");
}

