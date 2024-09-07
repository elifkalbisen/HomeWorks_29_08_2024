namespace Soru09;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bir sayı al
        Console.Write("1 ile 5 arasında bir sayı girin (1=Birinci, 2=İkinci, 3=Üçüncü, 4=Dördüncü, 5=Beşinci): ");
        if (!int.TryParse(Console.ReadLine(), out int sayi) || sayi < 1 || sayi > 5)
        {
            Console.WriteLine("Geçerli bir sayı girin (1 ile 5 arasında).");
            return;
        }

        string sayiSifati;
        switch (sayi)
        {
            case 1:
                sayiSifati = "Birinci";
                break;
            case 2:
                sayiSifati = "İkinci";
                break;
            case 3:
                sayiSifati = "Üçüncü";
                break;
            case 4:
                sayiSifati = "Dördüncü";
                break;
            case 5:
                sayiSifati = "Beşinci";
                break;
            default:
                sayiSifati = "Geçersiz sayı";
                break;
        }

        Console.WriteLine($"Seçilen sayı sıfatı: {sayiSifati}");
    }
        
}
