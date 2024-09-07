namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih girin (YYYY-MM-DD formatında): ");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime tarih))
        {
            DayOfWeek gun = tarih.DayOfWeek;
            
            Console.WriteLine($"Girilen tarih: {tarih.ToShortDateString()}");
            Console.WriteLine($"Haftanın günü: {gun}");
        }
        else
        {
            Console.WriteLine("Geçerli bir tarih formatı girin (YYYY-MM-DD).");
        }
    }
}
