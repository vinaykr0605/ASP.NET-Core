namespace mvc_app.Models;

public class Books
{
    public string[] AllBooks { get; set; }
    public string FaviouriteBook { get; set; }

    public Books()
    {
        AllBooks = ["Book 1", "Book 2", "Book 3"];
        FaviouriteBook = AllBooks[1];
    }

}