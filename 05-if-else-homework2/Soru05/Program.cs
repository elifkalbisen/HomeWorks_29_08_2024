namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Boyunuzu metre cinsinden girin (örneğin, 1.75): ");
        Console.Write("Kilonuzu kilogram cinsinden girin: ");

        if (double.TryParse(Console.ReadLine(), out double boy) && boy > 0 &&
            double.TryParse(Console.ReadLine(), out double kilo) && kilo > 0)
        {
            
            double index = kilo / (boy * boy);

            // Sonucu ekrana yazdır
            Console.WriteLine($"Vücut Kitle İndeksiniz (BMI): {index:F2}");
        }
        else
        {
            Console.WriteLine("Geçerli bir boy veya kilo değeri girmediniz.");
        }
    }
}
