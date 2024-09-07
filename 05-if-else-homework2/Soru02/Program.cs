namespace Soru02;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci kenarın uzunluğunu girin: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci kenarın uzunluğunu girin: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçüncü kenarın uzunluğunu girin: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            double s = (a + b + c) / 2;

            double alan = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"Üçgenin alanı: {alan:F2}");
        }
        else
        {
            Console.WriteLine("Girilen kenar uzunlukları geçerli bir üçgen oluşturmaz.");
        }
    }
}
