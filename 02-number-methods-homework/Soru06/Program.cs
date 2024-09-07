namespace Soru06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir açı değeri girin (derece cinsinden): ");
        double derece = Convert.ToDouble(Console.ReadLine());

        // Dereceyi radyana dönüştürme
        double radyan = derece * (Math.PI / 180.0);

        // Sinüs değeri hesaplanır
        double sin = Math.Sin(radyan);

        // Sonuç ekrana yazdırılır
        Console.WriteLine($"Açının sinüsü: {sin}");
    }
}
