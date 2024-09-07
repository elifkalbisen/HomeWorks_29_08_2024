namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Bir sayı girin: ");
        int n = int.Parse(Console.ReadLine());
        
        int toplam = 0;
        int sayac = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                toplam += i;
                sayac++;
            }
        }
        
        if (sayac > 0)
        {
            double ortalama = (double)toplam / sayac;
            Console.WriteLine("Ortalama: " + ortalama);
        }
        else
        {
            Console.WriteLine("Belirtilen aralıkta hem 3'ün hem de 4'ün katı olan sayı bulunmamaktadır.");
        }
    }
}
