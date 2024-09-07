namespace Soru08;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bir sayı alınır
        Console.Write("Bir sayı girin: ");

        // Sayının geçerli bir tam sayı olup olmadığını kontrol et
        if (int.TryParse(Console.ReadLine(), out int sayi))
        {
            bool bolunebiliyorMu = (sayi % 3 == 0) && (sayi % 5 == 0);

            if (bolunebiliyorMu)
            {
                Console.WriteLine($"{sayi} hem 3'e hem de 5'e tam bölünebilir.");
            }
            else
            {
                Console.WriteLine($"{sayi} hem 3'e hem de 5'e tam bölünemez.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz.");
        }
    }
}
