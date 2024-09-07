namespace Soru08;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        string monthName = currentDate.ToString("MMMM");
        Console.WriteLine($"Şu anki ay: {monthName}");
    }
}
