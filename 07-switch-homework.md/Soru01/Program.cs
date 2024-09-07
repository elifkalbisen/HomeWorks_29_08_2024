namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1 ile 7 arasında bir sayı girin (1=Pazartesi, 7=Pazar): ");
        
        if (!int.TryParse(Console.ReadLine(), out int dayNumber) || dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Geçerli bir sayı girin (1 ile 7 arasında).");
            return;
        }


        string dayName;
        switch (dayNumber)
        {
            case 1:
                dayName = "Pazartesi";
                break;
            case 2:
                dayName = "Salı";
                break;
            case 3:
                dayName = "Çarşamba";
                break;
            case 4:
                dayName = "Perşembe";
                break;
            case 5:
                dayName = "Cuma";
                break;
            case 6:
                dayName = "Cumartesi";
                break;
            case 7:
                dayName = "Pazar";
                break;
            default:
                dayName = "Geçersiz gün";
                break;
        }
        Console.WriteLine($"Seçilen gün: {dayName}");
    }
}
