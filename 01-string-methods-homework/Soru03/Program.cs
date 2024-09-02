namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Bir Cümle Giriniz : ");
        string cumle = Console.ReadLine();
        Console.WriteLine("Lütfen Aranacak Kelime Giriniz : ");
        string aranacakKelime = Console.ReadLine();
        string[] bosluktanAyırma = cumle.Split(" "); 
        int sayac = 0;
        for (int i = 0; i < bosluktanAyırma.Length; i++)
        {
            if (bosluktanAyırma[i] == aranacakKelime)
            {
                sayac++; 
            }
        }
        Console.WriteLine($"Aradığınız kelime, cümlenizde {sayac} kez geçmektedir.");
    }
}
