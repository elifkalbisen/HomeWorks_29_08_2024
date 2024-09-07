namespace Soru06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir not girin (0-100 arası): ");
        

        if (int.TryParse(Console.ReadLine(), out int not))
        {
            if (not >= 0 && not <= 100)
            {
                string harfNotu;
                if (not >= 90)
                {
                    harfNotu = "AA";
                }
                else if (not >= 85)
                {
                    harfNotu = "BA";
                }
                else if (not >= 80)
                {
                    harfNotu = "BB";
                }
                else if (not >= 70)
                {
                    harfNotu = "CB";
                }
                else if (not >= 60)
                {
                    harfNotu = "CC";
                }
                else if (not >= 55)
                {
                    harfNotu = "DC";
                }
                else if (not >= 50)
                {
                    harfNotu = "DD";
                }
                else if (not >= 40)
                {
                    harfNotu = "FD";
                }
                else
                {
                    harfNotu = "FF";
                }

                if(not <= 100 && not >= 40)
                {
                    Console.WriteLine($"Notunuz: Yeterli {harfNotu}");
                }  
                if(not <= 39 && not >= 0)
                {
                    Console.WriteLine($"Notunuz: Yetersiz {harfNotu}");
                }  
            }
            else
            {
                Console.WriteLine("Lütfen 0 ile 100 arasında geçerli bir not girin.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz.");
        }
    }
}
