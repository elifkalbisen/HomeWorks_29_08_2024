namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        string inputDate = Console.ReadLine();
        bool isValidDate = DateTime.TryParse(inputDate, out DateTime parsedDate);

        Console.Write("Eklemek istediğiniz gün sayısını girin: ");
        string inputDays = Console.ReadLine();
        bool isValidDays = int.TryParse(inputDays, out int daysToAdd);

        // Tarih ve gün sayısı geçerliyse yeni tarihi hesapla
        // Geçersizse uygun hata mesajı verir
        DateTime newDate = isValidDate ? parsedDate.AddDays(isValidDays ? daysToAdd : 0) : default(DateTime);

        // Sonuçları ekrana yazdır
        Console.WriteLine(isValidDate ? (isValidDays ? $"Yeni tarih: {newDate:yyyy-MM-dd}" : "Geçersiz gün sayısı.") 
 : "Geçersiz tarih formatı.");
    }
}
