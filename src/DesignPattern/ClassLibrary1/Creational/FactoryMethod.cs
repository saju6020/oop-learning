// Factory Method
abstract class Document
{
    public abstract void Print();
}

class Report : Document
{
    public override void Print() => Console.WriteLine("Printing a Report");
}

class Invoice : Document
{
    public override void Print() => Console.WriteLine("Printing an Invoice");
}

abstract class Creator
{
    public abstract Document CreateDocument();
}

class ReportCreator : Creator
{
    public override Document CreateDocument() => new Report();
}

class InvoiceCreator : Creator
{
    public override Document CreateDocument() => new Invoice();
}

// Client
class Program
{
    static void Main()
    {
        Creator creator = new ReportCreator();
        Document doc = creator.CreateDocument();
        doc.Print();
    }
}
