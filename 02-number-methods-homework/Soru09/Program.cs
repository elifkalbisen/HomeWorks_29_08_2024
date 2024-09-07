namespace Soru09;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Birinci sayıyı girin: ");
        string input1 = Console.ReadLine();
        
        Console.Write("İkinci sayıyı girin: ");
        string input2 = Console.ReadLine();
        
        double sayi1, sayi2;
        if (double.TryParse(input1, out sayi1) && double.TryParse(input2, out sayi2))
        {
            // İki sayı arasındaki küçük olanı bul
            double kucukOlan = sayi1 < sayi2 ? sayi1 : sayi2;
            
            // Sonucu ekrana yazdır
            Console.WriteLine($"İki sayı arasındaki küçük olan: {kucukOlan}");
        }
        else
        {
            Console.WriteLine("Geçerli iki sayı girin.");
        }
    }
}
