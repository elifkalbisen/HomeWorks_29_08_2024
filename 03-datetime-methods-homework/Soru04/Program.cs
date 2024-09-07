namespace Soru04;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İlk tarihi girin (yyyy-MM-dd formatında): ");
        string inputDate1 = Console.ReadLine();
        
        Console.Write("İkinci tarihi girin (yyyy-MM-dd formatında): ");
        string inputDate2 = Console.ReadLine();

        bool isValidDate1 = DateTime.TryParse(inputDate1, out DateTime date1);
        bool isValidDate2 = DateTime.TryParse(inputDate2, out DateTime date2);

        
        if (isValidDate1 && isValidDate2)
        {
            TimeSpan difference = date2 - date1;
            int daysDifference = (int)difference.TotalDays;

            Console.WriteLine($"İki tarih arasındaki gün farkı: {daysDifference} gün");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen yyyy-MM-dd formatında iki tarih girin.");
        }
    }
}
