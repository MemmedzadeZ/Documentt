using Documentt;

Console.WriteLine("Enter the type of document program(basic,pro ve ya expert)hamisini balaca herfle yazmalisiniz: ");

string programType = Console.ReadLine().ToLower();


DocumentProgram documentProg;

if (programType == "basic")
{
    documentProg = new DocumentProgram();

}
else if(programType == "pro")
{
    documentProg = new DocumentProgram();
}
else if(programType =="expert")
{
    documentProg = new DocumentProgram();
}
else
{
    Console.WriteLine("Program bittdi");
    return;

}

documentProg.OpenDocumnet();
documentProg.EditDocument();
documentProg.SaveDocument();





