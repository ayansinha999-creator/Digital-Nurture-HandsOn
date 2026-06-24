class Book
{
    public int BookId;
    public string Title;
    public string Author;

    public Book(int id, string title, string author)
    {
        BookId = id;
        Title = title;
        Author = author;
    }
}

class LibrarySearch
{
    public static Book LinearSearch(Book[] books, string title)
    {
        foreach (Book book in books)
        {
            if (book.Title == title)
            {
                return book;
            }
        }
        return null;
    }

    public static Book BinarySearch(Book[] books, string title)
    {
        int low = 0;
        int high = books.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int comparison = books[mid].Title.CompareTo(title);

            if (comparison == 0)
            {
                return books[mid];
            }
            else if (comparison < 0)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return null;
    }
}

class Program
{
    static void Main()
    {
        Book[] books = new Book[]
        {
            new Book(1, "C Programming", "Dennis Ritchie"),
            new Book(2, "Data Structures", "Mark Allen"),
            new Book(3, "Java Basics", "James Gosling"),
            new Book(4, "Python Guide", "Guido van Rossum")
        };

        Book foundLinear = LibrarySearch.LinearSearch(books, "Java Basics");
        if (foundLinear != null)
        {
            Console.WriteLine("Linear Search found: " + foundLinear.Title);
        }
        else
        {
            Console.WriteLine("Book not found using Linear Search");
        }

        Book foundBinary = LibrarySearch.BinarySearch(books, "Java Basics");
        if (foundBinary != null)
        {
            Console.WriteLine("Binary Search found: " + foundBinary.Title);
        }
        else
        {
            Console.WriteLine("Book not found using Binary Search");
        }
    }
}