abstract class Document
{
    public abstract void Open();
}

class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}

class PdfDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening PDF Document");
    }
}

abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

class WordDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}

class PdfDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new PdfDocument();
    }
}

class Program
{
    static void Main()
    {
        DocumentFactory factory1 = new WordDocumentFactory();
        Document doc1 = factory1.CreateDocument();
        doc1.Open();

        DocumentFactory factory2 = new PdfDocumentFactory();
        Document doc2 = factory2.CreateDocument();
        doc2.Open();
    }
}