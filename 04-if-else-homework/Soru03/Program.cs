namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir karakter girin: ");
        char karakter = char.Parse(Console.ReadLine());


        bool sesliHarfMi = (karakter == 'a' || karakter == 'e' || karakter == 'i' || 
                            karakter == 'o' || karakter == 'u' ||
                            karakter == 'A' || karakter == 'E' || karakter == 'I' || 
                            karakter == 'O' || karakter == 'U');

        // Sonucu ekrana yazdır
        if (sesliHarfMi)
        {
            Console.WriteLine($"{karakter} bir sesli harftir.");
        }
        else
        {
            Console.WriteLine($"{karakter} bir sesli harf değildir.");
        }
    }
}
