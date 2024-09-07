namespace Soru09;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi girin (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());

        double sonuc = 0;
        bool islemYapildi = true;


        if (islem == '+')
        {
            sonuc = sayi1 + sayi2;
            Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
        }
        else if (islem == '-')
        {
            sonuc = sayi1 - sayi2;
            Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
        }
        else if (islem == '*')
        {
            sonuc = sayi1 * sayi2;
            Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
        }
        else if (islem == '/')
        {
            
            if (sayi2 != 0)
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
            }
            else
            {
                Console.WriteLine("Hata: Sıfıra bölme hatası!");
                islemYapildi = false;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz işlem türü. Lütfen +, -, *, veya / girin.");
            islemYapildi = false;
        }

        if (!islemYapildi)
        {
            Console.WriteLine("Geçersiz işlem. Lütfen doğru bir işlem girin.");
        }
    }
}
