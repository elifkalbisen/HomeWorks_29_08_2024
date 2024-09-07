namespace Soru02;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("1 ile 12 arasında bir sayı girin (1=Ocak, 12=Aralık): ");
        
        if (!int.TryParse(Console.ReadLine(), out int monthNumber) || monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Geçerli bir sayı girin (1 ile 12 arasında).");
            return;
        }

        string monthName;
        switch (monthNumber)
        {
            case 1:
                monthName = "Ocak";
                break;
            case 2:
                monthName = "Şubat";
                break;
            case 3:
                monthName = "Mart";
                break;
            case 4:
                monthName = "Nisan";
                break;
            case 5:
                monthName = "Mayıs";
                break;
            case 6:
                monthName = "Haziran";
                break;
            case 7:
                monthName = "Temmuz";
                break;
            case 8:
                monthName = "Ağustos";
                break;
            case 9:
                monthName = "Eylül";
                break;
            case 10:
                monthName = "Ekim";
                break;
            case 11:
                monthName = "Kasım";
                break;
            case 12:
                monthName = "Aralık";
                break;
            default:
                monthName = "Geçersiz ay";
                break;
        }

        Console.WriteLine($"Seçilen ay: {monthName}");
    
    }
}
