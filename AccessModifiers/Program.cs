// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

internal class Greeter : IGreeter
{
    internal string Greet(string person)
    {
        return $"Hello, {person}";
    }
}

internal interface IGreeter
{
    internal string Greet(string person);
}