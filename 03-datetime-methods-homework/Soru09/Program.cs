namespace Soru09;

class Program
{
    static void Main(string[] args)
    {
                // Kullanıcıdan tarihleri alın
        Console.Write("Birinci tarihi girin (yyyy-MM-dd formatında): ");
        string tarih1Input = Console.ReadLine();
        
        Console.Write("İkinci tarihi girin (yyyy-MM-dd formatında): ");
        string tarih2Input = Console.ReadLine();

        bool tarih1Valid = DateTime.TryParse(tarih1Input, out DateTime tarih1);
        bool tarih2Valid = DateTime.TryParse(tarih2Input, out DateTime tarih2);

        if (tarih1Valid && tarih2Valid)
        {
            if (tarih1 < tarih2)
            {
                Console.WriteLine("Birinci tarih, ikinci tarihten öncedir.");
            }
            else if (tarih1 > tarih2)
            {
                Console.WriteLine("Birinci tarih, ikinci tarihten sonradır.");
            }
            else
            {
                Console.WriteLine("İki tarih aynıdır.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen yyyy-MM-dd formatında tarih girin.");
        }
    }
}
