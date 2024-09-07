namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        string inputDate = Console.ReadLine();
        
        bool isValidDate = DateTime.TryParse(inputDate, out DateTime parsedDate);

        if (isValidDate)
        {
            int dayOfYear = parsedDate.DayOfYear;

            Console.WriteLine($"Girdiğiniz tarih, yılın {dayOfYear}. günüdür.");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen yyyy-MM-dd formatında bir tarih girin.");
        }
    }
}
