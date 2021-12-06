// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

internal class Greeter : IGreeter
{
    // <= Generates Severity	Error	CS0737	'Greeter' does not implement interface member 'IGreeter.Greet(string)'.
    // 'Greeter.Greet(string)' cannot implement an interface member because it is not public.
    //
    // Being explicit:
    //    internal string IGreeter.Greet(string person)
    //
    // also does not work.
    //
    // What works is making it public or giving no access modifier (also public).
    internal string Greet(string person)

    {
        return $"Hello, {person}";
    }
}

internal interface IGreeter
{
    internal string Greet(string person);
}
