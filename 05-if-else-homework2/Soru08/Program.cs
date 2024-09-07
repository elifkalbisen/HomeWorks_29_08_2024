namespace Soru08;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Doğum yılınızı girin (YYYY formatında): ");

        if (int.TryParse(Console.ReadLine(), out int dogumYili) && dogumYili > 0)
        {
            int kalan = dogumYili % 12;
            if (kalan == 0)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Maymun");
            }
            else if (kalan == 1)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Horoz");
            }
            else if (kalan == 2)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Köpek");
            }
            else if (kalan == 3)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Domuz");
            }
            else if (kalan == 4)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Fare");
            }
            else if (kalan == 5)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Öküz");
            }
            else if (kalan == 6)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Kaplan");
            }
            else if (kalan == 7)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Tavşan");
            }
            else if (kalan == 8)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Ejderha");
            }
            else if (kalan == 9)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Yılan");
            }
            else if (kalan == 10)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: At");
            }
            else if (kalan == 11)
            {
                Console.WriteLine("Çin Zodyağı burcunuz: Koyun");
            }
            else
            {
                Console.WriteLine("Hata: Beklenmedik bir durum oluştu.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir yıl girin.");
        }
    }
}
