
var logger = new Logger();

var james = new Person("James", "Montemagno", logger);

james.PrintName();


public class Person(string firstName, string lastName, ILogger logger)
{
    public string FullName => $"{firstName} {lastName}";

    public void PrintName()
    {
        logger.Log(FullName);
    }

}

public interface ILogger
{
    void Log(string message);
}

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
