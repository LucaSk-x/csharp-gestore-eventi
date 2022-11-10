// See https://aka.ms/new-console-template for more information
internal class GestoreEventiExpection : Exception
{
    public GestoreEventiExpection()
    {
    }

    public GestoreEventiExpection(string? message) : base(message)
    {
    }
}