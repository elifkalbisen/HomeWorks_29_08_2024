namespace Soru04;

class Program
{
    static void Main(string[] args)
    {
        const double pi = 3.14159;
        Console.Write("Dairenin yarı çapını girin: ");

        if (double.TryParse(Console.ReadLine(), out double yaricap) && yaricap >= 0)
        {
            double alan = pi * Math.Pow(yaricap, 2);
            double cevre = 2 * pi * yaricap;

            Console.WriteLine($"Dairenin yarı çapı: {yaricap}");
            Console.WriteLine($"Dairenin alanı: {alan:F2}");
            Console.WriteLine($"Dairenin çevresi: {cevre:F2}");
        }
        else
        {
            Console.WriteLine("Geçerli bir yarı çap girmediniz.");
        }
    }
}
