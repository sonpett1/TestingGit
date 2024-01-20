namespace TestingGit;

class Program
{
    static void Main(string[] args)
    {
        // my name
        Console.WriteLine("My name is Sondre");
    }
    // method that prints numbers up to input number
    static void CountTo(int num)
    {
        for (int i = 1; i <= num; i++)
        {Console.WriteLine($"{i}");}
    }
}