namespace Soru07;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int enBuyuk = sayi1;

        if (sayi2 > enBuyuk)
        {
            enBuyuk = sayi2;
        }

        if (sayi3 > enBuyuk)
        {
            enBuyuk = sayi3;
        }

        Console.WriteLine($"Girilen sayılardan en büyüğü: {enBuyuk}");
    }
}
