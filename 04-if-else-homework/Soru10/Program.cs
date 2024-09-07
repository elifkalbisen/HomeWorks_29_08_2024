namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Bir sayı girin: ");

        if (int.TryParse(Console.ReadLine(), out int sayi))
        {
            if (sayi <= 1)
            {
                Console.WriteLine($"{sayi} asal bir sayı değildir.");
            }
            else
            {
                bool asal = true;
                for (int i = 2; i <= Math.Sqrt(sayi); i++)
                {
                    if (sayi % i == 0)
                    {
                        asal = false;
                        break;
                    }
                }

                if (asal)
                {
                    Console.WriteLine($"{sayi} asal bir sayıdır.");
                }
                else
                {
                    Console.WriteLine($"{sayi} asal bir sayı değildir.");
                }
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz.");
        }
    }
}
