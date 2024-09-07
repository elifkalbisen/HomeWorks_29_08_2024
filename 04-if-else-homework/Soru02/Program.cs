namespace Soru02;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan üç sayı alın
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int sayi3 = int.Parse(Console.ReadLine());

        if (sayi1 >= sayi2 && sayi1 >= sayi3)
        {
            if (sayi2 >= sayi3)
                Console.WriteLine($"{sayi1}, {sayi2}, {sayi3}");
            else
                Console.WriteLine($"{sayi1}, {sayi3}, {sayi2}");
        }
        else if (sayi2 >= sayi1 && sayi2 >= sayi3)
        {
            if (sayi1 >= sayi3)
                Console.WriteLine($"{sayi2}, {sayi1}, {sayi3}");
            else
                Console.WriteLine($"{sayi2}, {sayi3}, {sayi1}");
        }
        else
        {
            if (sayi1 >= sayi2)
                Console.WriteLine($"{sayi3}, {sayi1}, {sayi2}");
            else
                Console.WriteLine($"{sayi3}, {sayi2}, {sayi1}");
        }
    }
}
