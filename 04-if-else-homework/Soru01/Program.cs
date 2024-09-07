namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        string input = Console.ReadLine();
        
        bool sonuc = Int32.TryParse(input, out int sayi);
        
        if (sonuc)
        {
            
            if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı negatiftir.");
            }
            else
            {
                Console.WriteLine("Sayı sıfırdır.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin.");
        }
    }
}
