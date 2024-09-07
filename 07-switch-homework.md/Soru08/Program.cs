namespace Soru08;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("0 ile 6 arasında bir sayı girin (0=Nokta, 1=Çizgi, 2=Açı, 3=Üçgen, 4=Kare, 5=Beşgen, 6=Altıgen): ");
        if (!int.TryParse(Console.ReadLine(), out int sekilNumarasi) || sekilNumarasi < 0 || sekilNumarasi > 6)
        {
            Console.WriteLine("Geçerli bir sayı girin (0 ile 6 arasında).");
            return;
        }


        string sekilAdi;
        switch (sekilNumarasi)
        {
            case 0:
                sekilAdi = "Nokta";
                break;
            case 1:
                sekilAdi = "Çizgi";
                break;
            case 2:
                sekilAdi = "Açı";
                break;
            case 3:
                sekilAdi = "Üçgen";
                break;
            case 4:
                sekilAdi = "Kare";
                break;
            case 5:
                sekilAdi = "Beşgen";
                break;
            case 6:
                sekilAdi = "Altıgen";
                break;
            default:
                sekilAdi = "Geçersiz şekil numarası";
                break;
        }

        Console.WriteLine($"Seçilen şekil: {sekilAdi}");
    }
}
