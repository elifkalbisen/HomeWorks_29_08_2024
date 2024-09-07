namespace Soru07;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Derece cinsinden açıyı girin: ");
        string input = Console.ReadLine();
        
        double derece;
        if (double.TryParse(input, out derece))
        {           
            double radyan = derece * (Math.PI / 180);
            Console.WriteLine($"{derece} derece, {radyan:F4} radyan eder.");
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girin.");
        }
    }
}
