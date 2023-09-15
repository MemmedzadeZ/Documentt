namespace Documentt;

class DocumentProgram
{

    public void OpenDocumnet()
    {
        Console.WriteLine("Document Opened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Exper versions");
    }
    public virtual void SaveDocument() 
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
}
