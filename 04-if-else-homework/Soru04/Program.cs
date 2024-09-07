namespace Soru04;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Bir yıl girin: ");

        if (int.TryParse(Console.ReadLine(), out int yil))
        {
            bool artikYilMi = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);

            if (artikYilMi)
            {
                Console.WriteLine($"{yil} bir artık yıldır.");
            }
            else
            {
                Console.WriteLine($"{yil} bir artık yıl değildir.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir yıl girmediniz.");
        }
    }
}
