namespace Soru07;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi girin (+, -, *, /): ");
        string islem = Console.ReadLine();
        switch (islem)
        {
            case "+":
                Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
                break;

            case "-":
                Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
                break;

            case "*":
                Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
                break;

            case "/":
                if (sayi2 != 0)
                {
                    Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
                }
                else
                {
                    Console.WriteLine("Hata: Sıfıra bölme hatası.");
                }
                break;

            default:
                Console.WriteLine("Geçersiz işlem. Lütfen +, -, * veya / girin.");
                break;
        }
    }
}
